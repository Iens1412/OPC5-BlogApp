using OPC5_BlogApp.Data.Models;

namespace Services.Posts
{
    public interface ICommentService
    {
        void AddComment(Comment comment);

        List<Comment> GetComments();
    }
}
