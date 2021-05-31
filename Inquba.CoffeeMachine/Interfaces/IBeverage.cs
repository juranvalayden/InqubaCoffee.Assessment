namespace Inquba.CoffeeMachine.Interfaces
{
    public interface IBeverage
    {
        int BeanUnits { get; set; }
        int SugarUnits { get; set; }
        int MilkUnits { get; set; }

        void AddSugar(int sugarUnits);
        void AddMilk(int milkUnits);
    }
}