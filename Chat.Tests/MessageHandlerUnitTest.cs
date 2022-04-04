﻿using Chat.Server.Handlers;
using Chat.Server.SocketsManager;
using Moq;
using NUnit.Framework;
using System;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace Chat.Tests
{
    public class MessageHandlerUnitTest
    {
        private Mock<WebSocket>? _socket = null;

        [SetUp]
        public void Setup()
        {
            _socket = new Mock<WebSocket>();
        }

        [Test]
        public async Task OnConnected_Message_Recieved()
        {
            ConnectionManager con = new ConnectionManager();
            MessageHandler mh = new MessageHandler(con);

            await mh.OnConnected(_socket.Object);
            Assert.Positive(_socket.Invocations.Count);
        }

        [Test]
        public async Task SendMessage_Contents_Identical_On_Both_Ends()
        {
            ConnectionManager con = new ConnectionManager();
            MessageHandler mh = new MessageHandler(con);

            string message = "This test is being done RIGHT NOW.";

        }
    }
}
