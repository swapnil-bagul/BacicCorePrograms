using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class EvenOdd
    {
        public static void Find()
        {
            //taking input from user
            Console.Write("Enter the Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
           
            //find reminder
            int res = num % 2;
            
            //if else progrmming construct
            if (res == 0)
            {
                Console.WriteLine("{0} is Even Number", num);
            }
            else 
            {
                Console.WriteLine("{0} is Odd Number", num);
            }
        }
    }
}
