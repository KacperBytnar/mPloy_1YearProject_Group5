using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using mPloy_FinalProject_group5.Common;
using mPloy_FinalProject_group5.Models;
using mPloy_FinalProject_group5.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mPloy_FinalProject_group5.Pages.UserAccount
{
    public class EditUserModel : PageModel
    {
        [BindProperty]
        public AppUser LoggedUser { get; set; }
        private IUserService userService;
        [BindProperty]
        public int UserID { get; set; }
        [BindProperty]
        public IFormFile Upload { get; set; } 
        // path for the Images folder
        private string ImagePath
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Images/Avatars"); }
        }
        public IWebHostEnvironment WebHostEnvironment { get; } //Property
        private IHostingEnvironment _environment;
        public EditUserModel(IUserService userService, IHostingEnvironment environment, IWebHostEnvironment webHostEnvironment)
        {
            this.userService = userService;
            _environment = environment;
            WebHostEnvironment = webHostEnvironment;
        }
        public void OnGet()
        {
            UserID = User.GetUserId();
            LoggedUser = userService.GetUserById(UserID);
            if (!string.IsNullOrEmpty(LoggedUser.Picture))
            {
                LoggedUser.Picture = "/Images/Avatars/" + LoggedUser.Picture;
            }
            else
            {
                LoggedUser.Picture = "/Images/Avatars/DefaultAvatar.png";

            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //if (Upload.FileName != null)
            //{
            //    var file = Path.Combine(_environment.ContentRootPath, ImagePath, Upload.FileName);
            //    using (var fileStream = new FileStream(file, FileMode.Create))
            //    {
            //        Upload.CopyTo(fileStream);
            //    }
            //    LoggedUser.Picture = Upload.FileName;


            //    userService.EditUser(LoggedUser);
            //    return RedirectToPage("/UserAccount/DisplayUser");
            //}
            else
            {
                userService.EditUser(LoggedUser);
                return RedirectToPage("/UserAccount/DisplayUser");
            }
            
        }
    }
}
