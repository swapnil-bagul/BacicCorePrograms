using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class HarmonicNum
    {
        public static void Series()
        {
            // taking userinput
            Console.Write("Input number of terms : ");
            double n = Convert.ToDouble(Console.ReadLine());
            double sum=0;

            //for loop programming construct
            for (double i=1; i<=n; i++)
            {
                sum = sum + (1 / i);
                Console.Write("1/{0} + ",i);
            }

            //display the output of application
            Console.WriteLine("\nSum Of Series ={0}", sum);
        }
    }
}
