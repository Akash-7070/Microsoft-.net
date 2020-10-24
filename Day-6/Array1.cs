
//Accept data in 3*3matrix and print row wise sum

using System;

namespace Array
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of row and column");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[,] arr = new int[a, b];
            int sum;
            int r,c;
            Console.WriteLine("Enter Array Elements");
            for (r = 0; r < a; ++r)
            {
                sum = 0;
                for (c = 0; c < b; ++c)
                {
                    arr[r,c]= int.Parse(Console.ReadLine());
                    sum += arr[r, c];
                }
                Console.WriteLine("Sum of {0} Row is: {1}", (r + 1), sum);
            }
            Console.ReadLine();
        }
    }
}
