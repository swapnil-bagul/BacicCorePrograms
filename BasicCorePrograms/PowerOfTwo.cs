using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PowerOfTwo
    {
        public static void Power()
        {
          
            Console.Write("Enter the value which is power of 2 : ");
            //local variable
            int N = Convert.ToInt32(Console.ReadLine());
            //constant variable
            int num = 2;
            //for loop programming construct
            for (int power=1; power<=N; power++)
            {
               double res= Math .Pow (num ,power );
               Console.WriteLine("2^{0} = {1}", power, res); 
            }
        }
    }
}
