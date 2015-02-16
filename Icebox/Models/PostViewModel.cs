using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icebox.Models
{
    public class PostViewModel
    {
    }

    public enum ContentType
    {
        Image,
        Text,
        Video
    }

    public class Content
    {
        public ICollection<String> Tags { get; set; }
        public ContentType ContentType { get; set; }
    }

    public class ImageContent : Content
    {
        this.ContentType = ContentType.Image;

        public String Url { get; set; }
    }

    public class IContentItem
    {
        public ContentType ItemType { get; set; }
        public Content Data { get; set; }

    }
}