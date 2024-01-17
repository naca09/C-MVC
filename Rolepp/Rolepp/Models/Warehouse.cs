using System.ComponentModel.DataAnnotations;

namespace Rolepp.Models
{
    public class Warehouse
    {
        [Key]
        public int WarehouseID { get; set; }

        [Required]
        [StringLength(50)]
        public string WarehouseName { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        // Navigation property for related Products
        //public virtual ICollection<Product> Products { get; set; }
    }
}
