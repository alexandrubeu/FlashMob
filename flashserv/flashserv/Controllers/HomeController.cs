using System;
using System.Collections.Generic;
using System.Linq;
using System.Web; 
using System.Web.Mvc;

namespace flashserv.Controllers
{
 
    public class HomeController : Controller
    {
        [Route("/")]
        public string Index()
        {
            return "Code hard and have fun guys... first and first we need to have fun!!!!! now go make nerds proud";
        }
    }
}
