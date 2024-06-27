using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true, b = false, x;

            // AND operator
            x = a && b;
            Console.WriteLine("AND Operator: " + x);

            // OR operator
            x = a || b;
            Console.WriteLine("OR Operator: " + x);

            // NOT operator
            x = !a;
            Console.WriteLine("NOT Operator: " + x);
             Console.ReadLine();
        }
    }
}
