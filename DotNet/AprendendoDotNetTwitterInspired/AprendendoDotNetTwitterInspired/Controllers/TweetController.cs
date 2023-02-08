using AprendendoDotNetTwitterInspired.Data;
using AprendendoDotNetTwitterInspired.Models;
using Microsoft.AspNetCore.Mvc;

namespace AprendendoDotNetTwitterInspired.Controllers
{
    [Route("api/v1/tweet")]
    [ApiController]
    public class TweetController : ControllerBase
    {
        [HttpGet]
        public List<Tweet> GetTweetByAuthor(int authorId)
        {
            return TweetStore.tweets.FindAll(tweet => tweet.authorId == authorId);
        }
    }
}
