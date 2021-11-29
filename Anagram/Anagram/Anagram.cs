

namespace Anagram
{
    public class Anagram
    {

        public string Revers(string stringToRevers)
        {
            string[] wordsToReverse = stringToRevers.Split();

            for (int i = 0; i < wordsToReverse.Length; i++)
            {
                wordsToReverse[i] = ReverseWord(wordsToReverse[i]);
            }

            return string.Join(" ", wordsToReverse);
        }

        private string ReverseWord(string wordToReverse)
        {
            int lastIndex = wordToReverse.Length - 1;
            char[] charsArray = new char[wordToReverse.Length];

            for (int i = 0; i < wordToReverse.Length; i++)
            {
                charsArray[i] = wordToReverse[lastIndex - i];
            }

            return new string(charsArray);
        }
    }
    
}
