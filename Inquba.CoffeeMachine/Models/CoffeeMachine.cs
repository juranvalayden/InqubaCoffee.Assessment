using System;
using Inquba.CoffeeMachine.Interfaces;

namespace Inquba.CoffeeMachine.Models
{
    public class CoffeeMachine : IMachine
    {
        public int Beans { get; set; }
        public int Milk { get; set; }

        public CoffeeMachine()
        {
        }

        public void Refill()
        {
            Beans = 25;
            Milk = 20;
        }

        public void SwitchOn()
        {
         
        }

        public void SwitchOff()
        {
         
        }

        public void SelectBeverage()
        {

        }

        public void MakeBeverage(IBeverage beverage)
        {
            Beans -= beverage.BeanUnits;
            Milk -= beverage.MilkUnits;

            if (Beans <= 5)
            {
                Console.WriteLine("Low bean capacity");
            }
        }
    }
}