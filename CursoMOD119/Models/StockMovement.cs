using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoMOD119.Models
{
    public class StockMovement
    {
        public int ID { get; set; }

        [Display(Name = "Type")]
        // True => Entrada de stock, False => Saída de stock
        public bool Type { get; set; }

        [Display(Name = "Amount")]
        // Movement Quantity
        public int Amount { get; set; }

        [Display(Name = "MovementDate")]
        // Date of Movement
        public DateTime MovementDate { get; set; }

        [Display(Name = "Item")]
        public int ItemID { get; set; }
        [Display(Name = "Item")]
        public Item? Item { get; set; }
    }
}
