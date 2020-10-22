using System;

namespace DevPro
{
    public class MyClass
    {
        public static int Sqr(int val)
        {
            return (val * val);
        }

        public static int Cube(int val)
        {
            return (val * val * val);
        }

        public static int Floor(double val)
        {
            return ((int)Math.Floor(val));
        }

        public static int Ciel(double val)
        {
            return ((int)Math.Ceiling(val));
        }

        public static int Absolute(int val)
        {
            return (Math.Abs(val));
        }
             
    }
}
