using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public class Functions
    {
        // Complete the alternatingCharacters function below.
        public int alternatingCharacters(string s)
        {
            int numDeletes = 0;           
            int index = 0;
            int diff, nextIndex;
            while (index < s.Length)
            {                
                if (s.ElementAt(index) == 'A')                                    
                     nextIndex = s.IndexOf('B',index);
                else
                     nextIndex = s.IndexOf('A',index);
                
                if (nextIndex > 0)
                    diff = nextIndex - index;
                else
                    diff = s.Length - index;

                if (diff > 1)
                {
                    s = s.Remove(index + 1, diff - 1);
                    numDeletes = numDeletes + diff - 1;
                }       
                
                index++;
            }           
            return numDeletes;

        }

        public int alternatingCharacters1(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                    count++;
            }

            return count;
        }

        // Complete the makeAnagram function below.
        public int makeAnagram(string a, string b)
        {
            int numDeletes = 0;          
            //Write custom except function which takes care of repetitions
            int sumADiff = Except(a,b);
            int sumBDiff = Except(b, a);

            numDeletes = sumADiff + sumBDiff;
           
            return numDeletes;
        }

        public int Except(string a,string b)
        {
            foreach (var ch in a)
            {
                if (b.Contains(ch))
                {
                    int index = b.IndexOf(ch);
                    b = b.Remove(index, 1);
                }
            }
            return b.Length;
        }
    }
}
