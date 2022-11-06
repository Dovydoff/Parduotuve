
using Parduotuve.CandiesRepository;
using Parduotuve.Entities;
using Parduotuve.Repositories;

namespace Parduotuve
{
    internal class Menu
    {
        public void InitiateMenu()
        {
            bool isAlive = true;
            while (isAlive)
            {
                Console.WriteLine("1. Print Candies list");
                Console.WriteLine("2. Print Drinks list");
                Console.WriteLine("3. Print Meats list");
                Console.WriteLine("4. Print Vegetables list");
                Console.WriteLine("5. Buy Meat");

                Console.WriteLine("8. Print your cart list");

                Console.WriteLine("9. Exit");
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
                        Console.WriteLine("\n " + "-------------------END OF LIST-------------------" +"\n");

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

                    case 8:
                        ShoppingCart.PrintCart();
                        break;
                    case 9:
                        isAlive = false;
                        break;
                }
            }
        }

        public void BuyMeat ()
        {
            var selectedMeat = GetSelection();
            var meat = MeatRepository.Meats[selectedMeat -1];
            if(meat == null)
            {
                Console.WriteLine($"Meat with index {selectedMeat - 1} doesn`t exist");
                return;
            }
            ShoppingCart.AddGroceries(meat.ToString());
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
            foreach(Vegetable vegetables in VegetableRepository.Vegetables)
            {
                Console.WriteLine(vegetables);
            }
        }

        public int GetSelection()
        {
            bool isSuccess = Int32.TryParse(Console.ReadLine(), out int result);
            if(isSuccess)
            {
                return result;
            }
            Console.WriteLine("Try enter number from the list");
            return 0;
        }
    }
}
