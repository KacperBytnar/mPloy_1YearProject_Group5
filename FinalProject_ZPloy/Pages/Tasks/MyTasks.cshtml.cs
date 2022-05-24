using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_ZPloy.Common;
using FinalProject_ZPloy.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject_ZPloy.Pages.Tasks
{
    public class MyTasksModel : PageModel
    {
        private ITaskService taskService;
        public IBidService bidService;

        [BindProperty]
        public IEnumerable<Models.Task> tasks { get; set; }

        public string text { get; set; } = "Nobody has applied for the task yet!";

        [BindProperty]
        public int loggedUser { get; set; }


        public MyTasksModel(ITaskService tservice, IBidService bService)
        {
            taskService = tservice;
            bidService = bService;
        }
        // check here whether logged user is creator and display stuff based on that 
        // maybe just get task id instead of bool 
        public void OnGet()
        {
            loggedUser = User.GetUserId();
            tasks = taskService.GetUserTasksCreatedByUserId(loggedUser);
        }
    }
}
