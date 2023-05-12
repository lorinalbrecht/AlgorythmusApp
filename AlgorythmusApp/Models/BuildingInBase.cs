using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlgorythmusApp.Models
{
    public class BuildingInBase
    {
        [Key]
        public int BuildingInBaseId { get; set; }   // Primary Key

        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public int FkBase { get; set; }     // Foreign Key Base
        public int FkLevel { get; set; }    // Foreign Key Level
        public int FkType { get; set; }     // Foreign Key Type


        // Foreign Key for Base
        [ForeignKey("FkBase")]
        public Base Base { get; set; }

        // Foreign Key for Level
        [ForeignKey("FkLevel")]
        public Level Level { get; set; }

        // Foreign Key for Type
        [ForeignKey("FkType")]
        public Type Type { get; set; }


        // Constructor
        public BuildingInBase(int Id, int X, int Y, int Base, int Level, int Type)
        {
            BuildingInBaseId = Id;
            PositionX = X;
            PositionY = Y;
            FkBase = Base;
            FkLevel = Level;
            FkType = Type;
        }
    }
}
