using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using UmbracoWithMvc.Models;

namespace UmbracoWithMvc.Controllers
{
    public class RenewalController : SurfaceController
    {
        // GET: Renewal
        public ActionResult Index(string id)
        {
            if (id == "error")
            {
                return PartialView("error");
            }
            Guid Id = new Guid(id);

            List<Guid> directors = new List<Guid>();
            directors.Add(Guid.Parse("d0b08302-78b0-4dac-b9c0-17b5767fbf64"));
            directors.Add(Guid.Parse("de2efc57-85a1-403b-b0de-7680f7e8f782"));
            directors.Add(Guid.Parse("656fd2a7-550c-40b8-87a6-49074b5225e1"));
    

            if (Id != null)
            {
                if (directors.Contains(Id))
                {
                    var errorUrl = "error";
                    //redirect to cart
                    return Redirect(errorUrl);
                }
                else
                {
                    var cartUrl = "error";
                    //redirect to cart
                    return Redirect(cartUrl);
                }
            }
            return CurrentUmbracoPage();
        } 
    }
}