using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.AbstractProducts;

namespace AbstractFactory.Factory
{
    public abstract class ClothsFactory
    {
        public abstract Shirt CreateShirt();
        public abstract Trousers CreateTrouser();
    }
}
