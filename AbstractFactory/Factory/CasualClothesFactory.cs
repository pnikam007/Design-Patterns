using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.AbstractProducts;
using AbstractFactory.Products;

namespace AbstractFactory.Factory
{
    class CasualClothesFactory : ClothsFactory
    {
        public override Shirt CreateShirt()
        {
            return new PoloShirt();
        }

        public override Trousers CreateTrouser()
        {
            return new JeansTrouser();
        }
    }
}
