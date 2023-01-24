using System.ComponentModel.DataAnnotations.Schema;

namespace WebPanel.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal Preis { get; set; }

        public string Category { get; set; }


    }
}
