using OPC5_BlogApp.Data;
using OPC5_BlogApp.Data.Models;

namespace Services.Posts
{
    public class CommentService(ApplicationDbContext _context) : ICommentService
    {
        private readonly ApplicationDbContext context = _context;

        public void AddComment(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
        }
    }
}
