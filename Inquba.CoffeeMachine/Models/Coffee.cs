namespace Inquba.CoffeeMachine.Models
{
    public class Coffee : Beverage
    {
        public Coffee()
        {
            BeanUnits = 2;
            SugarUnits = 0;
            MilkUnits = 0;
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