namespace Parduotuve.Entities
{
    internal class Vegetable : Groceries
    {
        public double Fiber { get; set; }
        public override string ToString()
        {
            return $"Name: {Name} costs: ${Price}, Barcode: {Barcode}, Weight: {Weight} gr., Fiber: {Fiber} gr.";
        }
    }
}
