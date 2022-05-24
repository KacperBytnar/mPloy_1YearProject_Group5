using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Models
{
    public class Task
    {
        public Task()
        {
            //this.Users = new HashSet<AppUser>();
        }

        [Key]
        public int TaskID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string? Location { get; set; }
        public string? PictureName { get; set; }
        public DateTime DueDate { get; set; }
        [Required]
        public int Prize { get; set; }
        public TaskState State { get; set; }
        [Required]
        public PaymentMethod Payment { get; set; }
        [Required]
        public TaskCategory Categories {get;set;}

        public enum TaskCategory
        {
            Cleaning,   
            MovingServices,
            Handyman,
            Gardening
        }

        public enum TaskState
        {
            Open,
            InProgress,
            Closed
        }

        public enum PaymentMethod
        {
            Cash,
            MobilePay,
            BankTransfer,
            SecurePayment
        }


        // Foreign Keys
        [ForeignKey(nameof(CreatorID))]
        public int CreatorID { get; set; }

        //[ForeignKey(nameof(PerformerID))]
        //public int? PerformerID { get; set; }

        // Navigation Properties
        public virtual AppUser User { get; set; }
        //public virtual ICollection<AppUser> Users{ get; set; }
        public virtual ICollection<UserBidOnTask> Bids { get; set; }
    }
}
