using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class Emailer
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Sending Email! { message }");
        }
    }
}
