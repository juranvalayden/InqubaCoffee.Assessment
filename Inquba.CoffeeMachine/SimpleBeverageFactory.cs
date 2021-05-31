using Inquba.CoffeeMachine.Interfaces;
using Inquba.CoffeeMachine.Models;
using Unity;

namespace Inquba.CoffeeMachine
{
    public static class SimpleBeverageFactory
    {
        private static UnityContainer _container;

        public static IBeverage CreateBeverage(string beverageType)
        {
            if (_container != null)
            {
                return _container.Resolve<IBeverage>(beverageType);
            }

            _container = new UnityContainer();

            _container.RegisterType<IBeverage, Coffee>("coffee");
            _container.RegisterType<IBeverage, Latte>("latte");
            _container.RegisterType<IBeverage, Cappuccino>("cappuccino");

            return _container.Resolve<IBeverage>(beverageType);
        }
    }
}
