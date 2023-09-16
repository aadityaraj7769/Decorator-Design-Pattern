using DecoratorDesignPattern.CarDecorator_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Decorator
{
    public class LeatherSeat : CarDecorator_.CarDecorator
    {
        public LeatherSeat(IBaseCar baseCar) : base(baseCar) { }

        public override string NameOfCar()
        {
            return baseCar.NameOfCar() + " With Leather Seat ";
        }
        public override int PriceOfCar()
        {
            return baseCar.PriceOfCar() + LeatherSeatPrice();
        }

        private int LeatherSeatPrice() { return 40000; }
    }
}
