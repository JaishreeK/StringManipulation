using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public class Class1
    {

        // Complete the alternatingCharacters function below.
        public static int alternatingCharacters(string s)
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

        public static int alternatingCharacters1(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                    count++;
            }

            return count;
        }
    }
}
