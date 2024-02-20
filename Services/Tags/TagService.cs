using OPC5_BlogApp.Data;
using OPC5_BlogApp.Data.Models;

namespace Services.Tags
{
    public class TagService(ApplicationDbContext _context) : ITagService
    {
        private readonly ApplicationDbContext context = _context;

        public List<Tag> GetTags()
        {
            List<Tag> allTags = context.Tags.ToList();

            return allTags;
        }
    }
}
