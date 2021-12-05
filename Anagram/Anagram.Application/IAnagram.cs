// <copyright file="IAnagram.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Anagram
{
    /// <summary>
    /// String Reversion Interface.
    /// </summary>
    public interface IAnagram
    {
        /// <summary>
        /// Reverse string.
        /// </summary>
        /// <param name="stringToReverse">string for reversion.</param>
        /// <returns>reversed string.</returns>
        string Reverse(string stringToReverse);
    }
}
