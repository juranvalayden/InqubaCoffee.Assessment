using System;
using System.Collections.Generic;
using Inquba.CoffeeMachine.Interfaces;

namespace Inquba.CoffeeMachine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // get from a db or some source
            var currentBeverages = new List<string> {"coffee", "cappuccino", "latte"};
            var userInput = string.Empty;
            var coffeeMachineContext = new CoffeeMachineContext();

            while (userInput != "off")
            {
                Console.WriteLine("Enter the type of beverage that you would like: \"Coffee\", \"Cappuccino\" or a \"Latte\"");
                userInput = Console.ReadLine();

                if (userInput == "off")
                {
                    break;
                }

                if (currentBeverages.Contains(userInput) && !string.IsNullOrWhiteSpace(userInput))
                {
                    var beverage = SimpleBeverageFactory.CreateBeverage(userInput);

                    Console.WriteLine("How many units of sugar would you like?");
                    var sugarUnits = Convert.ToInt16(Console.ReadLine());
                    beverage.SugarUnits = sugarUnits;

                    // if coffee
                    if (userInput == "coffee")
                    {
                        Console.WriteLine("Would you like milk - \"Y\" or \"N\"?");
                        var wantsMilk = Convert.ToChar(Console.ReadLine());
                        if (wantsMilk == 'y')
                        {
                            beverage.MilkUnits = 1;
                        }
                    }

                    IMachine machine = new Models.CoffeeMachine();
                }
                else
                {
                    Console.WriteLine("Unkown beverage entered! Current beverage selections are : \"Coffee\", \"Cappuccino\" or a \"Latte\"");
                }
            }
        }
    }
}
