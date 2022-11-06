using Parduotuve;
using Parduotuve.CandiesRepository;
using Parduotuve.Repositories;

public class Program
{
    public static void Main(string[] args)
    {
        
        
        Console.WriteLine("Please Enter your budget:");

        var candyRepository = new CandyRepository();
        var drinkRepository = new DrinksRepository();
        var meatRepository = new MeatRepository();
        var vegetableRepository = new VegetableRepository();
        var menu = new Menu();
        menu.BuyMeat();
        menu.InitiateMenu();


    }
}