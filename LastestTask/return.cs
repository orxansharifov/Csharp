using System;
using System.Collections.Generic;
using System.Text;

namespace Les7task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum1(5));
            Console.WriteLine(Sum2(2));
            Console.WriteLine(Sum3("Text1"));
            Console.WriteLine(Sum4(15, "Salam"));
            Console.WriteLine(Sum5(2, 3));
            Console.WriteLine(Sum6("text2", 44));
            Console.WriteLine(Sum7("text3", 66));
            Console.WriteLine(Sum8('e', 222));
            Console.WriteLine(Sum9(22, 34));
            Console.WriteLine(sum10(22, 33));
            Console.WriteLine(sum11(11, 22));
         
        }
        #region

        public static int Sum1(int a)
        {
            return a;
        }
        public static byte Sum2(long b)
        {
            return 11;
        }
        public static string Sum3(string c)
        {
            return c;
        }
        public static int Sum4(long a1, string a2)
        {
            return 100;
        }
        public static char Sum5(int a3, long a4)
        {
            return 's';
        }
        public static sbyte Sum6(string a5, long a6)
        {
            return 44;
        }
        #endregion
        public static bool Sum7(string a8, long a9)
        {
            return true;
        }
        public static sbyte Sum8(char b1, long b2)
        {
            return 22;
        }
        public static int Sum9(sbyte b3, long b4)
        {
            return 22;
        }
        public static bool sum10(sbyte b5, long b6)
        {
            return false;
        }
        public static string sum11(byte b7, long b8)
        {
            return "tex4";
        }
        
        }
        






}

}
