using OPC5_BlogApp.Data.Models;

namespace Services.Posts
{
    public interface IPostService
    {
        void AddPost(Post post);
        Post? AddPostUpvote(int postId);
        Post? AddPostDownvote(int postId);
        Task<List<Post>> GetPosts(int count);
        Task<List<Post>> GetPostsWithData(string searchData);
        Task<int> GetTotalPostCount();
        List<Comment> GetPostComments(int postId);
        Post? RemovePostUpvote(int postId);
        Post? RemovePostDownvote(int postId);
    }
}
