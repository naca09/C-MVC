using Microsoft.EntityFrameworkCore;
using Rolepp.Data.Migrations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rolepp.Models
{
    public class Product
    {
        [Key] // Khóa chính
        public int ProductID { get; set; }

        [Required] // Yêu cầu không được để trống
        public string ProductName { get; set; }

        [Required] // Yêu cầu không được để trống
        public decimal Price { get; set; }

        [Required] // Yêu cầu không được để trống
        public int Quantity { get; set; }

        [Required]
        public string ProductCode { get; set; }

    }

}