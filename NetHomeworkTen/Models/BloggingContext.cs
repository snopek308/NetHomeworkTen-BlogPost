using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetHomeworkTen.Models
{
    class BloggingContext : DbContext
    {
        public BloggingContext() : base("name=BlogContext") { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts {get; set;}

        public void AddBlog(Blog blog)
        {
            this.Blogs.Add(blog);
            this.SaveChanges();
        }

        public void AddPost(Post post)
        {
            this.Posts.Add(post);
            this.SaveChanges();
        }

    }
}
