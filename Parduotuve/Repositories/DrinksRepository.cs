using Parduotuve.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parduotuve.Repositories
{
    internal class DrinksRepository
    {

        private CsvService Service = new CsvService();
        public static List <Drink> Drinks { get; set; }

        public DrinksRepository()
        {
            Drinks = Service.ReadDrinks();
        }


    }
}
