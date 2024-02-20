using System.ComponentModel.DataAnnotations;

namespace OPC5_BlogApp.Data.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        public string PostData { get; set; }
        public string[] PostTags { get; set; }
    }
}
