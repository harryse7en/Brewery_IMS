
namespace Brewery_IMS.Classes {
    public abstract class Ingredient {
        // ---------- Variables ----------
        public int ID { get; set; } // ID used for unique database record
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public string Unit { get; set; }
        public string Type { get; set; }
        public decimal Stock { get; set; }
    }
}
