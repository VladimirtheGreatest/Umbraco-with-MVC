using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Models;

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
        
           var rootNode = umbracoContext.ContentCache.GetById(1073);

           var siteTitle = rootNode.GetPropertyValue<string>("siteTitle");

            ViewBag.SiteTitle = siteTitle;

            var model = new RenderModel(rootNode, Thread.CurrentThread.CurrentCulture);

            return View(model);
        }

    }
}