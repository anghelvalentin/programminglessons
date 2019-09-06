using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogPostBuilder blogPostBuilder = new BlogPostBuilder();

            blogPostBuilder.BuildTitle("Builder");
            blogPostBuilder.BuildBody("A design pattern");
            blogPostBuilder.BuildBody("This is the body of the post");

            BlogPost blogPost = blogPostBuilder.GetBlogPost();

            blogPostBuilder.Reset();


            blogPostBuilder.BuildTitle("Interview questions");
            blogPostBuilder.BuildBody("1. What is the result of int? x = n ??-1; //n=null");

            BlogPost blogPost2 = blogPostBuilder.GetBlogPost();

        }
    }
}
