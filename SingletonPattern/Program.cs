using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            calc.Divide(3, 0);

            Console.ReadKey();
        }
    }
}
