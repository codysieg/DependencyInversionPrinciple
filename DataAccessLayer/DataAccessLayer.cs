using DataAccessLayer.Models;
using System;

namespace DataAccessLayer
{
    public class DataAccessLayer
    {
        public static void StartChore(Chore chore)
        {
            Logger logger = new Logger();

            Console.WriteLine("Starting chore!");

            logger.LogMessage("Starting Chore!");
        }

        public static void CompleteChore(Chore chore)
        {
            Logger logger = new Logger();
            Emailer emailer = new Emailer();

            Console.WriteLine("Completing chore");

            logger.LogMessage("Completing chore!");
            emailer.SendEmail("Sending Email, completed chore!");
        }
    }
}
