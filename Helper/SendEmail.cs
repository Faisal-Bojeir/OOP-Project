using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EmailSender : IEmailSender
    {
        public static void NotifyEmployee(string message)
        {
            System.Console.WriteLine(message);
        }

    }
}