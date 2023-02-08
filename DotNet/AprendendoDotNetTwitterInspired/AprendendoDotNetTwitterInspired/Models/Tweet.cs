using System.ComponentModel.DataAnnotations;

namespace AprendendoDotNetTwitterInspired.Models
{
    public class Tweet
    {
        [Key]
        public int id { get; set; }
        public int authorId { get; set; }
        public DateTime dateCreation { get; set; }
        public DateTime dateEdited { get; set; }
        [MaxLength(500)]
        public string text { get; set; } = "";
        public int likes { get; set; }

    }
}
