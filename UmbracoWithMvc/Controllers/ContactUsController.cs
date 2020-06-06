using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using UmbracoWithMvc.Models;

namespace UmbracoWithMvc.Controllers
{
    public class ContactUsController : SurfaceController
    {
       
        public ActionResult Index(ContactUsModel model)
       {
            if (ModelState.IsValid)
            {
                return RedirectToCurrentUmbracoPage();
            }
            return CurrentUmbracoPage();
        }
    }
}