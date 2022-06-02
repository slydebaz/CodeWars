namespace CodeWars
{
    public static class GravityFlip
    {
      
        public static int[] Flip(char dir, int[] arr)
        {


            List<int> numbers = new List<int>(arr);
            if (dir == 'R')
            {
                arr = numbers.OrderBy(x => x).ToArray();
            }
            else if(dir == 'L')
            {
                arr = numbers.OrderByDescending(x => x).ToArray();
            }
            return arr;
        }
    }
}