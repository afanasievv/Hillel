using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Lesson6
{
    public class StatOperations
    {
        public Hashtable MostAppeared(HashSet<HashSet<int>> list, int n)
        {
            
            int count = 0;
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, count);

            //foreach (var item in Convert(list))
            //{

            //        if(!hashtable.ContainsKey(item))
            //        hashtable.Add(item, count);

            //}
            int maxCount = MaxCount(list);
                int currentCount;
                foreach(var item in Convert(list))
                {
                    currentCount = Convert(list).Count(x => x == x);
                    if (currentCount==maxCount)
                    {
                    Console.WriteLine("dfd");
                    if (!hashtable.ContainsKey(item))
                        hashtable.Add(item, currentCount);
                     }
                maxCount-=1;

                }
            
            //foreach (var key in hashtable.Keys)
            //{
            //    if ((int)hashtable[key] >= 2)
            //        Console.WriteLine(key + " " + hashtable[key]);
            //}
            
            return hashtable;
        }
        private int MaxCount(HashSet<HashSet<int>> list)
        {
            int maxCount = 0;
            foreach(var item in Convert(list))
            {
                int currentItemCount = Convert(list).Count(x => x == item);
                if(currentItemCount>maxCount)
                {
                    maxCount= currentItemCount;
                }
            }
            return maxCount;
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
