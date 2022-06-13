using CodeWars;
using NUnit.Framework;

namespace Test
{
    public class HammingLetterEncoderUnitTests
    {
        [Test]
        public void T0_Should_Get_Ascii_Value_From_Character()
        {
            var h = new HammingLetterEncoder('h');

           Assert.AreEqual(104, h.EncodeAscii());

        }

        [Test]
        public void T1_Should_Get_Binary_Value_From_Character()
        {
            var h = new HammingLetterEncoder('h');
            Assert.AreEqual("01101000", h.EncodeBinary());

            h = new HammingLetterEncoder('e');
            Assert.AreEqual("01100101", h.EncodeBinary());

            h = new HammingLetterEncoder('y');
            Assert.AreEqual("01111001", h.EncodeBinary());

        }

        [Test]
        public void T2_Should_Triple_Value_From_Character()
        {
            var h = new HammingLetterEncoder('h');
            Assert.AreEqual("000111111000111000000000", h.EncodeTriple());

        }

    }
}