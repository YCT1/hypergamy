using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            double a;
            a = double.Parse( Console.ReadLine());
            string[] t = new string[Convert.ToInt32(a)];
            for(int i = 0; i < a; i++)
            {
                t[i] = "Yekta " + i.ToString() + "Den";
            }
            for(int i = 0; i < 1000; i++)
            {
                int test;
                test = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(t[test]);
            }
            
        }
    }
}
