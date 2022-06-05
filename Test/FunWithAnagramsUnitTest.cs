using CodeWars;
using NUnit.Framework;

namespace Test
{
    public class FunWithanagramsUnitTest
    {

        private FunWithanagrams _fwa;

        public FunWithanagramsUnitTest()
        {
            _fwa = new FunWithanagrams();
        }

        [Test]
        public void Test_Empty()
        {

            Assert.AreEqual(new string[] { }, _fwa.Run(new string[] { }));
        }

        [Test]
        public void Test_One_word()
        {

            Assert.AreEqual(new string[] {"toto" }, _fwa.Run(new string[] {"toto" }));
        }

        [Test]
        public void Test_Words_Not_Anagrams()
        {

            Assert.AreEqual(new string[] { "toto", "titi" }, _fwa.Run(new string[] { "toto" , "titi" }));
            Assert.AreEqual(new string[] { "toto", "titi", "tata" }, _fwa.Run(new string[] { "toto", "titi" , "tata"}));
        }

        [Test]
        public void Test_Words_With_Anagrams()
        {

           // Assert.AreEqual(new string[] { "toto", "titi" }, _fwa.Run(new string[] { "toto", "otto", "titi"}));
            Assert.AreEqual(new string[] { "toto", "titi", "hello" }, _fwa.Run(new string[] { "toto", "otto", "titi", "hello" }));
          
        }

        [Test]
        public void Test_Words_With_Anagrams_advanced()
        {

            Assert.AreEqual(new string[] { "toto", "titi", "hello" }, _fwa.Run(new string[] { "toto", "otto", "titi", "hello", "olleh" }));
        }

        [Test]
        public void Test_Words_With_Anagrams_advanced_2()
        {

            Assert.AreEqual(new string[] { "toto", "voiture", "titi", "hello" }, _fwa.Run(new string[] { "toto", "otto", "voiture", "titi", "hello", "olleh" }));
        }



    }
}