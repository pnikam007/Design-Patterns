using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPizza pizza = new Pizza();
            //IPizza cheesDecorator = new CheesDecorator(pizza);
            //IPizza tomatoDecorator = new TomatoDecorator(cheesDecorator);
            //IPizza onionDecorator = new OnionDecorator(tomatoDecorator);
            //Console.WriteLine(onionDecorator.GetPizzaType());
                     
            IPizza result = new CheesDecorator(new TomatoDecorator(new OnionDecorator(new Pizza())));
            Console.WriteLine(result.GetPizzaType());
            Console.ReadKey();
        }
    }

    // Base Component
    public interface IPizza
    {
        string GetPizzaType();
    }

    // Concrete Component
    public class Pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "This is normal Pizza";
        }
    }

    // Base decorator --> implemented from -  Base Component
    public class PizzaDecorator : IPizza
    {
        private IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string GetPizzaType()
        {
            return _pizza.GetPizzaType();
        }
    }

    // Concrete decorator(s)
    public class CheesDecorator : PizzaDecorator
    {
        public CheesDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetPizzaType()
        {
            string type =  base.GetPizzaType();
            type += "\r\r\n With extra Cheese...";
            return type;
        }
    }

    public class TomatoDecorator : PizzaDecorator
    {
        public TomatoDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\r\n With extra Tomato...";
            return type;
        }
    }

    public class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\r\n With extra Onion...";
            return type;
        }
    }
}
