using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SrednjeSkole_API.Models
{
    public class NotificationDefinition
    {
        public NotificationTarget notification_target { get; set; }
        public NotificationContent notification_content { get; set; }

    }

    public class NotificationTarget
    {
        public string type { get; set; }

    }
 
    public class NotificationContent
    {
        [MinLength(3)]
        [MaxLength(64)]
        public string name { get; set; }
        [MaxLength(128)]
        public string title { get; set; }
        [MinLength(1)]
        [MaxLength(4000)]
        public string body { get; set; }
        public object custom_data { get; set; }
    }
}