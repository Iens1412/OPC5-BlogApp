using System.ComponentModel.DataAnnotations;

namespace OPC5_BlogApp.Data.Models
{
    public class User
    
    {
        [Key]
        [Required]
        public int UserId { get; set; }

        public string Username { get; set; }
        public string Hashed { get; set; }
        public string Email { get; set; }
        public Post[]? Posts { get; set; }
    }
}
