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

        // Complete the isValid function below.
        public string isValid(string s)
        {
            //abc
           
            Dictionary<char, int> countChar = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (countChar.ContainsKey(c))
                    countChar[c]++;
                else
                    countChar.Add(c, 1);
            }

            int top1 = countChar.Values.GroupBy(i => i).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();
            int increaseFlag = 0;
            foreach (char key in countChar.Keys)
            {
                if (countChar[key] != top1)
                {
                    if ((increaseFlag == 0)&&((countChar[key] == top1 + 1) || (countChar[key] == 1)))                                           
                            increaseFlag++;
                        else
                            return "NO";                    
                }
            }
           // result = (increaseFlag > 1)? "NO": "YES";

            return "YES";

        }



        //  My solution is passing all test cases

        // def isValid(s): mydic=defaultdict(int) for i in s: mydic[i]+=1 k=list(mydic.values()) if max(k)==min(k) : return 'YES' 
        //if (k.count(max(k))==1) and((len(k)-k.count(min(k)))==1 and(max(k)-min(k)<=1)) or(k.count(min(k))==1 and(len(k)-k.count(max(k)))==1 and min(k)==1) : return 'YES' return 'NO'
    }
}
