using OPC5_BlogApp.Data;
using OPC5_BlogApp.Data.Models;

namespace Services.Posts
{
    public class PostService(ApplicationDbContext _context) : IPostService
    {
        private readonly ApplicationDbContext context = _context;

        public void AddPost(Post post)
        {
            context.Posts.Add(post);
            context.SaveChanges();
        }

        public List<Post> GetPosts()
        {
            List<Post> allPosts = context.Posts.ToList();

            return allPosts;
        }
    }
}
