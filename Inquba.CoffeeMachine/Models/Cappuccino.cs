namespace Inquba.CoffeeMachine.Models
{
    public class Cappuccino : Beverage
    {
        public Cappuccino()
        {
            BeanUnits = 5;
            SugarUnits = 0;
            MilkUnits = 3;
        }

        public override void AddSugar(int sugarUnits)
        {
            SugarUnits = sugarUnits;
        }

        public override void AddMilk(int milkUnits)
        {
            MilkUnits = milkUnits;
        }
    }
}