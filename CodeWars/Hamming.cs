using System.Linq;

namespace CodeWars
{

    public class Hamming
    {
        /// <summary>
        /// Encode string using hamming algorithm
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public string Encode(string v)
        {
            List<HammingLetterEncoder> _encoder = new List<HammingLetterEncoder>();

            var chars = v.ToCharArray();


            for(int i = 0; i< chars.Length; i++)
            {
                _encoder.Add(new HammingLetterEncoder(chars[i]));
            }

            string results = String.Empty;
            _encoder.ForEach(x =>
            {
                results += x.EncodeTriple();
            });

            return results;

        }

        /// <summary>
        /// Decode string in a binary format using Hamming algorithm
        /// </summary>
        /// <param name="v">string in binary format</param>
        /// <returns></returns>
        public string Decode(string v)
        {
            string decoded = string.Empty;

            var chars = v.ToCharArray();

            int numberOfDigits = 24;

            int increments = v.Length / numberOfDigits;


            List<string> chunks = new List<string>();


            int start = 0;
            int i = 0;
            while(i < increments)
            {
                var chunk = v.Substring(start, numberOfDigits);
                chunks.Add(chunk);
                start += numberOfDigits;
                i ++;
            }

            chunks.ForEach(x =>
            {
                HammingLetterDecoder _decoder = new HammingLetterDecoder(x);
                decoded += _decoder.AsciiToChar();
            });
           
            return decoded;
        }
    }

}