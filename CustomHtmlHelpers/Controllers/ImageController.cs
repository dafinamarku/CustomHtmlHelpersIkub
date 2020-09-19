using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHtmlHelpers.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult Index()
        {
            return View();
        }
    //kthen nje view ku afishohet imazhi me ane te custom html helper te krijuar
    public ActionResult DisplayImage()
    {
      return View();
    }
    }
}