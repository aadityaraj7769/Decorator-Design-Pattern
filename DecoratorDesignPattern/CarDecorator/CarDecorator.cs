using DecoratorDesignPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.CarDecorator_
{
    public abstract class CarDecorator : IBaseCar
    {
        protected IBaseCar baseCar;

        public CarDecorator(IBaseCar baseCar)
        {
            this.baseCar = baseCar;
        }

        public virtual int PriceOfCar()
        {
            return baseCar.PriceOfCar();
        }
        public virtual string NameOfCar()
        {
            return baseCar.NameOfCar();
        }
    }
}
