using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.AbstractProducts;
using AbstractFactory.Products;

namespace AbstractFactory.Factory
{
    public class ElegantClothesFactory : ClothsFactory
    {
        public override Shirt CreateShirt()
        {
            return new DressShirt();
        }

        public override Trousers CreateTrouser()
        {
            return  new ShuitTrouser();
        }
    }
}
