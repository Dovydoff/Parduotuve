
using Parduotuve.CandiesRepository;
using Parduotuve.Entities;
using Parduotuve.Repositories;

namespace Parduotuve
{
    internal class Menu
    {
        int totalAmountOfMoney;
        public void InitiateMenu()
        {
            Console.WriteLine("Please enter amount of money you have:");
            string money = Console.ReadLine();

            bool success = int.TryParse(money, out totalAmountOfMoney);
            while (!success)
            {
                Console.WriteLine("Invalid input. Try again...");
                Console.Write("Please enter money amount");
                money = Console.ReadLine();
                success = int.TryParse(money, out totalAmountOfMoney);
            }
            Console.WriteLine($"You have {totalAmountOfMoney} $ to spend Good Luck");
            Console.WriteLine("\n" + "Press Enter to continue");

            Console.ReadLine();


            bool isAlive = true;
            while (isAlive)
            {
                Console.WriteLine("1. Print Candies list");
                Console.WriteLine("2. Print Drinks list");
                Console.WriteLine("3. Print Meats list");
                Console.WriteLine("4. Print Vegetables list");
                Console.WriteLine("5. Buy Meat");
                Console.WriteLine("6. Buy Candies");
                Console.WriteLine("7. Buy Drinks");
                Console.WriteLine("8. Buy Vegetables");
                Console.WriteLine("9. Print your cart list");
                Console.WriteLine("10. Exit");
                var input = GetSelection();
                switch (input)
                {
                    case 0:
                        continue;
                    case 1:

                        PrintCandies();
                        Console.WriteLine("\n " + "-------------------END OF LIST-------------------" + "\n");
                        break;
                    case 2:
                        PrintDrinks();
                        Console.WriteLine("\n " + "-------------------END OF LIST-------------------" + "\n");

                        break;
                    case 3:
                        PrintMeats();
                        Console.WriteLine("\n " + "-------------------END OF LIST-------------------" + "\n");

                        break;
                    case 4:
                        PrintVegetables();
                        Console.WriteLine("\n " + "-------------------END OF LIST-------------------" + "\n");

                        break;
                    case 5:
                        BuyMeat();
                        break;
                    case 6:
                        BuyCandies();
                        break;
                    case 7:
                        BuyDrinks();
                        break;
                    case 8:
                        BuyVegetables();
                        break;
                    case 9:
                        ShoppingCart.PrintCart();
                        break;
                    case 10:
                        isAlive = false;
                        break;
                }
            }
        }

        public void BuyMeat()
        {
            var selectedMeat = GetSelection();
            var meat = MeatRepository.Meats[selectedMeat - 1];
            if (meat == null || totalAmountOfMoney < 0 || meat.Price > totalAmountOfMoney)
            {
                Console.WriteLine($"Meat with index {selectedMeat - 1} doesn`t exist");
                return;
            }
            else
            {
                ShoppingCart.AddGroceries(meat.ToString());
                decimal leftMoney = totalAmountOfMoney - meat.Price;
                Console.WriteLine("You have selected: " + meat.ToString());
                Console.WriteLine($"You have left {leftMoney} $ left");
                decimal leftMoney1 = leftMoney;
                totalAmountOfMoney = (int)leftMoney1;
            
            }
        }

        public void BuyDrinks()
        {
            {
                var selectedDrink = GetSelection();
                var drink = DrinksRepository.Drinks[selectedDrink - 1];
                if (drink == null || totalAmountOfMoney < 0 || drink.Price > totalAmountOfMoney)
                {
                    Console.WriteLine($"Drink with index {selectedDrink - 1} doesn`t exist");
                    return;
                }
                else
                {
                    ShoppingCart.AddGroceries(drink.ToString());
                    decimal leftMoney = totalAmountOfMoney - drink.Price;
                    Console.WriteLine("You have selected: "+ drink.ToString());
                    Console.WriteLine($"You have left {leftMoney} $left");
                    decimal leftMoney1 = leftMoney;
                    totalAmountOfMoney = (int)leftMoney1;
                }
            }
        }

        public void BuyCandies()
        {
            {
                var selectedCandy = GetSelection();
                var candy = CandyRepository.Candies[selectedCandy - 1];
                if (candy == null || totalAmountOfMoney < 0 || candy.Price > totalAmountOfMoney)
                {
                    Console.WriteLine($"Candy with index {selectedCandy - 1} doesn`t exist");
                    return;
                }
                else
                {
                    ShoppingCart.AddGroceries(candy.ToString());
                    decimal leftMoney = totalAmountOfMoney - candy.Price;
                    Console.WriteLine("You have selected: " + candy.ToString());
                    Console.WriteLine($"You have left {leftMoney} $left");
                    decimal leftMoney1 = leftMoney;
                    totalAmountOfMoney = (int)leftMoney1;
                }
            }
        }

        public void BuyVegetables()
        {
            {
                var selectedVegetable = GetSelection();
                var vegetable = VegetableRepository.Vegetables[selectedVegetable - 1];
                if (vegetable == null || totalAmountOfMoney < 0 || vegetable.Price > totalAmountOfMoney)
                {
                    Console.WriteLine($"Vegetables with index {selectedVegetable - 1} doesn`t exist");
                    return;
                }
                else
                {
                    ShoppingCart.AddGroceries(vegetable.ToString());
                    decimal leftMoney = totalAmountOfMoney - vegetable.Price;
                    Console.WriteLine("You have selected: " + vegetable.ToString());
                    Console.WriteLine($"You have left {leftMoney} $left");
                    decimal leftMoney1 = leftMoney;
                    totalAmountOfMoney = (int)leftMoney1;
                }
            }
        }
        public void PrintCandies()
        {
            foreach (Candy candies in CandyRepository.Candies)
            {
                Console.WriteLine(candies);
            }
        }
        public void PrintDrinks()
        {
            foreach (Drink drinks in DrinksRepository.Drinks)
            {
                Console.WriteLine(drinks);
            }
        }

        public void PrintMeats()
        {
            foreach (Meat meats in MeatRepository.Meats)
            {
                Console.WriteLine(meats);
            }
        }
        public void PrintVegetables()
        {
            foreach (Vegetable vegetables in VegetableRepository.Vegetables)
            {
                Console.WriteLine(vegetables);
            }
        }

        public int GetSelection()
        {
            bool isSuccess = Int32.TryParse(Console.ReadLine(), out int result);
            if (isSuccess)
            {
                return result;
            }
            Console.WriteLine("Try enter number from the list");
            return 0;
        }



    }
}