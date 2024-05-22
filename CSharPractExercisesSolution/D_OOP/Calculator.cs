using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace D_OOP
{
    public class Calculator
    {

        public  bool TryDivide(double divisible, double divisor, out double result) // method returned bool and result
        {
           
            result = 0;

            if (divisible == 0)
            {

                return false;

            }

            result = divisible / divisor;

            return true;

        }
        public static double CalcTriangleSquare(double ab, double bc, double ac)
        {
            double p = (ab + bc + ac) / 2;

            return Math.Sqrt (p * (p - ab) * (p - bc) * (p - ac));

        }

        public  double CalcTriangleSquare(double b, double h)
        {

            return 0.5 * b * h;
            

        }

        public  double CalcTriangleSquare(double ab, double ac, int alpha, bool isRadian = false) // isRadian is optional parameter
        {
            if (isRadian)
            {
                
                return 0.5 * ab * ac * Math.Sign(alpha);
            
            }
            else 
            {

                double rads = alpha * Math.PI / 180;
                return 0.5 * ab * ac * Math.Sign(rads);

            }


        }

        public static double Average(params int[]  numbers)
        {
            int sum = 0;
            foreach (int n in numbers) { 
                
                sum += n;
            
            }
            return (double) sum / numbers.Length;
            
        }
    }
}
