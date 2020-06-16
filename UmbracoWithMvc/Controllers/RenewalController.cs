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
    public class RenewalController : RenderMvcController
    {
        // GET: Renewal
        // url needs to looks like this http://localhost:2225/renewal/?id=5021f79d-d48a-ea11-a811-00224801c499
        public ActionResult Renewal(RenderModel model, string id)
        {
            if (id == "error")
            {
                return PartialView("error");
            }

            Guid Id = new Guid(id);
            var renewalModel = new RenewalModel();
            renewalModel.Id = Id;

            //mocking directors from CRM
            List<Guid> directors = new List<Guid>();
            directors.Add(Guid.Parse("d0b08302-78b0-4dac-b9c0-17b5767fbf64"));
            directors.Add(Guid.Parse("de2efc57-85a1-403b-b0de-7680f7e8f782"));
            directors.Add(Guid.Parse("656fd2a7-550c-40b8-87a6-49074b5225e1"));
    

            if (Id != null)
            {
                if (directors.Contains(Id))
                {
                    //redirect to cart here
                    var errorUrl = "renew";
                    //redirect to cart
                    return Redirect(errorUrl);
                }
                else
                {
                   
                    return base.Index(renewalModel);
                }
            }

            return base.Index(renewalModel);
        } 
    }
}