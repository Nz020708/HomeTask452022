using System;

namespace HomeTask4522
{
    class Program
    {
        static void Main(string[] args)
        {
            char l = 'p';
            ExtensionMethods.CustomContains('p', "apple");
            string w = "Apple";
            ExtensionMethods.CustomContains("na", "apple");
            ExtensionMethods.IsPrime(19);
        }
    }
}
