using AprendendoDotNetTwitterInspired.Models;

namespace AprendendoDotNetTwitterInspired.Data
{
    public class AuthorStore
    {
        public static List<Author> authors = new List<Author> {
            new Author{id = 1, name = "Ítalo H"},
            new Author{id = 2, name = "Fernanda C."},
            new Author{id = 3, name = "Viola D."},
        };
    }
}