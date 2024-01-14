using System;
using NUnit.Framework;
using TestApp.Chat;

namespace TestApp.Tests
{
    [TestFixture]
    public class ChatRoomTests
    {
        private ChatRoom _chatRoom = null!;

        [SetUp]
        public void Setup()
        {
            this._chatRoom = new ChatRoom();
        }

        [Test]
        public void Test_SendMessage_MessageSentToChatRoom()
        {
            // Arrange
            string sender = "Alice";
            string message = "Hello, everyone!";

            // Act
            _chatRoom.SendMessage(sender, message);

            // Assert
            Assert.That(_chatRoom.DisplayChat(), Does.Contain($"{sender}: {message} - Sent at {DateTime.Now.Date.ToString("d")}"));
        }

        [Test]
        public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
        {
            // Act
            string result = _chatRoom.DisplayChat();

            // Assert
            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
        {
            // Arrange
            string sender = "Bob";
            string message1 = "Hi, there!";
            string message2 = "How are you?";

            _chatRoom.SendMessage(sender, message1);
            _chatRoom.SendMessage(sender, message2);

            // Act
            string result = _chatRoom.DisplayChat();

            // Assert
            Assert.That(result, Does.Contain($"{sender}: {message1} - Sent at {DateTime.Now.Date.ToString("d")}"));
            Assert.That(result, Does.Contain($"{sender}: {message2} - Sent at {DateTime.Now.Date.ToString("d")}"));
        }
    }
}
