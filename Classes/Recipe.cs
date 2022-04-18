
namespace Brewery_IMS.Classes {
    public class Recipe {
        // ---------- Variables ----------
        public int ID { get; set; }  // ID used for unique database record
        public int Days { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
}
