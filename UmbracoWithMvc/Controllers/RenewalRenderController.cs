using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace UmbracoWithMvc.Controllers
{
    public class RenewalRenderController : RenderMvcController
    {
        // GET: RenewalRender
        public override ActionResult Index(RenderModel model)
        {
            return CurrentTemplate(model);
        }
        public ActionResult Cart(RenderModel model)
        {
            // Create AMP specific content here...
            return CurrentTemplate(model);
        }
    }
}