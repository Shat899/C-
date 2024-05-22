
using System.Collections.Generic;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CorntrolFlow
{
    class Program {
        
        static void Main(string[] args) {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int index = Array.BinarySearch(numbers, 5); // search index in masiv

            int[] copy = new int[10];
            Array.Copy(numbers, copy, numbers.Length); // copy masiv in new masiv

            int[] anotherCopy = new int[10];
            copy.CopyTo(anotherCopy, 0); // copy masiv in new masiv

            Array.Reverse(anotherCopy); // reverse masiv
            Array.Sort(anotherCopy); // sort masiv
            Array.Clear(anotherCopy);// cleare masiv

            var intlist = new List<int>() { 1, 2, 3 };
            intlist.Add(5);  // add number in list
            
            intlist.AddRange(numbers); // add masiv in list


            var peaple = new Dictionary<int, string>()
            {
                {1, "Iura" },
                {2, "Alex" },
                {3,"Denis" },

            };


            peaple.Add(4, "Ion" );
            peaple.Add(5, "Alexei");
            peaple.Add(6, "Dumitru");

            string name = peaple[4]; // accesare dupa cheie

            var keys = peaple.Keys; // interaiting  over keys
            var values = peaple.Values; // interaiting  over values

            foreach( var pair in peaple) // interaiting  over keys ---> values
            {
                Console.WriteLine($"{pair.Key}, {pair.Value}" );
                Console.WriteLine(peaple.Count);
                bool containsKey = peaple.ContainsKey(0); // search key
                bool containsValue = peaple.ContainsValue("Dima");// search value 
                bool remove = peaple.Remove(0);
            }

             string login = "johnsilver";
             string pasword = "qwerty";
             Console.WriteLine("Hello!!!");


             for (int i = 0; i < 3; i++)
             {
                 Console.WriteLine("Please enter login");
                 string login1 = Console.ReadLine();
                 Console.WriteLine("Please enter pasword");
                 string pasword1 = Console.ReadLine();
                 if (login == login1 && pasword == pasword1)
                 {
                     Console.WriteLine("Enter the System");
                     break;
                 }
                 else
                 {
                     Console.WriteLine("The number of available tries have been exceeded");
                 }


             }
         





              Console.WriteLine("Hello dear user please enter until 10 integer");
              Console.WriteLine("Or enter 0 to stop the program after calculating averages");

              int[] numbers = new int[10];
              int number;
              for (int i = 0; i < 10; i++)
              {

                  Console.WriteLine("Please enter diget");
                  number = int.Parse(Console.ReadLine());
                  if (number == 0)
                  {
                      break;
                  };
                  numbers[i] = number;

              }
              decimal average = 0;
              decimal sum = 0;
              for (int j = 0; j < numbers.Length; j++)
              {
                  average = numbers[j];
                sum += average;

              }
              Console.WriteLine($"{sum/numbers.Length}");


          /*
              

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
