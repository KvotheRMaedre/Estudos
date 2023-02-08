using AprendendoDotNetTwitterInspired.Models;

namespace AprendendoDotNetTwitterInspired.Data
{
    public class TweetStore
    {
        public static List<Tweet> tweets = new List<Tweet> { 
            new Tweet{id = 1, authorId = 1, dateCreation = DateTime.Now, dateEdited = DateTime.Today, text = "I'm just learning .net restful apis", likes = 0},
            new Tweet{id = 2, authorId = 1, dateCreation = DateTime.Now, dateEdited = DateTime.Today, text = "Favorite LGBT Comics: Heart Stoppers", likes = 0},
            new Tweet{id = 2, authorId = 2, dateCreation = DateTime.Now, dateEdited = DateTime.Today, text = "Hello there cuties", likes = 0}
        };
    }
}
