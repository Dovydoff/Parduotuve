namespace Parduotuve.Entities
{
    internal class Candy : Groceries
    {
        public double Sugar { get; set; }


        public override string ToString()
        {
            return $"Name: {Name} costs: ${Price}, Barcode: {Barcode}, Weight: {Weight} gr., Sugar: {Sugar} gr.";
        }

    }


}
