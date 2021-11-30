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
            string input = "Hello";
            string expected = "olleH";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_EmptyString_EmptyString()
        {
            //Arrange
            string input = "";
            string expected = "";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputNull_EmptyString()
        {
            //Arrange
            string input = null;
            string expected = "";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputWordWithSpaces_ReversedWordWithUnreversedSpaces()
        {
            //Arrange
            string input = " HELLO ";
            string expected = " OLLEH ";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputWordWithDoubleSpaces_ReversedWordWithUnreversedDoubleSpaces()
        {
            //Arrange
            string input = "  Hello  ";
            string expected = "  olleH  ";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputStringWithSpacesOnly_SameString()
        {
            //Arrange
            string input = "   ";
            string expected = "   ";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputStringWithTwoWords_TwoReversedWords()
        {
            //Arrange
            string input = "HELLO world";
            string expected = "OLLEH dlrow";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputStringWithThreeWords_ThreeReversedWords()
        {
            //Arrange
            string input = "HELLO My world";
            string expected = "OLLEH yM dlrow";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputOneWordWithSymbolInTheEnd_ReversedWordUnreversedSymbol()
        {
            //Arrange
            string input = "HELLO!";
            string expected = "OLLEH!";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputWordWithTwoSymbols_ReversedWordWithUnreversedSymbols()
        {
            //Arrange
            string input = "1HELLO!";
            string expected = "1OLLEH!";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputSymbolsStringOnly_UnaffectedString()
        {
            //Arrange
            string input = "12!*-+=";
            string expected = "12!*-+=";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputWordWithSymbolsAtTheEndsAndInTheMiddle_ReversedWordsAndUnreversedSymbols()
        {
            //Arrange
            string input = "1He2llo3";
            string expected = "1ol2leH3";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_InputThreeWordWithSimbolsOnDifferntPlaces_ReversedWordsAndUnreversedSymbols()
        {
            //Arrange
            string input =    "1He2llo M*y4 /wor123ld";
            string expected = "1ol2leH y*M4 /dlr123ow";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
