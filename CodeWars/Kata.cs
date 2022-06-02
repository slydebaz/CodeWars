namespace CodeWars
{
    public static class Kata
    {
      
        public static int[] Flip(char dir, int[] arr)
        {


            List<int> numbers = new List<int>(arr);
            if (dir == 'R')
            {
                arr = numbers.OrderBy(x => x).ToArray();
            }
            else
            {
                arr = numbers.OrderByDescending(x => x).ToArray();
            }
            return arr;
        }
    }
}