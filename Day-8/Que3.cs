/*. Create  class  outdemo having method 
1.public int[] sqrarray(int[] arr, out int sum)
Job of this method is to do the sum of all element of an array.
 * This method should store square of each elements in to new array. Method should return new array.
 */



using System;


namespace outref
{
    class Program
    {
        
        public int[] sqrarray(int[] arr, out int sum)
        {
            int[] sqr = new int[5];
            int sum1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum1 = sum1 + arr[i];
                arr[i] = arr[i] * arr[i];
            }
            sum=sum1;
            return sqr;
        }

        static void Main(string[] args)
        {
            Program p=new Program();
            int[] arr = new int[5];

            Console.WriteLine("Enter Array  Element");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum;
            p.sqrarray(arr, out sum);
            
            Console.WriteLine("Sum is :"+sum);
            Console.WriteLine("Square is:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[ "+arr[i]+" ]");
            }
            Console.ReadLine();
        }
    }
}
