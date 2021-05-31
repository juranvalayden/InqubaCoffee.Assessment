namespace Inquba.CoffeeMachine.Models
{
    public class Latte : Beverage
    {
        public Latte()
        {
            BeanUnits = 1;
            SugarUnits = 0;
            MilkUnits = 2;
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