using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core;
using Umbraco.Web;

namespace UmbracoWithMvc
{
    public class CustomUmbracoRoutingApp : UmbracoApplication
    {
        protected override IBootManager GetBootManager()
        {
            return new CustomWebBootManager(this);
        }

        class CustomWebBootManager : WebBootManager
        {
            public CustomWebBootManager(UmbracoApplicationBase application)
                : base(application)
            {
            }

            public override IBootManager Complete(Action<ApplicationContext> afterComplete)
            {
                RouteTable.Routes.MapRoute(
                    "Renewal",
                    "renewal/index/{id}",
                    new { controller = "Renewal", action = "Renew", id = "" }
                );
                return base.Complete(afterComplete);
            }
        }
    }
}