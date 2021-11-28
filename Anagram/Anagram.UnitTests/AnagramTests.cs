using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Anagram.UnitTests
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void Reverse_DifferentLengthStrings_ReversedString()
        {
            //Arrange
            var anagram = new Anagram();

            //Act

            var result = anagram.Revers("");

            //Assert
            
        }
    }
}
