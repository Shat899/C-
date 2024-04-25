

using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CorntrolFlow
{
    class Program {
        static void Main(string[] args) {


            long howManyDigits = int.Parse(Console.ReadLine());
            int[] numbers = new int [howManyDigits];
            int a0 = 0;
            int a1 = 1;

            numbers[0] = a0;
            numbers[1] = a1;

            for (int i = 2; i < howManyDigits; i++) 
            {
                int a = a0 + a1;
                numbers[i] = a;
                a0 = a1;
                a1 = a;
            }

            foreach (int numb in numbers) {

                Console.Write( $"{numb} ");
            }

            

            /*
           int[] numbers = { 0, 2, 3, 4, 5, 6, 7, 8, 9 };
           char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j' };

           int weddingYears = int.Parse(Console.ReadLine()) ;

           string name;

           switch (weddingYears)
           {
               case 5: name = "xxx";
                   break;
               case 10: name = "xxxx";
                   break;
               default: name = "empty";
                   break;
           }
           Console.WriteLine(name);


             for (int i = 0; i < numbers.Length; i++)
             {
                 Console.WriteLine($"Number = {numbers[i]}");
                 for (int j = 0; j < letters.Length; j++)
                 {
                     Console.Write($"{letters[j]}" );
                     if (numbers[i] == j)
                     {
                         break;
                     }
                 }
                 Console.WriteLine();
             }
             Console.WriteLine();
              for (int i = 0; i < numbers.Length; i++) {
                  Console.Write(numbers[i] + "");


             for (int i = 0;i < numbers.Length; i++) 
             { 

                 for (int j = i + 1; j < numbers.Length; j++) { 

                     int atI = numbers[i];
                     int atJ = numbers[j];

                     if (atI + atJ == 0)
                     {
                         Console.WriteLine($"Pair({atI};{atJ}). Indexes({i};{j})");
                     }
                 }
             }

         }*/

        }

        static void HomeWork()
        {
            Console.WriteLine("Hello dear user please into firts number");

            int firtsNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please into second number");

            int secondNumber = int.Parse(Console.ReadLine());

            string messege = "This number is higher";

            if (firtsNumber > secondNumber)
            {
                Console.WriteLine($"{messege} {firtsNumber}");
            }
            else if (firtsNumber < secondNumber)
            {
                Console.WriteLine($"{messege} {secondNumber}");
            }
            else
            {
                Console.WriteLine("The numbers are equal");

            }


        }
    
    }
   


}
