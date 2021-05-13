using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieTracker.Models
{
    public class Cookie
    {
        public int Visits { get; set;}
        public string IPAddress { get; set; }
        public string TimeZone { get; set; }
    }
}
