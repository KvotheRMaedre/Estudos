using AprendendoDotNetTwitterInspired.Data;
using AprendendoDotNetTwitterInspired.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AprendendoDotNetTwitterInspired.Controllers
{
    [Route("/api/v1/author")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        [HttpGet]
        [Route("getLastTweet")]
        public async Task<IActionResult> GetLastTweet(int authorId)
        {
            try
            {
                if (authorId == 0)
                    return BadRequest("Please inform a valid id.");

                if (Author.authorExists(authorId))
                {
                    Tweet? lastTweet = TweetStore.tweets.LastOrDefault(tweet => tweet.authorId == authorId);
                    return lastTweet != null ? Ok(lastTweet) : NotFound("This user hasn't posted yet.");
                }
                else
                    return NotFound("User dont exists.");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("getAllTweets")]
        public List<Tweet> GetAllTweets(int authorId)
        {
            return TweetStore.tweets.FindAll(tweet => tweet.authorId == authorId);
        }

        [HttpPost]
        [Route("postTweet")]
        public IActionResult PostTweet(int authorId, string text)
        {
            Tweet? tweet = new Tweet { authorId = authorId, dateCreation = DateTime.Now, dateEdited = DateTime.Now, id = 5, likes = 0, text = text };
            TweetStore.tweets.Add(tweet);
            return Ok(tweet);
        }

        [HttpPut]
        [Route("putTweet")]
        public IActionResult PutTweet(int authorId, int tweetId, string text)
        {
            Tweet? tweet = TweetStore.tweets.Find(tweet => tweet.id == tweetId);
            TweetStore.tweets.Remove(tweet);
            tweet.text = text;
            tweet.dateEdited = DateTime.Now;
            TweetStore.tweets.Add(tweet);
            return Ok(tweet);
        }

        [HttpDelete]
        [Route("deleteTweet")]
        public IActionResult DeleteTweet(int authorId, int tweetId)
        {
            Tweet? tweet = TweetStore.tweets.Find(tweet => tweet.id == tweetId);
            TweetStore.tweets.Remove(tweet);
            return Ok();
        }
    }
}
