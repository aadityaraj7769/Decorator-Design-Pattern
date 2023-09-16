using DecoratorDesignPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Color
{
    public class BlackCar : IBaseCar
    {
        public string NameOfCar()
        {
            return "Black Car";
        }
        public int PriceOfCar()
        {
            return 100000;
        }
    }
}
