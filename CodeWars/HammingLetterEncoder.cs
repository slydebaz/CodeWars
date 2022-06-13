using System.Linq;
using System.Text;

namespace CodeWars
{

    public class HammingLetterEncoder
    {

        private char _letter;

        public HammingLetterEncoder(char letter)
        {

            _letter = letter;
            //ascii

            //binary
            //triple
            //concat
        }

        public int EncodeAscii()
        {

            //var chars = new char[1] { _letter };

            var ASCIIvalues = System.Convert.ToInt32(_letter);
            //string str = "ABCDEFGHI";
            //byte[] ASCIIvalues = Encoding.ASCII.GetBytes(_letter.ToString());


            //return Encoding.ASCII.GetBytes(chars);

            return ASCIIvalues;
        }

        public string EncodeBinary()
        {
           // var chars = new char[1] { _letter };

            string result = EncodeAscii().ToString();

            var b = Byte.Parse(result);

            var parsed = Convert.ToString(b, 2);
            var someString = parsed.PadLeft(8, '0');
            //var s = _letter.ToString();

            //while (value != 0)
            //{
            //    index = value / radix; // implicit integer division  
            //    value = value % radix;
            //    result += alphabet[index].ToString();
            //}

            return someString;
        }

        public string EncodeTriple()
        {
            var b = EncodeBinary();

            string tmp = "";

            for (int i = 0; i < b.Length; i++)
            {
                //tmp += b[i];
                //tmp += b[i];
                //tmp += b[i];

                tmp += string.Concat(Enumerable.Repeat(b[i], 3));
            }

            //return "000111111000111000000000";

            return tmp;
        }
    }



}