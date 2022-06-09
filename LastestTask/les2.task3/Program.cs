using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int sum = 0;
            int umn = 1;
            int eded = Convert.ToInt32(Console.ReadLine());
            


            for (int i = 1; i <= eded; i++)
            {

                sum+= i;
                 umn*=i;           
            }
          
            Console.WriteLine("cemi "+sum);
            Console.WriteLine("hasili "+umn);
            Console.WriteLine("ferqi " +  (umn - sum));
            
            

       
          
        }

    }
}
