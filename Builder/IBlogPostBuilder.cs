using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface IBlogPostBuilder
    {       
            void BuildTitle(string title);
            void BuildSubtitle(string subtitle);
            void BuildBody(string body);

            BlogPost GetBlogPost();

            void Reset();
    }
}
