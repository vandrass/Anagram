// <copyright file="Anagram.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Anagram
{
    /// <summary>
    /// Class for input strings reversion.
    /// </summary>
    public class Anagram : IAnagram
    {
        /// <summary>
        /// Method To reverse string letterse, non-letter characters stay put.
        /// </summary>
        /// <param name="stringToReverse">input string for reversion.</param>
        /// <returns>reversed string.</returns>
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
