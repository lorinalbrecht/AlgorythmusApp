using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlgorythmusApp.Models
{
    public class Relation
    {
        [Key]
        public int RelationId { get; set; }   // Primary Key

        public int Production { get; set; }
        public int CostPower { get; set; }
        public int CostTiberium { get; set; }

        public int FkLevel { get; set; }    // Foreign Key Level
        public int FkType { get; set; }     // Foreign Key Type


        // Foreign Key for Level
        [ForeignKey("FkLevel")]
        public Level Level { get; set; }

        // Foreign Key for Type
        [ForeignKey("FkType")]
        public Type Type { get; set; }
    }
}
