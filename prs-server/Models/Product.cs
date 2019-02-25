using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prs.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public string PartNumber { get; set; }
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Price { get; set; }
        [StringLength(30)]
        [Required]
        public string Unit { get; set; }
        [StringLength(255)]
        public string PhotoPath { get; set; }
        public bool Active { get; set; } = true;

        public Product()
        {

        }
    }
}
