using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class Prime
    {
        public bool IsPrime(int v)
        {
            string sV = v.ToString();
            var last = sV.Last();
            if (v <= 1 || v % 2 == 0 || last == '0' || last == '5')
            {
                return false;
            }

            int sqrt = (int)Math.Sqrt(v);
            if (sqrt * sqrt == v)
            {
                return false;
            }

            for (int i = 3; i < sqrt; i ++)
            {
                if(v % i == 0)
                {
                    return false;
                }
            }


            return true;
        }
    }
}
