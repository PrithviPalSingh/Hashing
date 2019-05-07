using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class GroupAnagrams
    {
        public static void fnCountSystem(string[] strArray)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            for (int i = 0; i < strArray.Length; i++)
            {
                var word = strArray[i];
                char[] charArr = word.ToCharArray();
                Array.Sort(charArr);
                string newWord = new string(charArr);
                if (!dict.ContainsKey(newWord))
                {
                    dict.Add(newWord, new List<string>() { word });
                }
                else
                {
                    var list = dict[newWord];
                    list.Add(word);
                    dict[newWord] = list;
                }
            }

            foreach (var item in dict.OrderBy(i => i.Value.Count))
            {
                Console.Write(item.Value.Count + " ");
            }

            Console.WriteLine();
        }
    }
}
