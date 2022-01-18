using System;
using System.Collections.Generic;
using System.Text;

namespace DIDataAccessLayer
{
    public class Logger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Logging Message { message }");
        }
    }
}
