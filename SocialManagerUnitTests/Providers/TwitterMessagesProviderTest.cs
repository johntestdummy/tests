using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using SocialManagerLibrary.Entities;
using SocialManagerLibrary.Providers;

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
            var list = new List<Message>() {
                new Message()
                {
                    Text = "Test message!"
                }
            };
            _connHandler.Setup(x => x.Search(It.IsAny<Query>())).Returns(list);

            var response = Sut.GetLast(new Query { Count = 10, Term = "test" });

            Assert.AreEqual(response, list);
        }
    }
}
