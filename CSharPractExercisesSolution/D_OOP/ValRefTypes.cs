using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    internal class ValRefTypes
    {
        public struct PointVal
        {
            public int x;
            public int y;

            public void LogValues()
            {

                Console.WriteLine($"X={x}; Y={y}");

            }
        }

        public struct PointRef
        {
            public int x;
            public int y;

            public void LogValues()
            {

                Console.WriteLine($"X={x}; Y={y}");

            }
        }
    }
}
