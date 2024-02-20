using System.ComponentModel.DataAnnotations;

namespace OPC5_BlogApp.Data.Models
{
    public class Comment
    {
        [Key]
        [Required]
        public int CommentId { get; set; }

        [Required]
        public User CommentUser { get; set; }
        public string CommentText { get; set; }
    }
}
