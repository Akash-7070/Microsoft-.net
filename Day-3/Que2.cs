
//    //Q2. Accept a number from user and pass it to static method of a struct calculator it should print all factor of a number.

//using System;

//namespace Day3
//{
//    struct calculator
//    {
//        public static void Fact(int a)
//        {
//            Console.WriteLine("Following Are Factors");
//            for (int i = 1; i <= a; i++)
//            {
//                if (a % i == 0)
//                {
//                    Console.Write(i+"\t");
//                }
//            }
//        }
//    }
//    class Class1
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a number");

//            string a = Console.ReadLine();

//            int c;
//            bool j = int.TryParse(a, out c);

//            if (j)
//            {
//                calculator.Fact(c);
//            }
//            else
//            {
//                Console.WriteLine("Invalid input");
//            }
//            Console.ReadLine();

//        }
//    }
//}
