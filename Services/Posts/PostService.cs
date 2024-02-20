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

        public Post? AddPostUpvote(int postId)
        {
            Post? foundPost = context.Posts.FirstOrDefault(p => p.PostId == postId);

            if (foundPost != null)
            {
                foundPost.PostUpvotes += 1;

                context.SaveChanges();

                return foundPost;
            }

            return foundPost;
        }

        public Post? AddPostDownvote(int postId)
        {
            Post? foundPost = context.Posts.FirstOrDefault(p => p.PostId == postId);

            if (foundPost != null)
            {
                foundPost.PostDownvotes += 1;

                context.SaveChanges();

                return foundPost;
            }

            return foundPost;
        }

        public List<Post> GetPosts()
        {
            List<Post> allPosts = context.Posts.ToList();

            return allPosts;
        }

        public List<Comment> GetPostComments(int postId)
        {
            Post? post = context.Posts.FirstOrDefault(p => p.PostId == postId);

            if (post == null) return new List<Comment>();

            List<Comment> postComments = post.PostComments.ToList();

            return postComments;
        }

        public Post? RemovePostUpvote(int postId)
        {
            Post? foundPost = context.Posts.FirstOrDefault(p => p.PostId == postId);

            if (foundPost != null)
            {
                foundPost.PostUpvotes -= 1;

                context.SaveChanges();

                return foundPost;
            }

            return foundPost;
        }

        public Post? RemovePostDownvote(int postId)
        {
            Post? foundPost = context.Posts.FirstOrDefault(p => p.PostId == postId);

            if (foundPost != null)
            {
                foundPost.PostDownvotes -= 1;

                context.SaveChanges();

                return foundPost;
            }

            return foundPost;
        }
    }
}
