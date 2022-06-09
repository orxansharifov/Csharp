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
            Console.WriteLine("Eded daxil edin");
            int sum = 0;
            int eded = Convert.ToInt32(Console.ReadLine());
         
            
         
            for (int i = 1; i <=eded; i++)
            {

                sum+= i*i;
               
            }
             Console.WriteLine(" kvadratlarin cemi "+sum);
        }
       
    }
}
