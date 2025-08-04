using System.ComponentModel.DataAnnotations;

public class Booking
{
    public Guid Id { get; set; }

    [Required]
    public Guid RoomId { get; set; }

    [Required]
    public Guid CustomerId { get; set; }

    [Required]
    public DateTime FromDate { get; set; }

    [Required]
    public DateTime ToDate { get; set; }

    [Required]
    public decimal TotalPrice { get; set; }


    public Room Room { get; set; }
    public Customer Customer { get; set; }
    public Payment Payment { get; set; }
}
