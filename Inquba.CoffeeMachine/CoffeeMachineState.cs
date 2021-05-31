namespace Inquba.CoffeeMachine
{
    public abstract class CoffeeMachineState
    {
        public abstract void SwitchOn(CoffeeMachineContext coffeeMachineContext);
        public abstract void SwitchOff(CoffeeMachineContext coffeeMachineContext);
        public abstract void SelectBeverage(CoffeeMachineContext coffeeMachineContext);
        public abstract void MakeBeverage(CoffeeMachineContext coffeeMachineContext);
        public abstract void Refill(CoffeeMachineContext coffeeMachineContext);
        public abstract void CompletedSuccessfully(CoffeeMachineContext coffeeMachineContext);
        public abstract void CompletedUnsuccessfully(CoffeeMachineContext coffeeMachineContext);
    }
}