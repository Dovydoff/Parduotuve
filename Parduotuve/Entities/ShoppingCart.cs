using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parduotuve.Entities
{
    internal class ShoppingCart
    {
        private static List<string> Groceries = new();

        public static void AddGroceries(string grocery)
        {
            Groceries.Add(grocery);
        }
        public static void PrintCart()
        {
            foreach (var grocery in Groceries)
            {
                Console.WriteLine(grocery);
            }
        }
    }
}

    
   /* public void CheckBudget(double credit)
    {
            var menu = new Menu();
            menu.InitiateMenu();

            if (credit == 0)
        {
            Console.WriteLine("Your credit is 0, you can see product list only");

            bool userInputIsValid = true;

            while (!userInputIsValid)
            {
                Console.WriteLine("Do you want to see product list? (Y/N)");
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case ("Y"):
                        userInputIsValid = false;
                        menu.InitiateMenu();
                        break;
                    case ("N"):
                        userInputIsValid = false;
                        menu.InitiateMenu();

                        break;
                    default:
                        Console.WriteLine("Option not available");
                        break;

                }

            }
        }
    }*/

