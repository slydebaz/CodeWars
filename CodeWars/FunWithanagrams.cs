using System.Linq;

namespace CodeWars
{

    public class Word
    {
        public string Content;

        public Dictionary<char, int> Topology { get; private set; }

        public Word(string content)
        {
            Topology = new Dictionary<char, int>();
            Content = content;

            if(Content.Length > 0)
            {
                SetTopology();
            }
            
        }

        private void SetTopology()
        {
            var chars = Content.ToCharArray();
            for(int i = 0; i < chars.Length; i++)
            {
                var found = Topology.Keys.Contains(chars[i]);

                if(!found)
                {
                    Topology.Add(chars[i], 1);
                }
                else
                {
                    Topology[chars[i]] += 1;
                }
               
            }
            
        }

        public bool IsAnagram(Word w1)
        {
            if (w1.Topology.Count != this.Topology.Count)
            {
                return false;
            }
            else
            {
               foreach(KeyValuePair<char, int> pair in Topology)
               {
                    int occ1 = 0;
                    bool found = w1.Topology.TryGetValue(pair.Key, out occ1);

                    if(!found)
                    {
                        return false;
                    }
                    else
                    {
                        if (pair.Value != occ1)
                        {
                            return false;
                        }
                    }
                }
            }


            return true;
        }
    }


    public class FunWithanagrams
    {
        

        public string[] Run(string[] arr)
        {
            List<Word> wordsWithoutAnagrams = new List<Word>();
            if (arr.Length <= 1)
            {
                return arr;
            }
            else
            {

                List<Word> words = new List<Word>();
                for(int i = 0; i < arr.Length; i++ )
                {
                    words.Add(new Word(arr[i]));
                }

             
                for(int i = 0; i < words.Count; i++ )
                {
                    Word current = words[i];

                    if (i == 0)
                    {
                        wordsWithoutAnagrams.Add(current);
                    }
                    else
                    {
                        bool isAnagramFound = false;
                        foreach(var wwa in  wordsWithoutAnagrams)
                        {
                            if(wwa.IsAnagram(current))
                            {
                                isAnagramFound = true;
                                break;
                            }
                        }
                        if (isAnagramFound == false)
                        {
                            wordsWithoutAnagrams.Add(current);
                        }
                    }
                   
                }
            }

            List<string> wordsTextWithoutAnagrams = new List<string>();
            foreach (var w in wordsWithoutAnagrams)
            {
                wordsTextWithoutAnagrams.Add(w.Content);
            }
                   

            return wordsTextWithoutAnagrams.ToArray();
        
        }
    }
}