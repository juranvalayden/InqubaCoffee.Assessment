using Inquba.CoffeeMachine.Interfaces;

namespace Inquba.CoffeeMachine.Models
{
    public abstract class Beverage : IBeverage
    {
        public int BeanUnits { get; set; }
        public int SugarUnits { get; set; }
        public int MilkUnits { get; set; }

        public abstract void AddSugar(int sugarUnits);
        public abstract void AddMilk(int milkUnits);
    }
}