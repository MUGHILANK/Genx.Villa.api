using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Myapp.DataAccess.Models.Dtos.Payment
{
    public class PaymentDto
    {
        public Guid BookingId { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        [DefaultValue("Pending")]
        public string PaymentStatus { get; set; }
    }
}
