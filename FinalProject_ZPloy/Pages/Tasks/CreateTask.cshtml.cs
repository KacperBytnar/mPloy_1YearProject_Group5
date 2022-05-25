 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mPloy_FinalProject_group5.Common;
using mPloy_FinalProject_group5.Models;
using mPloy_FinalProject_group5.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mPloy_FinalProject_group5.Pages.Tasks
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
