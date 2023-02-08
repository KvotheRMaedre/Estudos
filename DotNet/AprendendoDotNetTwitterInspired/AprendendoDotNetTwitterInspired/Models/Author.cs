using AprendendoDotNetTwitterInspired.Data;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.ComponentModel.DataAnnotations;

namespace AprendendoDotNetTwitterInspired.Models
{
    public class Author
    {
        [Key]
        public int id { get; set; }
        [MaxLength(200)]
        public string name { get; set; } = "";

        public static Boolean authorExists(int authorId)
        {
            try
            {
                Author? author = AuthorStore.authors.FirstOrDefault(author => author.id == authorId);
                return author != null ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
