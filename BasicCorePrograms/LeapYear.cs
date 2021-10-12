using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class LeapYear
    {
        public void Check()
        {
            Console.Write("Enter the Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            //local variable
            int a = year % 400;
            int b = year % 4;
            int c = year % 100;

            //if else programming construct
            if (a==0 || (b==0 && c!=0))
            {
                Console.WriteLine("{0} Year is Leap",year);
            }
            else
            {
                Console.WriteLine("{0} is Not Leap Year", year);
            }

        }
      
    }
    
}
