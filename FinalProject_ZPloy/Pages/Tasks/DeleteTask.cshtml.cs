using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_ZPloy.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject_ZPloy.Pages.Tasks
{
    public class DeleteTaskModel : PageModel
    {

        ITaskService taskService;

        [BindProperty]
        public Models.Task task { get; set; }

        public DeleteTaskModel(ITaskService service)
        {
            taskService = service;
        }
        public IActionResult OnGet(int id)
        {
            task = taskService.GetTask(id);
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            taskService.DeleteTask(id);
            
            return RedirectToPage("GetAllTasks");
        }
    }
}
