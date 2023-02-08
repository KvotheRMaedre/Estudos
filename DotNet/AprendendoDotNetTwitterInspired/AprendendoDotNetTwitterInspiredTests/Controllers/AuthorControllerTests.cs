using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AprendendoDotNetTwitterInspired.Controllers.Tests
{
    [TestClass()]
    public class AuthorControllerTests
    {
        [TestMethod()]
        public void GetLastTweetTest_Returns_BadRequest_When_AuthorId_Is_Invalid_1()
        {
            var controller = new AuthorController();

            var actionResult = controller.GetLastTweet(0);

            var result = actionResult.Result as BadRequestObjectResult;

            Assert.AreEqual(result.StatusCode, 400);
        }

        [TestMethod()]
        public void GetAllTweetsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PostTweetTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PutTweetTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTweetTest()
        {
            Assert.Fail();
        }
    }
}