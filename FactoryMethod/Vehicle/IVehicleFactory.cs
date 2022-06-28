using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicle
{
    public interface IVehicleFactory
    {
        void Drive(int miles);
    }
}
