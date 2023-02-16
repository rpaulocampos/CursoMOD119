﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoMOD119.Models
{
    public class Item
    {
        public int ID { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; } = "";

        [Display(Name = "Price")]
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        [Display(Name = "CreationDate")]
        public DateTime CreationDate { get; set; }
        [Display(Name = "Discontinued")]
        public bool Discontinued { get; set; }
    }
}
