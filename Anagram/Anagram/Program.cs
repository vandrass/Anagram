using System;

namespace Anagram
{
    public class Program
    {
        static void Main()
        {
            Anagram anagram = new Anagram();
            string myString = Console.ReadLine();

            Console.WriteLine(anagram.Revers(myString));

            Console.ReadKey();
        }
    }
}
