using Parduotuve.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parduotuve.Repositories
{
    internal class MeatRepository
    {
        private CsvService Service = new CsvService();
        public static List<Meat> Meats { get; set; }

        public MeatRepository()
        {
            Meats = Service.ReadMeat();
        }
    }
}
