using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlgorythmusApp.Models
{
    public class BuildingInBase
    {
        [Key]
        public int BuildingInBaseId { get; set; }   // Primary Key

        public string[,] Field = { { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9" },
                                   { "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9" },
                                   { "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9" },
                                   { "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9" },
                                   { "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9" },
                                   { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9" },
                                   { "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8", "G9" },
                                   { "H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9" } };
        public string PositionX { get; set; }
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
    }
}
