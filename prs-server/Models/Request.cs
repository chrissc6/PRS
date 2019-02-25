using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prs.Models
{
    public class Request
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual IList<RequestLine> RequestLines { get; set; }
        [StringLength(80)]
        public string Description { get; set; }
        [StringLength(80)]
        public string Justification { get; set; }
        [StringLength(80)]
        public string RejectionReason { get; set; }
        [StringLength(30)]
        public string DeliveryMode { get; set; }
        public DateTime? ReviewDate { get; set; }
        [StringLength(10)]
        public string Status { get; set; }
        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Total { get; set; }
        public bool Active { get; set; } = true;

        public Request()
        {

        }
    }
}
