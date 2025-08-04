using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Payment
{
    public Guid Id { get; set; }

    [Required]
    public Guid BookingId { get; set; }

    [Required]
    public decimal TotalAmount { get; set; }

    [Required]
    [DefaultValue("Pending")]
    public string PaymentStatus { get; set; } 

    public Booking Booking { get; set; }
}
