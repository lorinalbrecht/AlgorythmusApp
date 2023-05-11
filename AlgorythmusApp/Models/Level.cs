using System.ComponentModel.DataAnnotations;

namespace AlgorythmusApp.Models
{
    public class Level
    {
        [Key]
        public int LevelId { get; set; }   // Primary Key
        public int Lvl { get; set; }


        // List of Connections
        public ICollection<BuildingInBase> Buildings { get; set; }
        public ICollection<Relation> Relations { get; set; }

    }
}
