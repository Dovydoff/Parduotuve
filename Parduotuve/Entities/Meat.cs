namespace Parduotuve.Entities
{
    internal class Meat :Groceries
    {
        public double Protein { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} costs: ${Price}, Barcode: {Barcode}, Weight: {Weight} gr., Protein: {Protein} gr.";
        }
    }
}
