using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public class ParsingRomanNumerals
    {

        private static Dictionary<char, int> map = new Dictionary<char, int> ()
        {

            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 100},

        };

        public static int Parse(string roman)
        {
            
           int result = 0;

            for (int i = 0; i < roman.Length; i++) 
            {
                if(i + 1 < roman.Length && IsSubtrative(roman[i], roman[i + 1]))
                {
                    char leter = roman[i];
                    result -= map[leter];
                }
                else
                {
                    char leter = roman[i];
                    result += map[leter];
                }
            
            
            }
            return result;
        }

        private static bool IsSubtrative(char c1, char c2)
        {
            return map[c1] < map[c2];
        }
    }
}
