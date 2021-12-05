// -----------------------------------------------------------------------
// <copyright file="IAnagram.cs" company="Ivan Goncharov">
// Copyright (c) Ivan Goncharov. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

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
