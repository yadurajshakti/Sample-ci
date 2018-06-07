using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Multi(3, 2));

        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multi(int a, int b)
        {
            return a * b;
        }
    }
}
