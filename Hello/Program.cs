using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int --> 4 bytes
            //char --> 2 bytes
            //bool--> 1 bit
            //string 2 bytes per char
            //long--> 8 bytes 
            //double --> 8 bytes 

            Console.WriteLine("Enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello my name is " + name);

            Console.Write("Enter float no");
            float f = float.Parse(Console.ReadLine());
            Console.WriteLine(f);

        }
    }
}
