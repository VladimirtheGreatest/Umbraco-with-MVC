using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace UmbracoWithMvc.Models
{
    public class BlogPostModel 
    {
        private IPublishedContent content;
        private UmbracoHelper umbraco;

        public BlogPostModel(IPublishedContent content, UmbracoHelper umbraco)
        {
            this.umbraco = umbraco;
            this.content = content;
        }

        public DateTime CreateDate
        {
            get { return content.CreateDate; }
        }

        public string Url
        {
            get { return content.Url; }
        }

        public string Name
        {
            get { return content.Name; }
        }

        public IHtmlString Introduction
        {
            get
            {
                var value = (string)content.GetProperty("introduction").Value;
                return umbraco.Truncate(value, 240, true);
            }
        }
    }
}