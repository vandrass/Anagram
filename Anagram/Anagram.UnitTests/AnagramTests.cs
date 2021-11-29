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

        [TestMethod]
        public void Reverse_symHELLOsym_symOLLEHsym()
        {
            //Arrange
            string wordToReverse = "1HELLO!";
            string expected = "1OLLEH!";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(wordToReverse);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_spaceSymHELLOsymSpace_spaceSymHELLOsymSpace()
        {
            //Arrange
            string wordToReverse = " 1HELLO! ";
            string expected = " 1OLLEH! ";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(wordToReverse);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_HsymEsymLsymLsymOsym_OsymLsymLsymEsymHsym()
        {
            //Arrange
            string wordToReverse = "H1E/L-L+O!";
            string expected = "O1L/L-E+H!";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(wordToReverse);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_symHelloSpaceHelloSym_symolleHSpaceolleHSym()
        {
            //Arrange
            string wordToReverse = "1Hello Hello2";
            string expected = "1olleH olleH2";

            //Act
            var anagram = new Anagram();
            var actual = anagram.Revers(wordToReverse);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
