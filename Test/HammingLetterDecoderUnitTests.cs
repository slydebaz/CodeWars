using CodeWars;
using NUnit.Framework;

namespace Test
{
    public class HammingLetterDecoderUnitTests
    {
        [Test]
        public void T0_Should_Get_Triples_From_Hamming_String()
        {
            var h = new HammingLetterDecoder(
                "000" +
                "111" +
                "111" +
                "000" +
                "111" +
                "000" +
                "000" +
                "000");

            List<string> triples = new List<string>()
            {
                "000",
                "111",
                "111", 
                "000",
                "111",
                "000",
                "000",
                "000"
            };

            var t = h.Triples();
            Assert.AreEqual(triples.Count, t.Count);
            Assert.AreEqual(triples[0].Length, t[0].Length);

            Assert.AreEqual(triples[0], t[0]);
            Assert.AreEqual(triples[1], t[1]);
            Assert.AreEqual(triples[2], t[2]);
            Assert.AreEqual(triples[3], t[3]);
            Assert.AreEqual(triples[4], t[4]);
            Assert.AreEqual(triples[5], t[5]);
            Assert.AreEqual(triples[6], t[6]);
            Assert.AreEqual(triples[7], t[7]);

        }


        [Test]
        public void T1_Should_Correct_Hamming_String()
        {
            var h = new HammingLetterDecoder(
                "000" +
                "111" +
                "111" +
                "000" +
                "111" +
                "000" +
                "000" +
                "000");

            var t = h.Correct();

            Assert.AreEqual('0', t[0]);
            Assert.AreEqual('1', t[1]);
            Assert.AreEqual('1', t[2]);
            Assert.AreEqual('0', t[3]);
            Assert.AreEqual('1', t[4]);
            Assert.AreEqual('0', t[5]);
            Assert.AreEqual('0', t[6]);
            Assert.AreEqual('0', t[7]);

        }

        [Test]
        public void T2_Should_Get_corrected_binary_formatted_string()
        {
            var h = new HammingLetterDecoder(
                "000" +
                "111" +
                "111" +
                "000" +
                "111" +
                "000" +
                "000" +
                "000");

            var b = h.Binary();

            Assert.AreEqual("01101000", b);
           

        }

        [Test]
        public void T3_Should_Get_ASCII_from_the_binary_corrected_string()
        {
            var h = new HammingLetterDecoder(
                "000" +
                "111" +
                "111" +
                "000" +
                "111" +
                "000" +
                "000" +
                "000");

            var a  = h.Ascii();

            Assert.AreEqual(104, a);
        }

        [Test]
        public void T4_Should_Get_Character_From_Ascii()
        {
            var h = new HammingLetterDecoder(
                "000" +
                "111" +
                "111" +
                "000" +
                "111" +
                "000" +
                "000" +
                "000");


            Assert.AreEqual('h', h.AsciiToChar());
        }


    }
}