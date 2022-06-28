using FactoryMethod.Vehicle;
using FactoryMethod.VehicleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory.VehicleFactory factory = new ConcreteVehicleFactory();

            IVehicleFactory bike = factory.GetVehicle("Bike"); bike.Drive(40);
            IVehicleFactory scooter = factory.GetVehicle("Scooter"); scooter.Drive(80);

            Console.ReadKey();
        }
    }
}
