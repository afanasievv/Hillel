using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class StatOperations
    {
        public Hashtable MostAppeared(HashSet<HashSet<int>> list, int n)
        {
            
           
            int count = 0;
            Hashtable hashtable = new Hashtable();

            foreach (var item in Convert(list))
            {
                count = Convert(list).Count(x => x == item);
                if (count >=1)
                {
                    
                    hashtable.Add(item, count);
                }

            }
            //перевірити хештейбл на N найбільших значень
            //Console.WriteLine($"{sum} {num}");
            return hashtable;
        }
        public List<int>  NeverAppeared (HashSet<HashSet<int>> list, int n)
        {
            
            List<int> res = new List<int>();
            for (int i= 1; i < n; i++)
            { 
              if (!Convert(list).Contains(i))
                    { res.Add(i); }
                    
            }
            return res;
        }
        public List<int> Convert(HashSet<HashSet<int>> list)
        {
            List<int> result = new List<int>();

            foreach (var item in list)
            {
                foreach (var ch in item)
                { result.Add(ch); }
            }
            return result;
        }
    }
}
