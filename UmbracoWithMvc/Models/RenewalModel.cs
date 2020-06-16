using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace UmbracoWithMvc.Models
{
    public  class RenewalModel : RenderModel
    {
       
        public RenewalModel() : base(UmbracoContext.Current.PublishedContentRequest.PublishedContent) { }
    
        public Guid Id { get; set; }
    }
}