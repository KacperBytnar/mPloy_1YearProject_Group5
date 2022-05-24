using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_ZPloy.Models;
using FinalProject_ZPloy.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject_ZPloy.Pages.Tasks
{
    public class ApplicationsModel : PageModel
    {

        ITaskService taskService;
        public IBidService bidService;

        [BindProperty]
        public Models.Task Task { get; set; }
        [BindProperty]
        public List<AppUser> UsersApplying { get; set; } = new List<AppUser>();
        public string text { get; set; } = "Nobody has applied for the task yet!";
        public ApplicationsModel(ITaskService tservice, IBidService bService)
        {
            taskService = tservice;
            bidService = bService;
        }
        public IActionResult OnGet(int id)
        {
            Task = taskService.GetTask(id);
            UsersApplying = (List<AppUser>)bidService.GetListOfUsersApplyingForSpecificTask(id);
            return Page();
        }

        public IActionResult OnPostApprove(int ID)
        {
            bidService.ApproveBid(bidService.GetBidByTaskId(ID));
            return Page();
        }
    }
}
