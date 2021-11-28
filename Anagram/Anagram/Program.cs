using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Anagram anagram = new Anagram();
            string myString = null;
            


            myString = Console.ReadLine();

            Console.WriteLine(anagram.Revers(myString));

            Console.ReadKey();
        }


        

    }
}
