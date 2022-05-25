using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mPloy_FinalProject_group5.Models
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public string Title { get; set; }
        public string MessageText { get; set; }
        public bool isRead { get; set; }
    }
}
