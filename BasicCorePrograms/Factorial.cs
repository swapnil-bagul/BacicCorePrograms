using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Factorial
    {
        public static void Factorization()
        {
            Console.Write("Enter the Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int fact = 1;

            //for loop programming construct
            for (int i=1; i<=number; i++)
            {
               fact = fact * i; 
            }
            Console.WriteLine("{0}! = {1}", number, fact);
        }
    }
}
