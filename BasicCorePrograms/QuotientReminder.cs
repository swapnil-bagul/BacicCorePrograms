using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class QuotientReminder
    {
        public static void Compute()
        {
            //taking input from user
            Console.WriteLine("Enter two Number");
            double  firstNum = Convert.ToDouble (Console.ReadLine());
            double  secondNum = Convert.ToDouble (Console.ReadLine());
            //forumula for Quotient & Reminder
            double quotient = firstNum / secondNum;
            double reminder = firstNum % secondNum;
            // display output of application
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Reminder: " + reminder);
        }
    }
}
