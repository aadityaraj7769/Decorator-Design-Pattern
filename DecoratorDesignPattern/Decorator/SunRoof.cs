using DecoratorDesignPattern.CarDecorator_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Decorator
{
    public class SunRoof : CarDecorator_.CarDecorator
    {
        public SunRoof(IBaseCar baseCar) : base(baseCar) { }

        public override string NameOfCar()
        {
            return baseCar.NameOfCar() + " With Sun Roof ";
        }
        public override int PriceOfCar()
        {
            return baseCar.PriceOfCar() + SunRoofPrice();
        }

        private int SunRoofPrice() { return 100000; }
    }
}
