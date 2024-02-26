using System.ComponentModel.DataAnnotations;

namespace OPC5_BlogApp.Data.Models
{
    public class Post
    {
        [Key]
        [Required]
        public int PostId { get; set; }

        public string PostData { get; set; }
        public int PostUpvotes { get; set; }
        public int PostDownvotes { get; set; }
        public List<Tag> PostTags { get; set; }
        public Comment[]? PostComments { get; set; }
    }
}
