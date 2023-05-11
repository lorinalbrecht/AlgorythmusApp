using System.ComponentModel.DataAnnotations;

namespace AlgorythmusApp.Models
{
    public class Base
    {
        [Key]
        public int BaseId { get; set; }   // Primary Key

        public int TiberiumCounter { get; set; }
        public int PowerCounter { get; set; }
        public int BuildingCounter { get; set; }
        public int BuildingMaximum { get; set; }


        // List of all Connections
        public ICollection<BuildingInBase> Buildings { get; set; }
    }
}
