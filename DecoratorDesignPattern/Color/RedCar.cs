using DecoratorDesignPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Color
{
    internal class RedCar : IBaseCar
    {
        public string NameOfCar()
        {
            return "Red Car";
        }
        public int PriceOfCar()
        {
            return 200000;
        }
    }
}
