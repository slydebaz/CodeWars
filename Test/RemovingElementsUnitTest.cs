using CodeWars;
using NUnit.Framework;

namespace Test
{
    public class RemovingElementsUnitTest
    {


        [Test]
        public void BasicTest_empty()
        {

            Assert.AreEqual(new object[] { }, RemovingElements.Run(new object[] { }));
        }

        [Test]
        public void BasicTest_one_word()
        {
            Assert.AreEqual(new object[] { "Hello", }, RemovingElements.Run(new object[] { "Hello", }));
            Assert.AreEqual(new object[] { 1 }, RemovingElements.Run(new object[] { 1 }));
        }

        [Test]
        public void BasicTest_mutiple_word()
        {
            Assert.AreEqual(new object[] { "Hello", "Hello Again" }, RemovingElements.Run(new object[] { "Hello", "Goodbye", "Hello Again" }));
            Assert.AreEqual(new object[] { new object[] { 1, 2 } }, RemovingElements.Run(new object[] { new object[] { 1, 2 } }));
            Assert.AreEqual(new object[] { 1, 3, 5, 7, 9 }, RemovingElements.Run(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
            Assert.AreEqual(new object[] { new object[] { "Goodbye" } }, RemovingElements.Run(new object[] { new object[] { "Goodbye" }, new Dictionary<string, string>() { { "Great", "Job" } } }));
        }

 


    }
}