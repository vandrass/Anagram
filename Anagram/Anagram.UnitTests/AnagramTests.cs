// -----------------------------------------------------------------------
// <copyright file="AnagramTests.cs" company="Ivan Goncharov">
// Copyright (c) Ivan Goncharov. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Anagram.UnitTests
{
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// UnitTests for reversion Testing of angram class.
    /// </summary>
    [TestClass]
    public class AnagramTests
    {
        private readonly ServiceCollection serviceCollection = new ServiceCollection();
        private ServiceProvider provider;
        private IAnagram service;

        /// <summary>
        /// Method build service by Angram and IAnagram, for calling from tests.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            this.serviceCollection.AddScoped<IAnagram, Anagram>();
            this.provider = this.serviceCollection.BuildServiceProvider();
            this.service = this.provider.GetRequiredService<IAnagram>();
        }

        /// <summary>
        /// Test one word string on reversion.
        /// </summary>
        [TestMethod]
        public void Reverse_InputOneWord_OneReversedWord()
        {
            // Arrange
            const string input = "Hello";
            const string expected = "olleH";

            // Act
            var actual = this.service.Reverse(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test empty string input, should be returned empty string.
        /// </summary>
        [TestMethod]
        public void Reverse_EmptyString_EmptyString()
        {
            // Arrange
            const string input = "";
            const string expected = "";

            // Act
            var actual = this.service.Reverse(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test on null input, should be returned empty string.
        /// </summary>
        [TestMethod]
        public void Reverse_InputNull_EmptyString()
        {
            // Arrange
            const string input = null;
            const string expected = "";

            // Act
            var actual = this.service.Reverse(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test string with spaces at both ends, spaces should be stay put.
        /// </summary>
        [TestMethod]
        public void Reverse_InputWordWithSpaces_ReversedWordWithUnreversedSpaces()
        {
            // Arrange
            const string input = " HELLO ";
            const string expected = " OLLEH ";

            // Act
            var actual = this.service.Reverse(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test string with double spaces at both ends, spaces should be stay put.
        /// </summary>
        [TestMethod]
        public void Reverse_InputWordWithDoubleSpaces_ReversedWordWithUnreversedDoubleSpaces()
        {
            // Arrange
            const string input = "  Hello  ";
            const string expected = "  olleH  ";

            // Act
            var actual = this.service.Reverse(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test spaces string only, return without changes.
        /// </summary>
        [TestMethod]
        public void Reverse_InputStringWithSpacesOnly_SameString()
        {
            // Arrange
            const string input = "   ";
            const string expected = "   ";

            // Act
            var actual = this.service.Reverse(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test two words string input, return string of two reversed words.
        /// </summary>
        [TestMethod]
        public void Reverse_InputStringWithTwoWords_TwoReversedWords()
        {
            // Arrange
            const string input = "HELLO world";
            const string expected = "OLLEH dlrow";

            // Act
            var actual = this.service.Reverse(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test three words string input, return string of three reversed words.
        /// </summary>
        [TestMethod]
        public void Reverse_InputStringWithThreeWords_ThreeReversedWords()
        {
            // Arrange
            const string input = "HELLO My world";
            const string expected = "OLLEH yM dlrow";

            // Act
            var actual = this.service.Reverse(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test word with non-letter char on the end, non-letter char stay put and letters should be reversed.
        /// </summary>
        [TestMethod]
        public void Reverse_InputOneWordWithSymbolInTheEnd_ReversedWordUnreversedSymbol()
        {
            // Arrange
            const string input = "HELLO!";
            const string expected = "OLLEH!";

            // Act
            var actual = this.service.Reverse(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test word with non-letter char at the beggining and on the end, non-letter chars stay put and letters should be reversed.
        /// </summary>
        [TestMethod]
        public void Reverse_InputWordWithTwoSymbols_ReversedWordWithUnreversedSymbols()
        {
            // Arrange
            const string input = "1HELLO!";
            const string expected = "1OLLEH!";

            // Act
            var actual = this.service.Reverse(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test non-letter string only, should be without changes.
        /// </summary>
        [TestMethod]
        public void Reverse_InputSymbolsStringOnly_UnaffectedString()
        {
            // Arrange
            const string input = "12!*-+=";
            const string expected = "12!*-+=";

            // Act
            var actual = this.service.Reverse(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test string with non-letter chars on th ends of word and in the middle,
        /// should be retirned string with reversed letters and non-letter chars stay put.
        /// </summary>
        [TestMethod]
        public void Reverse_InputWordWithSymbolsAtTheEndsAndInTheMiddle_ReversedWordsAndUnreversedSymbols()
        {
            // Arrange
            const string input = "1He2llo3";
            const string expected = "1ol2leH3";

            // Act
            var actual = this.service.Reverse(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test string of three words with non-letters chars on different places,
        /// all non-letter chars stay put and letters chars should be revesed.
        /// </summary>
        [TestMethod]
        public void Reverse_InputThreeWordWithSimbolsOnDifferntPlaces_ReversedWordsAndUnreversedSymbols()
        {
            // Arrange
            const string input = "1He2llo M*y4 /wor123ld";
            const string expected = "1ol2leH y*M4 /dlr123ow";

            // Act
            var actual = this.service.Reverse(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
