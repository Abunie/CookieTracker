using CookieTracker.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CookieTracker.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index(Cookie cookie)
        {
            int visits = 0;
            String visitcount = Request.Cookies["VisitCount"];
           
            if (visitcount != null)
            {
                visits = Int32.Parse(visitcount);
                visits++;
            }
            else
            {
                visits = 1;
            }

            Response.Cookies.Delete("VisitCount");
            CookieOptions duration = new CookieOptions();
            duration.Expires = DateTime.Now.AddDays(2);
            Response.Cookies.Append("VisitCount", (visits).ToString(), duration);

            cookie.IPAddress = Request.HttpContext.Connection.LocalIpAddress.ToString();
            cookie.Visits = visits;
            return View(cookie);
        }
    
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
