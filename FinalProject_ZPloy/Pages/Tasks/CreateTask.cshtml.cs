 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_ZPloy.Common;
using FinalProject_ZPloy.Models;
using FinalProject_ZPloy.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject_ZPloy.Pages.Tasks
{
    [Authorize]
    public class CreateTaskModel : PageModel
    {
        ITaskService taskService;
        [BindProperty]
        public Models.Task task { get; set; }
        public int UserID { get; set; }

        public CreateTaskModel(ITaskService tService)
        {
            taskService = tService;
        }

        public IActionResult OnGet()
        {
            UserID = User.GetUserId();
            return Page();
        }
        public IActionResult OnPost(int UserID)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            taskService.CreateTask(task, UserID);
            return RedirectToPage("GetAllTasks");
        }
    }
}
