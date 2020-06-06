using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using UmbracoWithMvc.Models;

namespace UmbracoWithMvc.Controllers
{
    public class BlogPostRepositoryController : RenderMvcController
    {
        
        public ActionResult BlogOverView(RenderModel model)
        {
            ViewBag.Hello = "conflict from develop branch";

            var blogOverviewModel = new BlogOverViewModel(model.Content, Umbraco);

            return Index(new RenderModel(blogOverviewModel));
        }
    }
}