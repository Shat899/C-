using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharPractExercises
{
    class Prgram 
    { 
        static void Main (string[] args)
        {
            checked // does not allow overflow
            {  
                uint x = uint.MaxValue;
                x = x + 1;
                Console.WriteLine(x);

            }
        }
    }
}
