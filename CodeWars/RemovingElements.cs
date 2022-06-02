using System.Linq;

namespace CodeWars
{
    public static class RemovingElements
    {
      
        public static object[] Run(object[] arr)
        {

            //if(arr.Length == 0)
            //{
            //    return arr;
            //}

            //if(arr.Length == 1)
            //{
            //    return arr;
            //}

            if(arr.Length >= 1)
            {

                List<object> sResult = new List<object>();
                for(int i = 0; i < arr.Length; i++)
                {
                    if(i % 2 == 0)
                    {
                        sResult.Add(arr[i]);
                    }
                }
            
                return sResult.ToArray();
            }

            return arr;
        
        }
    }
}