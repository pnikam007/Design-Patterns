﻿using FactoryMethod.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.VehicleFactory
{
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IVehicleFactory GetVehicle(string Vehicle)
        {
            switch (Vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
            }
        }
    }
}
