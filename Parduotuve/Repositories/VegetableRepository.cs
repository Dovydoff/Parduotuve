﻿using Parduotuve.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parduotuve.Repositories
{
    internal class VegetableRepository
    {
        private CsvService Service = new CsvService();
        public static List<Vegetable> Vegetables { get; set; }

        public VegetableRepository()
        {
            Vegetables = Service.ReadVegetables();
        }

    }
}

