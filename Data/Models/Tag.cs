using System.ComponentModel.DataAnnotations;

namespace OPC5_BlogApp.Data.Models
{
    public class Tag
    {
        [Key]
        [Required]
        public int TagId { get; set; }

        public string TagName { get; set; }
    }
}
