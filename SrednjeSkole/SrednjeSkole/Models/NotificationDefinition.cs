using System;
using System.Collections.Generic;
using System.Text;

namespace SrednjeSkole.Models
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
       
        public string name { get; set; }        
        public string title { get; set; }      
        public string body { get; set; }
        public object custom_data { get; set; }
    }
}
