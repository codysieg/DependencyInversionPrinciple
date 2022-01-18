using DIDataAccessLayer;
using DIDataAccessLayer.Models;
using System;

namespace DIConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IMessageSender messageSender = new Texter();
            ILogger logger = new Logger();

            IDataAccessLayer DAL = new DataAccessLayer(messageSender, logger);

            IPerson person = new Person
            {
                FirstName = "Cody",
                LastName = "Siegmann"
            };

            IChore chore = new Chore
            {
                Task = "Took out the trash.",
                TimeWorked = "14 hours"
            };

            DAL.StartChore(chore);
            DAL.CompleteChore(chore);

            logger.LogMessage("Finished chore. Exiting program.");
            Console.ReadLine();
        }
    }
}
