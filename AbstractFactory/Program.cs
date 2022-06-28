using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client entrepreneur = new Client(new ElegantClothesFactory());
            Console.WriteLine($"Entrepreneur: {entrepreneur.GetDressed()}");

            Client student = new Client(new CasualClothesFactory());
            Console.WriteLine($"Student: {student.GetDressed()}");

            Console.ReadKey();
        }
    }
}
