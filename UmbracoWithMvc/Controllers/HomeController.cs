using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;

namespace UmbracoWithMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly UmbracoContext umbracoContext;

        public HomeController()
        {
            umbracoContext = UmbracoContext.Current; 
        }
        public ActionResult Index()
        {
           // var user = umbracoContext.Security.CurrentUser.Email;
           var rootNode = umbracoContext.ContentCache.GetById(1073);

           var siteTitle = rootNode.GetPropertyValue<string>("siteTitle");

            ViewBag.SiteTitle = siteTitle;
           // ViewBag.User = user;

            return View();
        }

    }
}