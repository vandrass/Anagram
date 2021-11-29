using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Anagram.UnitTests
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void Reverse_Hello_olleH()
        {
            //Arrange
            string wordToReverse = "Hello";
            string expected = "olleH";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(wordToReverse);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_emptyString_emptyString()
        {
            //Arrange
            string wordToReverse = "";
            string expected = "";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(wordToReverse);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_HELLO_OLLEH()
        {
            //Arrange
            string wordToReverse = "HELLO";
            string expected = "OLLEH";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(wordToReverse);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_spaceHEllo_spaceolleH()
        {
            //Arrange
            string wordToReverse = " Hello";
            string expected = " olleH";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(wordToReverse);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_spaceHEllospace_spaceolleHspace()
        {
            //Arrange
            string wordToReverse = " Hello ";
            string expected = " olleH ";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(wordToReverse);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_spaceSpaceSpace_spaceSpaceSpace()
        {
            //Arrange
            string wordToReverse = "   ";
            string expected = "   ";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(wordToReverse);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
