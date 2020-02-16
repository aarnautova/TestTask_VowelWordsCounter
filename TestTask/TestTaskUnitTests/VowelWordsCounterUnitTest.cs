using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask;

namespace TestTaskUnitTests
{
    [TestClass]
    public class VowelWordsCounterUnitTest
    {
        VowelWordsCounter vowelWordsCounter = new VowelWordsCounter();
        [TestMethod]
        public void VowelWordsCounter_FormatIsValid_CorrectFormat_ShouldReturnTrue()
        {
            string testFormat1 = "file.txt";
            string testFormat2 = "1.txt";
            string testFormat3 = "_.txt";
            string testFormat4 = ".txt";

            Assert.IsTrue(vowelWordsCounter.FormatIsValid(testFormat1));
            Assert.IsTrue(vowelWordsCounter.FormatIsValid(testFormat2));
            Assert.IsTrue(vowelWordsCounter.FormatIsValid(testFormat3));
            Assert.IsTrue(vowelWordsCounter.FormatIsValid(testFormat4));
        }

        [TestMethod]
        public void VowelWordsCounter_FormatIsValid_WrongFormat_ShouldReturnFalse()
        {
            string testFormat1 = ".txtfile";
            string testFormat2 = "file.xml";
            string testFormat3 = "";
            string testFormat4 = "file";

            Assert.IsFalse(vowelWordsCounter.FormatIsValid(testFormat1));
            Assert.IsFalse(vowelWordsCounter.FormatIsValid(testFormat2));
            Assert.IsFalse(vowelWordsCounter.FormatIsValid(testFormat3));
            Assert.IsFalse(vowelWordsCounter.FormatIsValid(testFormat4));
        }

        [TestMethod]
        public void VowelWordsCounter_ContentIsValid_CorrectContent_ShouldReturnTrue()
        {
            string testContent1 = "";
            string testContent2 = "\n";
            string testContent3 = "qwerty";
            string testContent4 = "lorem ipsum\n\ndolor  sit amet";

            Assert.IsTrue(vowelWordsCounter.ContentIsValid(testContent1));
            Assert.IsTrue(vowelWordsCounter.ContentIsValid(testContent2));
            Assert.IsTrue(vowelWordsCounter.ContentIsValid(testContent3));
            Assert.IsTrue(vowelWordsCounter.ContentIsValid(testContent4));
        }

        [TestMethod]
        public void VowelWordsCounter_ContentIsValid_WrongContent_ShouldReturnFalse()
        {
            string testContent1 = ",!?";
            string testContent2 = "lorem ipsum.";
            string testContent3 = "Кириллица";

            Assert.IsFalse(vowelWordsCounter.ContentIsValid(testContent1));
            Assert.IsFalse(vowelWordsCounter.ContentIsValid(testContent2));
            Assert.IsFalse(vowelWordsCounter.ContentIsValid(testContent3));
        }

        [TestMethod]
        public void VowelWordsCounter_VowelWordsInStringCount_ShouldReturnRightCount()
        {
            string testContent1 = "";
            string testContent2 = " \n ";
            string testContent3 = "qwerty";
            string testContent4 = "lorem ipsum\n aie ou \ndolor  sit amet uie";
            string testContent5 = "uieuo";

            Assert.AreEqual(0, vowelWordsCounter.VowelWordsInStringCount(testContent1));
            Assert.AreEqual(0, vowelWordsCounter.VowelWordsInStringCount(testContent2));
            Assert.AreEqual(0, vowelWordsCounter.VowelWordsInStringCount(testContent3));
            Assert.AreEqual(3, vowelWordsCounter.VowelWordsInStringCount(testContent4));
            Assert.AreEqual(1, vowelWordsCounter.VowelWordsInStringCount(testContent5));
        }
    }
}
