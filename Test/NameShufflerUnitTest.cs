using CodeWars;
using NUnit.Framework;

namespace Test
{
    public class NameShufflerUnitTest
    {

        [Test, Description("Sample Tests empty")]
        public void SampleTest()
        {
            Assert.AreEqual("", NameShuffler.Run(""));
    
        }

        [Test, Description("Sample one word")]
        public void SampleTest_one_caracter()
        {
            Assert.AreEqual("john", NameShuffler.Run("john"));

        }

        [Test, Description("Sample two words")]
        public void SampleTest_two_words()
        {
            Assert.AreEqual("McClane john", NameShuffler.Run("john McClane"));
            Assert.AreEqual("jeggins Mary", NameShuffler.Run("Mary jeggins"));
            Assert.AreEqual("jerry tom", NameShuffler.Run("tom jerry"));
        }
    }
}