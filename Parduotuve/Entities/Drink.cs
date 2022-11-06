namespace Parduotuve.Entities
{
    internal class Drink : Groceries
    {
        public double Liters { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} costs: ${Price}, Barcode: {Barcode}, Weight: {Weight} gr., Liters: {Liters}";
        }
    }
}
