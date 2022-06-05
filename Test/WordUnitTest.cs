using CodeWars;
using NUnit.Framework;

namespace Test
{
    public class WordUnitTest
    {

        [Test]
        public void Test_Empty()
        {
            Word w = new Word("");
            Assert.AreEqual("", w.Content);
        }

        [Test]
        public void Test_notEmpty()
        {
            Word w = new Word("doce");
            Assert.AreEqual("doce", w.Content);
        }


        //[Test]
        //public void Test_Anagram_OK()
        //{
        //    Word w0 = new Word("doce");

        //    Word w1 = new Word("cedo");

        //    bool isAnagram = w0.IsAnagram(w1);
        //    Assert.AreEqual(true, isAnagram);
        //}

        [Test]
        public void Test_Topology_with_empty_word()
        {
            Word w0 = new Word("");

            Dictionary<char, int> topology = w0.Topology;
            Assert.AreEqual(0, w0.Topology.Count);
        }

        [Test]
        public void Test_Topology_not_empty_word()
        {
            Word w0 = new Word("doce");

            Dictionary<char, int> topology = w0.Topology;
            Assert.AreEqual(4, w0.Topology.Count);
        }

        [Test]
        public void Test_Topology_with_twin_caracters_on_one_letter()
        {
            Word w0 = new Word("hello");

            Dictionary<char, int> topology = w0.Topology;
            Assert.AreEqual(4, w0.Topology.Count);
        }

        [Test]
        public void Test_Topology_with_twin_caracters_on_two_letters()
        {
            Word w0 = new Word("helloo");

            Dictionary<char, int> topology = w0.Topology;
            Assert.AreEqual(4, w0.Topology.Count);
        }

        [Test]
        public void Test_Should_return_false_if_words_are_not_anagrams()
        {
            Word w0 = new Word("toto");

            Word w1 = new Word("titi");

            bool isAnagram = w0.IsAnagram(w1);
            Assert.AreEqual(false, isAnagram);
        }


        [Test]
        public void Test_Should_return_false_if_words_are_anagrams()
        {
            Word w0 = new Word("toto");

            Word w1 = new Word("otto");

            bool isAnagram = w0.IsAnagram(w1);
            Assert.AreEqual(true, isAnagram);
        }
    }
}