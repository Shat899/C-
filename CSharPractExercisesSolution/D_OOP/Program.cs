using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static D_OOP.ValRefTypes;

namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Calculator calc = new Calculator();

               double square1 = calc.CalcTriangleSquare(10, 20);
               double square2 = calc.CalcTriangleSquare(ab: 40, ac: 20, alpha: 30); // name argumenst
               Console.WriteLine($"Square1={square1}. Square2={square2}");

               int x = ParsingRomanNumerals.Parse("X");

              Calculator calc1 = new Calculator();

              if (calc1.TryDivide(10, 0, out double result))
              {
                  Console.WriteLine(result);
              }
              else 
              {
                  Console.WriteLine("Failed to divide");
              }

              Console.WriteLine("Enter a number, Please");

              string line = Console.ReadLine();

              bool wasParsed = int.TryParse(line, out int number); // check info 

              Console.WriteLine(number);

              */

            PointVal a;  //= new PointVal() //is same
            a.x = 3;
            a.y = 5;                   // if is stuctur 
                                       // two different copies of the structure are made

            PointVal b = a;

            b.x = 7;
            b.y = 10;

            a.LogValues();
            b.LogValues();

            Console.WriteLine("After structs");


            PointRef c = new PointRef();
            a.x = 3;
            a.y = 5;                // if is class 'Link' 
                                    // variable c and d are same link on memory

            PointRef d = c;

            b.x = 7;
            b.y = 10;

            c.LogValues();
            d.LogValues();

            Console.WriteLine("After structs");
        }
    }

}