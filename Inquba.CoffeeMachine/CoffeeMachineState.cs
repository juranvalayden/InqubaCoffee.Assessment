namespace Inquba.CoffeeMachine
{
    public abstract class CoffeeMachineState
    {
        public abstract void EnterState(CoffeeMachineContext coffeeMachineContext);
        public abstract void On(CoffeeMachineContext coffeeMachineContext);
        public abstract void Off(CoffeeMachineContext coffeeMachineContext);
        public abstract void Full(CoffeeMachineContext coffeeMachineContext);
        public abstract void Empty(CoffeeMachineContext coffeeMachineContext);
        public abstract void InUse(CoffeeMachineContext coffeeMachineContext);
        public abstract void BeverageReady(CoffeeMachineContext coffeeMachineContext);
    }
}