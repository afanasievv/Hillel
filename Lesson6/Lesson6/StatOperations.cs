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
        public void MostAppeared(HashSet<HashSet<int>> hashSet, int n)
        {           
            Hashtable hashtable = new Hashtable();
                       
            int maxCount = MaxCount(hashSet);
            
            int currentCount;
            while (hashtable.Count < n)
            {
                foreach (var item in ConvertToList(hashSet))
                {   if (hashtable.Count == n )break;
                    currentCount = ConvertToList(hashSet).Count(x => x == item);
                    if (!hashtable.ContainsKey(item) && currentCount == maxCount)
                    {
                        hashtable.Add(item, currentCount);

                    }

                }
                maxCount--;
            }
            
            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine("The number " + key + " appeares " + hashtable[key] + " times");
            }

        }
        
        public void  NeverAppeared (HashSet<HashSet<int>> list)
        {
            int n=list.Count;
            
            List<int> res = new List<int>();
            for (int i= 1; i < 42; i++)
            { 
              if (!ConvertToList(list).Contains(i))
                    { res.Add(i); }
                    
            }
            if(res.Count==0)
            Console.WriteLine("Never appeared numbers is absent\n");
            else Console.WriteLine("Numbers that never appeared:" + String.Join(",", res)+"\n");
        }
        private int MaxCount(HashSet<HashSet<int>> hashSet)
        {
            int maxCount = 0;
            foreach (var item in ConvertToList(hashSet))
            {
                int currentItemCount = ConvertToList(hashSet).Count(x => x == item);
                if (currentItemCount > maxCount)
                {
                    maxCount = currentItemCount;
                }
            }
            return maxCount;
        }
        public List<int> ConvertToList(HashSet<HashSet<int>> hashSet)
        {
            List<int> result = new List<int>();

            foreach (var item in hashSet)
            {
                foreach (var ch in item)
                { result.Add(ch); }
            }
            return result;
        }
    }
}
