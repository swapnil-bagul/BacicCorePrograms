using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class HarmonicNum
    {
        public static void Series()
        {
            Console.Write("Input number of terms : ");
            double n = Convert.ToDouble(Console.ReadLine());
            double sum=0;
            for (double i=1; i<=n; i++)
            {
                sum = sum + (1 / i);
                Console.Write("1/{0} + ",i);
            }
            Console.WriteLine("\nSum Of Series ={0}", sum);
        }
    }
}
