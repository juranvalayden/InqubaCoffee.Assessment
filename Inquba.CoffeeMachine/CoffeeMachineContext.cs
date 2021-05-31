namespace Inquba.CoffeeMachine
{
    public class CoffeeMachineContext
    {
        private CoffeeMachineState _currentState;

        public CoffeeMachineContext()
        {
            TransitionToState(new OnState());
        }

        public void TransitionToState(CoffeeMachineState coffeeMachineState)
        {
            _currentState = coffeeMachineState;
            _currentState.SwitchOn(this);
        }

        public void SwitchOn()
        {
            _currentState.SwitchOn(this);
        }

        public void SwitchOff()
        {
            _currentState.SwitchOff(this);
        }

        public void SelectBeverage()
        {
            _currentState.SelectBeverage(this);
        }

        public void MakeBeverage()
        {
            _currentState.SelectBeverage(this);
        }

        public  void Refill()
        {
            _currentState.Refill(this);
        }

        public void CompletedSuccessfully()
        {
            _currentState.CompletedSuccessfully(this);
        }

        public void CompletedUnsuccessfully()
        {
            _currentState.CompletedUnsuccessfully(this);
        }
    }
}
