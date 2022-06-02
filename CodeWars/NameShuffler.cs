namespace CodeWars
{
    public static class NameShuffler
    {
      
        public static string Run(string str)
        {

            var names = str.Split(' ');

            if(names.Length == 1)
            {
                return str;
            }
            if(names.Length == 2)
            {
                var tmp = names[0];
                names[0] = names[1];
                names[1] = tmp;
                return $"{names[0]} {names[1]}";

            }
            return String.Empty;
        
        }
    }
}