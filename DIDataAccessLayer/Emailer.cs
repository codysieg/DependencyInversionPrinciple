using System;
using System.Collections.Generic;
using System.Text;

namespace DIDataAccessLayer
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending Email! { message }");
        }
    }
}
