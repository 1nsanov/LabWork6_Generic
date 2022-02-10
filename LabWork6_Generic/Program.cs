using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork6_Generic
{
    class Program
    {
        public static void Main()
        {
            var parallelogramInt = new Parallelogram<int>(5, 8, 60);
            var parallelogramFloat = new Parallelogram<float>(6.3f, 3.4f, -60f);
            var parallelogramDouble = new Parallelogram<double>(8.5, 5.7, 60);

            Console.WriteLine(parallelogramInt.CalcSquare());
            Console.WriteLine(parallelogramFloat.CalcSquare());
            Console.WriteLine(parallelogramDouble.CalcSquare());

            Console.ReadLine();
        }
    }
}
