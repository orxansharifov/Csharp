using System;
using System.Collections.Generic;
using System.Text;

namespace void_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Num(5);
            Num2(2);
            Num3("hello");
            Num4(44, " Hy");
            Num5(4, 5);
            Num6("22",44);
            Num7(3,3);
            Num8(44,55);
            Num9("hy",33);
            
        }

        #region

        public static void Num(int a)
        {
            Console.WriteLine(a);
        }
        public static void Num2(long b)
        {
            Console.WriteLine(b);
        }
        public static void Num3(string c)
        {
            Console.WriteLine(c + 5);
        }
        public static void Num4(long a1, string a2)
        {
            Console.WriteLine(a1 + a2);
        }
        public static void Num5(int a3, long a4)
        {
            Console.WriteLine(a3 + a4);
        }
        #endregion
        public static void Num6 (string q1, long q2)
            {
            Console.WriteLine("salam",22);
            }
        public static void Num7(sbyte q3,long q4)
        {
            Console.WriteLine(44);
        }
        public static  void Num8(byte t,long t1)
        {
            Console.WriteLine(t);
        }
        public static void Num9(string qq,long yy)
        {
            Console.WriteLine();
        }


}
}
