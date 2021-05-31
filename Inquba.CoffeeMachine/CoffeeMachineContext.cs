using System;

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
            _currentState.On(this);
        }

        public void ShowState(string stateName)
        {
            Console.WriteLine(stateName);
        }

        public void On()
        {
            _currentState.On(this);
        }

        public void BeverageReady()
        {
            _currentState.BeverageReady(this);
        }

        public void InUse()
        {
            _currentState.InUse(this);
        }

        public void Full()
        {
            _currentState.Full(this);
        }

        public void Empty()
        {
            _currentState.Empty(this);
        }

        public void Off()
        {
            _currentState.Off(this);
        }
    }
}
