using System;
using System.Collections.Generic;
using System.Text;

namespace DIDataAccessLayer
{
    public class Texter : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending a text message this time! Message : { message }");
        }
    }
}
