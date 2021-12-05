// <copyright file="Anagram.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Anagram
{
    public class Anagram : IAnagram
    {
        public string Reverse(string stringToReverse)
        {
            if (stringToReverse == null)
            {
                return string.Empty;
            }

            string[] wordsToReverse = stringToReverse.Split();

            for (int i = 0; i < wordsToReverse.Length; i++)
            {
                wordsToReverse[i] = this.ReverseWord(wordsToReverse[i]);
            }

            return string.Join(" ", wordsToReverse);
        }

        private string ReverseWord(string wordToReverse)
        {
            int lastIndex = wordToReverse.Length - 1;
            char[] charsArray = new char[wordToReverse.Length];

            for (int i = 0; i < wordToReverse.Length; i++)
            {
                if (!char.IsLetter(wordToReverse[i]))
                {
                    charsArray[i] = wordToReverse[i];
                    lastIndex++;
                }
                else if (!char.IsLetter(wordToReverse[lastIndex - i]))
                {
                    charsArray[lastIndex - i] = wordToReverse[lastIndex - i];
                    lastIndex--;
                    i--;
                }
                else
                {
                    charsArray[i] = wordToReverse[lastIndex - i];
                }
            }

            return new string(charsArray);
        }
    }
}
