using DataAccessLayer;
using DataAccessLayer.Models;
using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Emailer emailSender = new Emailer();
            Logger logger = new Logger();

            Person person = new Person
            {
                FirstName = "Cody",
                LastName = "Siegmann"
            };

            Chore chore = new Chore
            {
                Task = "Took out the trash.",
                TimeWorked = "14 hours"
            };

            DataAccessLayer.DataAccessLayer.StartChore(chore);
            DataAccessLayer.DataAccessLayer.CompleteChore(chore);

            logger.LogMessage("Finished chore. Exiting program.");
            Console.ReadLine();
        }
    }
}
