
/*Q4. Create a class swapdemo having method
 	Public void swap(int x, int y)
Job of this method is to swap two number. 
 * Create a entry point class  who’s job is to call this method and print swapped data.
*/

using System;

namespace SwapDemo
{
    public class swapDemo
    {
        public void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            swapDemo s=new swapDemo();
            int x=10,y=20;
            Console.WriteLine("Before Swap: x={0} y={1}",x,y);

            s.swap(ref x,ref y);
            Console.WriteLine("After Swap: x={0} y={1}",x,y);
            Console.ReadLine();
        }
    }
}
