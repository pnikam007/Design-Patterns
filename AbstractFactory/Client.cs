using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.AbstractProducts;
using AbstractFactory.Factory;

namespace AbstractFactory
{
    public class Client
    {
        private readonly Shirt _shirt;
        private readonly Trousers _trouser;

        public Client(ClothsFactory factory)
        {
            _shirt = factory.CreateShirt();
            _trouser = factory.CreateTrouser();
        }


        public string GetDressed()
        {
            return $"Today I'm dressed in: {_shirt.GetType().Name} and {_trouser.GetType().Name}";
        }
    }
}
