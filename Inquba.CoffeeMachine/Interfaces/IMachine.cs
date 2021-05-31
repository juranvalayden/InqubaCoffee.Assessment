namespace Inquba.CoffeeMachine.Interfaces
{
    public interface IMachine
    {
        void SwitchOn();
        void SwitchOff();
        void SelectBeverage();
        void MakeBeverage(IBeverage beverage);
        void Refill();
    }
}
