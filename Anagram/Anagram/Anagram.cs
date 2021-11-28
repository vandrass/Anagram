using System;
using System.Text;

namespace Anagram
{
    public class Anagram
    {


        public string Revers(string str)
        {
            string[] wordsToReverse = str.Split();

            for (int i = 0; i < wordsToReverse.Length; i++)
            {
                wordsToReverse[i] = ReverseWord(wordsToReverse[i]);
            }

            return string.Join(" ", wordsToReverse);
        }


        private string ReverseWord(string word)
        {
            int lastIndex = word.Length - 1;
            char[] charsArray = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                charsArray[i] = word[lastIndex - i];
            }

            return new string(charsArray);
        }
    }
    
}
