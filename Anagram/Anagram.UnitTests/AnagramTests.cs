using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Anagram.UnitTests
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void Reverse_InputOneWord_OneReversedWord()
        {
            //Arrange
            const string input = "Hello";
            const string expected = "olleH";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Reverse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_EmptyString_EmptyString()
        {
            //Arrange
            const string input = "";
            const string expected = "";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Reverse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputNull_EmptyString()
        {
            //Arrange
            const string input = null;
            const string expected = "";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Reverse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputWordWithSpaces_ReversedWordWithUnreversedSpaces()
        {
            //Arrange
            const string input = " HELLO ";
            const string expected = " OLLEH ";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Reverse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputWordWithDoubleSpaces_ReversedWordWithUnreversedDoubleSpaces()
        {
            //Arrange
            const string input = "  Hello  ";
            const string expected = "  olleH  ";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Reverse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputStringWithSpacesOnly_SameString()
        {
            //Arrange
            const string input = "   ";
            const string expected = "   ";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Reverse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputStringWithTwoWords_TwoReversedWords()
        {
            //Arrange
            const string input = "HELLO world";
            const string expected = "OLLEH dlrow";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Reverse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputStringWithThreeWords_ThreeReversedWords()
        {
            //Arrange
            const string input = "HELLO My world";
            const string expected = "OLLEH yM dlrow";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Reverse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputOneWordWithSymbolInTheEnd_ReversedWordUnreversedSymbol()
        {
            //Arrange
            const string input = "HELLO!";
            const string expected = "OLLEH!";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Reverse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputWordWithTwoSymbols_ReversedWordWithUnreversedSymbols()
        {
            //Arrange
            const string input = "1HELLO!";
            const string expected = "1OLLEH!";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Reverse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputSymbolsStringOnly_UnaffectedString()
        {
            //Arrange
            const string input = "12!*-+=";
            const string expected = "12!*-+=";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Reverse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputWordWithSymbolsAtTheEndsAndInTheMiddle_ReversedWordsAndUnreversedSymbols()
        {
            //Arrange
            const string input = "1He2llo3";
            const string expected = "1ol2leH3";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Reverse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputThreeWordWithSimbolsOnDifferntPlaces_ReversedWordsAndUnreversedSymbols()
        {
            //Arrange
            const string input =    "1He2llo M*y4 /wor123ld";
            const string expected = "1ol2leH y*M4 /dlr123ow";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Reverse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
