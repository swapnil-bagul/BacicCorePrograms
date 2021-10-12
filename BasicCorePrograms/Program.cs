using System;
using BasicCorePrograms;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the NO to go to that Application");
            Console.WriteLine("1. Flip coin\n2. Leap Year\n3. Power of 2\n4. Even Odd Number\n5. Find Largest Number\n6. Swap Two Number\n7. Factors\n8. Alphabets\n9. Compute Quotient and Reminder\n10. Harmonic Number ");
            Console.WriteLine("---------------------------------------------------");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------");

            switch (userInput) 
            {
                case 1:
                    FlipCoin coin = new FlipCoin();
                    coin.Fliping();
                    break;

                case 2:
                    LeapYear leap = new LeapYear();
                    leap.Check();
                    break;

                case 3:
                    PowerOfTwo.Power();
                    break;

                case 4:
                    EvenOdd .Find();
                    break;

                case 5:
                    LargestNum.FindLargestNum();
                    break;

                case 6:
                    SwapTwoNum.Swap();
                    break;

                case 7:
                    Factorial.Factorization();
                    break;

                case 8:
                    Alphabets.GetInput();
                    break;

                case 9:
                    QuotientReminder.Compute();
                    break;

                case 10:
                    HarmonicNum.Series();
                    break;

            }
            
        }
    }
}
