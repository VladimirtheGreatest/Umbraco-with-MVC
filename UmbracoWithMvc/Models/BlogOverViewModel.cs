﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace UmbracoWithMvc.Models
{
    public class BlogOverViewModel : IPublishedContent
    {

        private readonly IPublishedContent content;
        private UmbracoHelper umbraco;

        public BlogOverViewModel(IPublishedContent content, UmbracoHelper umbraco)
        {
            this.umbraco = umbraco;
            this.content = content;
        }

        public IEnumerable<BlogPostModel> Posts
        {
            get
            {
                return Children.Where(c => c.DocumentTypeAlias == "BlogPost")
                    .Select(c => new BlogPostModel(c, umbraco));
            }
        }
        public object this[string alias]
        {
            get
            {
                return content[alias];
            }
        }

        public IEnumerable<IPublishedContent> Children
        {
            get
            {
                return content.Children;
            }
        }

        public IEnumerable<IPublishedContent> ContentSet
        {
            get
            {
                return content.ContentSet;
            }
        }

        public PublishedContentType ContentType
        {
            get
            {
                return content.ContentType;
            }
        }

        public DateTime CreateDate
        {
            get
            {
                return content.CreateDate;
            }
        }

        public int CreatorId
        {
            get
            {
                return content.CreatorId;
            }
        }

        public string CreatorName
        {
            get
            {
                return content.CreatorName;
            }
        }

        public string DocumentTypeAlias
        {
            get
            {
                return content.DocumentTypeAlias;
            }
        }

        public int DocumentTypeId
        {
            get
            {
                return content.DocumentTypeId;
            }
        }

        public int Id
        {
            get
            {
                return content.Id;
            }
        }

        public bool IsDraft
        {
            get
            {
                return content.IsDraft;
            }
        }

        public PublishedItemType ItemType
        {
            get
            {
                return content.ItemType;
            }
        }

        public int Level
        {
            get
            {
                return content.Level;
            }
        }

        public string Name
        {
            get
            {
                return content.Name;
            }
        }

        public IPublishedContent Parent
        {
            get
            {
                return content.Parent;
            }
        }

        public string Path
        {
            get
            {
                return content.Path;
            }
        }

        public ICollection<IPublishedProperty> Properties
        {
            get
            {
                return content.Properties;
            }
        }

        public int SortOrder
        {
            get
            {
                return content.SortOrder;
            }
        }

        public int TemplateId
        {
            get
            {
                return content.TemplateId;
            }
        }

        public DateTime UpdateDate
        {
            get
            {
                return content.UpdateDate;
            }
        }

        public string Url
        {
            get
            {
                return content.Url;
            }
        }

        public string UrlName
        {
            get
            {
                return content.UrlName;
            }
        }

        public Guid Version
        {
            get
            {
                return content.Version;
            }
        }

        public int WriterId
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string WriterName
        {
            get
            {
                return content.WriterName;
            }
        }

        public int GetIndex()
        {
            return content.GetIndex();
        }

        public IPublishedProperty GetProperty(string alias)
        {
            return content.GetProperty(alias);
        }

        public IPublishedProperty GetProperty(string alias, bool recurse)
        {
            return content.GetProperty(alias, recurse);
        }
    }
}