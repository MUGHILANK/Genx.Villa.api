using System.ComponentModel.DataAnnotations;
public class Room
{
    public Guid Id { get; set; }

    [Required]
    public string RoomNumber { get; set; }

    [Required]
    public string Type { get; set; }

    [Required]
    public int Capacity { get; set; }   

    [Required]
    public decimal PricePerDay { get; set; }
    
    [Required]
    public string Description { get; set; }
    

    public ICollection<Booking> Bookings { get; set; } 
    public ICollection<Customer> Customers { get; set; }
}
