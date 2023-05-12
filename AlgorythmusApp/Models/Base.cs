using System.ComponentModel.DataAnnotations;

namespace AlgorythmusApp.Models
{
    public class Base
    {
        [Key]
        public int BaseId { get; set; }   // Primary Key


        // List of all Connections
        public ICollection<BuildingInBase> Buildings { get; set; }
    }
}
