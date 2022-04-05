using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask4522
{
    public static class ExtensionMethods
    {
        
       
        public static bool CustomContains(this string word,string Word)
        {
            bool result ;
            if (Word.Contains(word))
            {
                Console.WriteLine("Daxildir.");
                result = true;
                Console.WriteLine(result);
            }

            else
            {
                Console.WriteLine("Daxil deyil");
                result = false;
                Console.WriteLine(result);
            }
            return result;
        }
        public static bool CustomContains( this char letter, string Word)
        {
            bool result;

            if (Word.Contains(letter))
            {
                Console.WriteLine("Daxildir.");
                result = true;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Daxil deyil.");
                result = false;
                Console.WriteLine(result);
            }
            return result;
        }

        public static void IsPrime(this int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"{number} murekkeb ededdir");
                    break;


                }
                else
                {
                    if (i == number - 1)
                    {
                        Console.WriteLine($"{number} sade ededdir");

                    }
                }


            }
        }
    }
}
