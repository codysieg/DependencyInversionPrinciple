using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class Logger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Logging Message { message }");
        }
    }
}
