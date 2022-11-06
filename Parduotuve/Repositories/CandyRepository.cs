using Parduotuve.Entities;


namespace Parduotuve.CandiesRepository
{
    internal class CandyRepository
    {
        private CsvService Service = new CsvService();
        public static List<Candy> Candies { get; set; }
        
        public CandyRepository()
        {
            Candies = Service.ReadCandies();
        }

    }
}
