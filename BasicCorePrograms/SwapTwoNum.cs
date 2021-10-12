using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class SwapTwoNum
    {
        //static variable
        static int firstNum;
        static int secondNum;
        static  int thirdNum;

        //static method for taking input
         static void input()
        {
            Console.WriteLine("Enter a Two Number");
            Console.Write("First Number: ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second Number: ");
            secondNum = Convert.ToInt32(Console.ReadLine());
            
        }
     
        //static method for swapping number
          public static void Swap()
        {
            SwapTwoNum.input();
            //swaping number by using third number
            thirdNum = firstNum + secondNum;
            firstNum = thirdNum - firstNum;
            secondNum = thirdNum - firstNum;

            //displaying result
            Console.WriteLine("First Number= " + firstNum);
            Console.WriteLine("Second Number= " + secondNum);
        }
       
    }
}
