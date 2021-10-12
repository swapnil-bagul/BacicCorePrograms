using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Alphabets
    {
        public static void GetInput()
        {
            
            Console.Write("Enter Alphabet: ");
            char ch = Convert .ToChar (Console .ReadLine());
            int i = ch;
            if(i>48 && i<60)
            {
                Console.WriteLine("you enter a number, please enter a alphabet");
            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("Its Vowel");
                        break;

                    case 'e':
                        Console.WriteLine("Its Vowel");
                        break;

                    case 'i':
                        Console.WriteLine("Its Vowel");
                        break;

                    case 'o':
                        Console.WriteLine("Its Vowel");
                        break;

                    case 'u':
                        Console.WriteLine("Its Vowel");
                        break;

                    default:
                        Console.WriteLine("Its Consonant");
                        break;

                }

            }

        }
    }
}
