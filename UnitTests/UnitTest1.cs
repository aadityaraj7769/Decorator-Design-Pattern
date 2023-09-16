using Microsoft.VisualStudio.TestTools.UnitTesting;
using DecoratorDesignPattern;
using DecoratorDesignPattern.Decorator;
using DecoratorDesignPattern.Color;
using DecoratorDesignPattern.CarDecorator_;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1

    {
        [TestMethod]
        public void TestMethod1()
        {
            // Creating an object of black car
            BlackCar blackCarObj = new();
            int price = blackCarObj.PriceOfCar();
            string car_ = blackCarObj.NameOfCar();

            Console.WriteLine(car_);
            Console.WriteLine(price);

            Assert.AreEqual("Black Car", car_);
            Assert.AreEqual(100000, price);

            //Decorate the black car with air bag 
            CarDecorator carWithAirBag = new AirBag(blackCarObj);

            int airPrice = carWithAirBag.PriceOfCar();
            car_ = carWithAirBag.NameOfCar();

            Console.WriteLine(car_);
            Console.WriteLine(airPrice);

            Assert.AreEqual("Black Car With Air Bag ", car_);
            Assert.AreEqual(110000, airPrice);

            //Again decorate with air conditioner
            CarDecorator carWithAirBagAirCondition = new AirConditioner(carWithAirBag);

            int airCondBag = carWithAirBagAirCondition.PriceOfCar();
            car_ = carWithAirBagAirCondition.NameOfCar();

            Console.WriteLine(car_);
            Console.WriteLine(airCondBag);

            Assert.AreEqual("Black Car With Air Bag  With Air Conditioner ", car_);
            Assert.AreEqual(140000, airCondBag);

            //-------
            CarDecorator carBagACLeather = new LeatherSeat(carWithAirBagAirCondition);
            int bagACLeather = carBagACLeather.PriceOfCar();
            car_ = carBagACLeather.NameOfCar();
            Console.WriteLine(car_);
            Console.WriteLine(bagACLeather);

            Assert.AreEqual("Black Car With Air Bag  With Air Conditioner  With Leather Seat ", car_);
            Assert.AreEqual(180000, bagACLeather);

        }
        
    }
}
