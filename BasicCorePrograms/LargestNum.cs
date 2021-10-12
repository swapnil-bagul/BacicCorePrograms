using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class LargestNum
    {
        static public void FindLargestNum() 
        {
            //taking user input
            Console.WriteLine("Enter a three Number");
            int fristNum= Convert.ToInt32(Console.ReadLine());
            int secondNum = Convert.ToInt32(Console.ReadLine());
            int thirdNum = Convert.ToInt32(Console.ReadLine());

            //if else if programming construct
            if(fristNum >secondNum  && fristNum>thirdNum  )
            {
                Console.WriteLine("{0} is Largest Number", fristNum);
            }
            else if (secondNum >fristNum &&secondNum >thirdNum )
            {
                Console.WriteLine("{0} is Largest Number", secondNum);
            }
            else
            {
                Console.WriteLine("{0} is Largest Number", thirdNum);
            }
        }
        

    }
}
