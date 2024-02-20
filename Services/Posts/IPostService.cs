using OPC5_BlogApp.Data.Models;

namespace Services.Posts
{
    public interface IPostService
    {
        void AddPost(Post post);
        List<Post> GetPosts();
        List<Comment> GetPostComments(int postId);
    }
}
