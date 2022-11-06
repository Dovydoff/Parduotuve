using Parduotuve.Entities;
using System;

namespace Parduotuve
{
    internal class CsvService
    {
        private string CandiesPath = "C:\\Users\\dell\\Desktop\\Code Academy\\C#\\11 Paskaitas savarankiska uzduotis\\Savarankiška uzduotis\\Parduotuve\\Parduotuve\\Services\\Data\\Candies.csv";
        private string MeatPath = "C:\\Users\\dell\\Desktop\\Code Academy\\C#\\11 Paskaitas savarankiska uzduotis\\Savarankiška uzduotis\\Parduotuve\\Parduotuve\\Services\\Data\\Meat.csv";
        private string DrinksPath = "C:\\Users\\dell\\Desktop\\Code Academy\\C#\\11 Paskaitas savarankiska uzduotis\\Savarankiška uzduotis\\Parduotuve\\Parduotuve\\Services\\Data\\Drinks.csv";
        private string VegetablesPath = "C:\\Users\\dell\\Desktop\\Code Academy\\C#\\11 Paskaitas savarankiska uzduotis\\Savarankiška uzduotis\\Parduotuve\\Parduotuve\\Services\\Data\\Vegetable.csv";
        public List<Candy> ReadCandies()
        {

            string text = File.ReadAllText(CandiesPath);
            string[] line = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            var candies = new List<Candy>();

            for (int i = 1; i < line.Length; i++)
            {
                string[] groceriesArray = line[i].Split(',');
                var candy = new Candy
                {
                    Name = groceriesArray[0],
                    Price = Convert.ToDecimal(groceriesArray[1]),
                    Barcode = groceriesArray[2],
                    Weight = Convert.ToDecimal(groceriesArray[3]),
                    Sugar = Convert.ToDouble(groceriesArray[4])

                };
                candies.Add(candy);
            }

            return candies;
        }

        public List<Meat> ReadMeat()
        {

            string text = File.ReadAllText(MeatPath);
            string[] line = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            var meat = new List<Meat>();

            for (int i = 1; i < line.Length; i++)
            {
                string[] groceriesArray = line[i].Split(',');
                var meats = new Meat
                {
                    Name = groceriesArray[0],
                    Price = Convert.ToDecimal(groceriesArray[1]),
                    Barcode = groceriesArray[2],
                    Weight = Convert.ToDecimal(groceriesArray[3]),
                    Protein = Convert.ToDouble(groceriesArray[4])

                };
                meat.Add(meats);
            }
            return meat;
        }
        public List<Drink> ReadDrinks()
        {

            string text = File.ReadAllText(DrinksPath);
            string[] line = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            var drink = new List<Drink>();

            for (int i = 1; i < line.Length; i++)
            {
                string[] groceriesArray = line[i].Split(',');
                var drinks = new Drink
                {
                    Name = groceriesArray[0],
                    Price = Convert.ToDecimal(groceriesArray[1]),
                    Barcode = groceriesArray[2],
                    Weight = Convert.ToDecimal(groceriesArray[3]),
                    Liters = Convert.ToDouble(groceriesArray[4])

                };
                drink.Add(drinks);
            }
            return drink;
        }
        public List<Vegetable> ReadVegetables()
        {

            string text = File.ReadAllText(VegetablesPath);
            string[] line = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            var vegetable = new List<Vegetable>();

            for (int i = 1; i < line.Length; i++)
            {
                string[] groceriesArray = line[i].Split(',');
                var vegetables = new Vegetable
                {
                    Name = groceriesArray[0],
                    Price = Convert.ToDecimal(groceriesArray[1]),
                    Barcode = groceriesArray[2],
                    Weight = Convert.ToDecimal(groceriesArray[3]),
                    Fiber = Convert.ToDouble(groceriesArray[4])

                };
                vegetable.Add(vegetables);
            }
            return vegetable;
        }
    } 
}
