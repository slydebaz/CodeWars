using System.Linq;

namespace CodeWars
{

    public class Hamming
    {
        public string Encode(string v)
        {
            List<HammingLetterEncoder> _encoder = new List<HammingLetterEncoder>();

            var chars = v.ToCharArray();


            for(int i = 0; i< chars.Length; i++)
            {
                _encoder.Add(new HammingLetterEncoder(chars[i]));
            }

            string results = "";
            _encoder.ForEach(x =>
            {
                results += x.EncodeTriple();
            });

            return results;

        }

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

        //public string Decode(string v)
        //{
        //    var decoder = new HammingLetterDecoder(v);
        //    return decoder.Convert();
        //}
    }



}