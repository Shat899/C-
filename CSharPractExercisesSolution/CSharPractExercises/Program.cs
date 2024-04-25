using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharPractExercises
{
    class Prgram 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Please enter your First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine($"{firstName} Please enter your Age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"{firstName} Please enter your weight");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine($"{firstName} Please enter your height");
            double height = double.Parse(Console.ReadLine());
            double bodyMasIndex = height / (weight * weight);
            Console.WriteLine($" Your profile: \n Full Name: {firstName} {lastName} \n Age:{age} \n weight: {weight} \n height: {height} \n Body Mas Index: {bodyMasIndex}");



        }

        static void masiv()
        {
            byte b = 3;
            int a = b;

            b = (byte)a; //convert big data type in small data type or double to int

            // declare masiv
            int[] a1 = new int[10];

            // declare masiv and include it with information
            int[] a2 = { 1, 5, 8, 1, 15 };
            // view information with index
            Console.WriteLine(a2[2]);
            // count index maosive
            Console.WriteLine(a2.Length);
            //last index from masive 
            Console.WriteLine(a2.Length - 1);


        }
       
        static void String()
        {

            // formating string
            string name = "John";
            int age = 25;
            string space = " ";
            string str1 = string.Format("My{0}name{0}is{0}{1}{0}and{0}I{0}am{0}{2}", space, name, age);// place string from index
            string str2 = $"My name is {name} and I am {age}";
            string str3 = "My name is \n John"; // \n din rind nou
            string str4 = "My am \t 30"; // tabolation 
            string str5 = @"\\mycomp\\newmap"; // ignore slash
            Console.WriteLine(str1);

            int answer = 40;
            string name1 = "abracadabra";
            bool contansA = name.Contains('a');
            bool contansE = name.Contains('E');
            Console.WriteLine(contansA);
            Console.WriteLine(contansE);

            bool endsWithAbra = name.EndsWith("abra");
            bool startsWithAbra = name.StartsWith("abra");
            Console.WriteLine(endsWithAbra);
            Console.WriteLine(startsWithAbra);
            // retur boll
            int indexOfA = name.IndexOf('a');
            Console.WriteLine(indexOfA);

            int lastIndexOfR = name.LastIndexOf("r");

            Console.WriteLine(name.Length);

            string substrFrom5 = name.Substring(5);
            string substrFromTo = name.Substring(0, 3);
            Console.WriteLine(substrFrom5);
            Console.WriteLine(substrFromTo);

            //-----------Empty String-------------//

            string empty = "";
            string withSpaced = " ";
            string notEmpty = " b";
            string nullString = null;


            bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(withSpaced);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrEmpty);


            Console.WriteLine();
            Console.WriteLine("IsNullOrWhiteSpace");

            bool IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(IsNullOrWhiteSpace);

            IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(IsNullOrWhiteSpace);

            IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(withSpaced);
            Console.WriteLine(IsNullOrWhiteSpace);

            IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(IsNullOrWhiteSpace);
            //--------------------------------------------
            string Empty = string.Empty;
            string join = string.Join("x", "y", "z"); // join string variable or text
            join = join.Insert(0, "a");
            join = join.Remove(0, 1);
            string replace = join.Replace("y", "f");
            string data = "Vasea;Petru;Dumitru;Sergiu";
            string[] slipData = data.Split(';');

            for (int i = 0; i < slipData.Length; i++)
            {
                Console.WriteLine(slipData[i]);
            }
            string lower = data.ToLower();
            string upper = data.ToUpper();

            Console.WriteLine(lower);// lpwer simbol
            Console.WriteLine(upper);// upper simbol

            string trim = data.Trim(); // remove space from begin and end string

            //---------Bild string ----------------
            StringBuilder sb = new StringBuilder();
            sb.Append("My");
            sb.Append(withSpaced);
            sb.Append("name");
            sb.Append(withSpaced);
            sb.Append("is");
            sb.Append(withSpaced);
            sb.Append("John");
            sb.Append(withSpaced);
            sb.Append("!");
            string firstName = sb.ToString();
            Console.WriteLine(firstName);

        }
        static void StaticExplication ()
        {
            string name = "abracadabra";                 // string is typ, variabile name is exemplare tayp 
            bool contansA = name.Contains('a');         // metod Contains is nonstatic becose we use it on exemplare type
            bool contansE = name.Contains('E');

            Console.WriteLine(contansA);
            Console.WriteLine(contansE);

            string abc = string.Concat("a", "b", "c"); // metod concat is static becos we use it on type and it return exemplare

        }
        static void MatchOperation()
        {
            int x = 1;
            int y = 2;
            int z = 3;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            int b = 5 / 2;

        }

        static void Overflow()
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
