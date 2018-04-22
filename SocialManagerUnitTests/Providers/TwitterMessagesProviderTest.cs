using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using SocialManagerLibrary.Entities;
using SocialManagerLibrary.Providers;
using SocialManagerUnitTests.Helper;

namespace SocialManagerUnitTests
{
    [TestFixture]
    public class TwitterMessagesProviderTest
    {
        private Mock<IApiConnectionHandler> _connHandler;

        public TwitterMessagesProvider Sut { get; set; }

        [TestFixtureSetUp]
        public void Setup()
        {
            _connHandler = new Mock<IApiConnectionHandler>();

            Sut = new TwitterMessagesProvider(_connHandler.Object);
        }

        [Test]
        public void TestSearch()
        {
            _connHandler.Setup(x => x.Search(It.IsAny<Query>())).Returns(TestHelpers.GetTweets());

            var response = Sut.GetLast(new Query { Count = 10, Term = "test" });

            Assert.AreEqual(response.Count, 1);
        }

    }
}
