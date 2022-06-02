using CodeWars;
using NUnit.Framework;

namespace Test
{
    public class GravityFlipUnitTest
    {

        [Test]
        public void Test_nothing_to_do()
        {

            Assert.AreEqual(new int[] { 0, 0, 0, 1 }, GravityFlip.Flip('R', new int[] { 0, 0, 0, 1 }));
    
        }

        [Test]
        public void Test_shift_right()
        {
            Assert.AreEqual(new int[] { 0, 1 }, GravityFlip.Flip('R', new int[] { 1, 0 }));

            Assert.AreEqual(new int[] { 0, 0, 0, 1 }, GravityFlip.Flip('R', new int[] { 0, 0, 1, 0 }));
            Assert.AreEqual(new int[] { 0, 0, 0, 1 }, GravityFlip.Flip('R', new int[] { 0, 1, 0, 0 }));
            Assert.AreEqual(new int[] { 0 ,0 ,0, 1 }, GravityFlip.Flip('R', new int[] { 1, 0, 0, 0 }));


        }

        [Test]
        public void Test_shift_right2()
        {
            Assert.AreEqual(new int[] { 0 ,0, 1, 2 }, GravityFlip.Flip('R', new int[] { 0, 0, 2, 1 }));
            Assert.AreEqual(new int[] { 0, 0, 1, 2 }, GravityFlip.Flip('R', new int[] { 0, 2, 1, 0 }));
            Assert.AreEqual(new int[] { 0, 0, 1, 2 }, GravityFlip.Flip('R', new int[] { 2, 0, 1, 0 }));
            Assert.AreEqual(new int[] { 0, 0, 1, 2 }, GravityFlip.Flip('R', new int[] { 2, 0, 0, 1 }));


        }


        [Test]
        public void Test_shift_left()
        {
            Assert.AreEqual(new int[] { 2, 1, 0, 0 }, GravityFlip.Flip('L', new int[] { 0, 0, 2, 1 }));
            Assert.AreEqual(new int[] { 2, 1, 0, 0 }, GravityFlip.Flip('L', new int[] { 0, 2, 1, 0 }));
            Assert.AreEqual(new int[] { 2, 1, 0, 0 }, GravityFlip.Flip('L', new int[] { 2, 0, 1, 0 }));
            Assert.AreEqual(new int[] { 2, 1, 0, 0 }, GravityFlip.Flip('L', new int[] { 2, 0, 0, 1 }));


        }

        [Test]
        public void Test_shift_left2()
        {
            Assert.AreEqual(new int[] { 2, 1, 0, 0 }, GravityFlip.Flip('L', new int[] { 0, 0, 2, 1 }));
            Assert.AreEqual(new int[] { 2, 1, 0, 0 }, GravityFlip.Flip('L', new int[] { 0, 2, 1, 0 }));
            Assert.AreEqual(new int[] { 2, 1, 0, 0 }, GravityFlip.Flip('L', new int[] { 2, 0, 1, 0 }));
            Assert.AreEqual(new int[] { 2, 1, 0, 0 }, GravityFlip.Flip('L', new int[] { 2, 0, 0, 1 }));


        }
    }
}