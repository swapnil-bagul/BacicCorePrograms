using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class FlipCoin
    {
        //constant variable
        public const int HEADS = 0;
        public const int TAILS = 1;
        public  void Fliping() 
        {
            Console.Write("Enter the value, For how many time flip the Coin: ");
            int count = Convert.ToInt32 (Console .ReadLine ());
            //local variable
            int headsCount = 0;
            int tailsCount = 0;

            //for loop programming construct 
            for (int i = 1; i <=count ; i++)
            {
                //used random predefined class
                Random check = new Random();
                int result = check.Next(0, 2);

                // if else programming construct
                if(result == HEADS)
                {
                    Console.WriteLine("Head");
                    headsCount++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    tailsCount++;
                }
              
            }
            //formula for finding percentage
            int headsPercentage = headsCount * 100 / count;
            int tailsPercentage = tailsCount * 100 / count;
            // display the output
            Console.WriteLine("Heads Percentage is: " +headsPercentage );
            Console.WriteLine("Tails Percentage is: " +tailsPercentage );

        }
   
    }
}
            
            

