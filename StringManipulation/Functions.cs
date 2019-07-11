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

            char[] aCharArray = a.ToLower().ToCharArray();
            char[] bCharArray = b.ToLower().ToCharArray();
                      
            char[] aDiff = aCharArray.Except(bCharArray).ToArray();
            char[] bDiff = bCharArray.Except(aCharArray).ToArray();
            int[] charCountsA = new int[aDiff.Length];
            for(int i=0;i<aDiff.Length;i++)
            {
                //find out no. of repetitions of each character in the first string
               charCountsA[i] = a.Count(x => x == aDiff[i]);

            }
            int sumADiff = charCountsA.Sum();
            int[] charCountsB= new int[bDiff.Length];
            for (int i = 0; i < bDiff.Length; i++)
            {
                //find out no. of repetitions of each character in the first string
                charCountsB[i] = b.Count(x => x == bDiff[i]);

            }

            int sumBDiff = charCountsB.Sum();

            numDeletes = sumADiff + sumBDiff;
           
            return numDeletes;
        }

        public int solution(int[] A)
        {
            int num = 1;           
            List<int> listA = new List<int>(A);
            listA.RemoveAll(x => x < 0); 
            while (listA.Count > 0)
            {
                if (listA.Find(x => x == num) > 0)
                {
                    listA.RemoveAll(x => x == num);
                    num++;
                }
                else break;
            }
            return num;
        }

    }
}
