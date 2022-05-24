using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FinalProject_ZPloy.Models;
using FinalProject_ZPloy.Services.Interfaces;
using FinalProject_ZPloy.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject_ZPloy.Pages.UserAccount
{
    public class CreateUserModel : PageModel
    {
        [BindProperty]
        public RegisterViewModel registerModel { get; set; }
        public string registerMessage { get; set; }


        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public CreateUserModel(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (registerModel.Password != registerModel.ConfirmPassword)
            {
                registerMessage = "Passwords are different!";
                return Page();
            }
            else if (registerModel.Password == null)
            {
                registerMessage = "Password can't be empty!";
                return Page();
            }
            else
            {
                var userr = new AppUser() { Email = registerModel.Username, UserName = registerModel.Username };
                var result = await userManager.CreateAsync(userr, registerModel.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(userr, isPersistent: false);
                    return RedirectToPage("/UserAccount/DisplayUser");
                }
                else
                {
                    foreach (var er in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, er.Description);
                        registerMessage = er.Description;
                    }
                    return Page();
                }
            }
        }
    }
}

