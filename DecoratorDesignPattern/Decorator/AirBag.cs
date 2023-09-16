using DecoratorDesignPattern.CarDecorator_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Decorator
{
    public class AirBag : CarDecorator_.CarDecorator
    {
        public AirBag(IBaseCar baseCar) : base(baseCar) { }

        public override string NameOfCar()
        {
            return baseCar.NameOfCar() + " With Air Bag ";
        }
        public override int PriceOfCar()
        {
            return baseCar.PriceOfCar() + AirBagPrice();
        }

        private int AirBagPrice() { return 10000; }
    }
}
