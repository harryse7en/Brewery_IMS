using System;

namespace Brewery_IMS.Classes {
    public class Batch {
        // ---------- Variables ----------
        public int ID { get; set; } // ID used for unique database record
        public int RecipeID { get; set; }
        public int Sequence { get; set; }
        /* Sequence Values:
         *     Created    = 0
         *     Ready      = 1
         *     Mashing    = 2
         *     Fermenting = 3
         *     Racking    = 4
         *     Cleaning   = 5
         *     Finished   = 6
         *     Archived   = 7  */
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RecipeName { get; set; }
        public string SequenceText { get; set; }
    }
}
