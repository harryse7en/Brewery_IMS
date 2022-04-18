
namespace Brewery_IMS.Classes {
    public class Equipment {
        // ---------- Variables ----------
        public int ID { get; set; }
        public bool Status { get; set; } // False = Available, True = In Use
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
    }
}
