using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icebox
{
    public enum ContentKind
    {
        Image,
        Text,
        Video
    }

    public class Content
    {
        protected readonly ContentKind _kind;

        public ContentKind Kind { get { return _kind; } }

        public Content(ContentKind kind)
        {
            _kind = kind;
        }
        public ImageContent AsImageContent()
        {
            if (_kind == ContentKind.Image)
                return (ImageContent)this;

            return null;
        }
    }

    public class ImageContent : Content
    {
        private string _url;
        public string Url { get { return _url; } }

        public ImageContent() : this(/* url */ "") { }
        public ImageContent(string url) : base(ContentKind.Image)
        {
            _url = url;
        }
    }

    public class TextContent : Content
    {
        private string _text;
        public string Text { get { return _text; } }

        public TextContent() : this(/* text */ null) { }
        public TextContent(string text) : base(ContentKind.Text)
        {
            _text = text;
        }
    }

    public class VideoContent : Content
    {
        private string _url;

        public string Url { get { return _url; } }

        public VideoContent() : this(/* url */ "") { }
        public VideoContent(string url) : base(ContentKind.Video)
        {
            _url = url;
        }
    }
}