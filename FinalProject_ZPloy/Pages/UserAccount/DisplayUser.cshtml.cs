using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_ZPloy.Common;
using FinalProject_ZPloy.Models;
using FinalProject_ZPloy.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject_ZPloy.Pages.UserAccount
{
    [Authorize]
    public class DisplayUserModel : PageModel
    {
        [BindProperty]
        public AppUser LoggedUser { get; set; }
    
        private IUserService userService;
        [BindProperty]
        public int UserID { get; set; }
        public DisplayUserModel(IUserService service)
        {
            userService = service; 
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
                LoggedUser.Picture = "/Images/Avatars/avatar7.png";

            }
        }
    }
}
