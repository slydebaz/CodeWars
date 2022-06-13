using System.Linq;
using System.Text;

namespace CodeWars
{

    public class HammingLetterDecoder
    {

        private string _hammingToDecode;

        public HammingLetterDecoder(string hammingToDecode)
        {

            _hammingToDecode = hammingToDecode;
            //triples
            //corrected bits
            //bytes
            //ASCII Values
        }

        public List<string> Triples()
        {
            List<string> triples = new List<string>();
            if(_hammingToDecode.Length % 3 != 0)
            {

                //throw exception for invalid Hamming string
            }
            else
            {
                var chars = _hammingToDecode.ToCharArray();

                int i = 0;
                while (i < chars.Length)
                {
                    StringBuilder triple = new StringBuilder();
                    triple.Append(chars[i]);
                    triple.Append(chars[i + 1]);
                    triple.Append(chars[i + 2]);
                    triples.Add(triple.ToString());
                    i+=3;
                }


            }
            return triples;
        }

        

        public char[] Correct()
        {
            var triples = Triples();

            char[] correctedBits = new char[8];

            int i = 0;
            triples.ForEach(triple =>
            {
                
                char[] chars = triple.ToCharArray();
                int sum = int.Parse(chars[0].ToString()) + int.Parse(chars[1].ToString()) + int.Parse(chars[2].ToString());
                if (sum == 0)
                {
                    correctedBits[i] = '0';
                }
                else if (sum == 1)
                {
                    correctedBits[i] = '0';
                }
                else if (sum == 2)
                {
                    correctedBits[i] = '1';
                }
                else if (sum == 3)
                {
                    correctedBits[i] = '1';
                }
                i++;
            });

            return correctedBits;
        }

        public string Binary()
        {
            var corrected = Correct();

            string binary = "";


            for(int i = 0; i < corrected.Length; i++)
            {
                binary += corrected[i];
            }

            return binary;
        }

        public int Ascii()
        {
            var binary = Binary();
            var ascii = Convert.ToInt32(binary, 2);
            return ascii;
        }

        public char AsciiToChar()
        {
            var ascii = Ascii();
            char c = Convert.ToChar(ascii);

            return c;
        }
    }
}