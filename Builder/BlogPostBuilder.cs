using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class BlogPostBuilder : IBlogPostBuilder
    {
        private BlogPost _blogPost = new BlogPost();

        public void BuildBody(string body)
        {
            this._blogPost.Fields.Add("Body:" + body);
        }

        public void BuildSubtitle(string subtitle)
        {
            this._blogPost.Fields.Add("Subtitle:" + subtitle);
        }

        public void BuildTitle(string title)
        {
            this._blogPost.Fields.Add("Title:" + title);
        }

        public BlogPost GetBlogPost()
        {
            return this._blogPost;
        }

        public void Reset()
        {
            _blogPost = new BlogPost();
        }
    }
}
