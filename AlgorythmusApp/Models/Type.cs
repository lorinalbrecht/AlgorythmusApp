﻿using System.ComponentModel.DataAnnotations;

namespace AlgorythmusApp.Models
{
    public class Type
    {
        [Key]
        public int TypeId { get; set; }   // Primary Key
        public string TypeName { get; set; }
        public enum Clan
        {
            Clan1,
            Clan2
        }


        // List of Connections
        public ICollection<BuildingInBase> Buildings { get; set; }
        public ICollection<Relation> Relations { get; set; }
    }
}