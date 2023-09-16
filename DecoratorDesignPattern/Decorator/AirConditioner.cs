using DecoratorDesignPattern.CarDecorator_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Decorator
{
    public class AirConditioner : CarDecorator_.CarDecorator
    {
        public AirConditioner(IBaseCar baseCar) : base(baseCar) { }

        public override string NameOfCar()
        {
            return baseCar.NameOfCar() + " With Air Conditioner ";
        }
        public override int PriceOfCar()
        {
            return baseCar.PriceOfCar() + AirConditionerPrice();
        }

        private int AirConditionerPrice() { return 30000; }


    }
}
