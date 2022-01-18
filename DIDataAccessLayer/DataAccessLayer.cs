using DIDataAccessLayer.Models;
using System;

namespace DIDataAccessLayer
{
    public class DataAccessLayer : IDataAccessLayer
    {
        private IMessageSender _messageSender;
        private ILogger _logger;

        public DataAccessLayer(IMessageSender messageSender, ILogger logger)
        {
            _messageSender = messageSender;
            _logger = logger;
        }

        public void StartChore(IChore chore)
        {
            Console.WriteLine($"Starting chore! Task: { chore.Task } & Time Worked: { chore.TimeWorked }");

            _logger.LogMessage("Starting Chore!");
        }

        public void CompleteChore(IChore chore)
        {
            Console.WriteLine($"Completing chore! Task: { chore.Task } & Time Worked: { chore.TimeWorked }");

            _logger.LogMessage("Completing chore!");
            _messageSender.SendMessage("Completed chore!");
        }
    }
}
