using CodeWars;
using NUnit.Framework;

namespace Test
{
    public class PrimeUnitTest
    {
        private Prime _p;


        public PrimeUnitTest()
        {
            _p = new Prime();
        }

        [Test]
        public void T0_Test_negative()
        {

            Assert.AreEqual(false, _p.IsPrime(-1));
    
        }

        [Test]
        public void T1_Test_value_0()
        {

            Assert.AreEqual(false, _p.IsPrime(0));

        }

        [Test]
        public void T2_Test_value_1()
        {

            Assert.AreEqual(false, _p.IsPrime(1));

        }

        [Test]
        public void T3_Test_positive_even()
        {

            Assert.AreEqual(false, _p.IsPrime(2));
            Assert.AreEqual(false, _p.IsPrime(4));
            Assert.AreEqual(false, _p.IsPrime(6));
            Assert.AreEqual(false, _p.IsPrime(8));
            Assert.AreEqual(false, _p.IsPrime(10));

        }

        [Test]
        public void T4_Test_multiple_5()
        {
            Assert.AreEqual(false, _p.IsPrime(5));
            Assert.AreEqual(false, _p.IsPrime(10));
            Assert.AreEqual(false, _p.IsPrime(15));
            Assert.AreEqual(false, _p.IsPrime(20));
            Assert.AreEqual(false, _p.IsPrime(25));
        }

        [Test]
        public void T5_Test_odd_prime()
        {
            Assert.AreEqual(true, _p.IsPrime(3));
            Assert.AreEqual(true, _p.IsPrime(7));
            Assert.AreEqual(true, _p.IsPrime(11));
            Assert.AreEqual(true, _p.IsPrime(13));
            Assert.AreEqual(true, _p.IsPrime(17));
            Assert.AreEqual(true, _p.IsPrime(19));
            Assert.AreEqual(true, _p.IsPrime(23));
            Assert.AreEqual(true, _p.IsPrime(31));
            Assert.AreEqual(true, _p.IsPrime(37));
            Assert.AreEqual(true, _p.IsPrime(41));
            Assert.AreEqual(true, _p.IsPrime(43));
        }

        [Test]
        public void T6_Test_odd_not_prime()
        {
           
            Assert.AreEqual(false, _p.IsPrime(9));
            Assert.AreEqual(false, _p.IsPrime(21));
            Assert.AreEqual(false, _p.IsPrime(27));
        }


    }
}