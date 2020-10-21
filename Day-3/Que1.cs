
////Q1. Create a struct Math having two static method square and cube. Using struct variable 
//    //call this method and print square and cube of a number

//using System;

//namespace Day3
//{
//    struct Math1
//    {
//        public static int Sqr(int a)
//        {
//            return a * a;
//        }

//        public static int Cube(int b)
//        {
//            return b * b * b;
//        }

//    };
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a number");

//            string a = Console.ReadLine();

//            int c;
//            bool j = int.TryParse(a, out c);   

//            if (j)
//            {
//                Console.WriteLine("Square is:" + Math1.Sqr(c));
//                Console.WriteLine("Cube is:" + Math1.Cube(c));     
//            }
//            else
//            {
//                Console.WriteLine("Invalid input");
//            }
//            Console.ReadLine();
                        
//        }
//    }
//}
