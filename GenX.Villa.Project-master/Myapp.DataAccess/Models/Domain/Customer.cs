using System.ComponentModel.DataAnnotations;

public class Customer
{
    public Guid Id { get; set; }

    public Guid RoomId { get; set; }
    
    [Required]
    public string FullName { get; set; }

    [Required]
    [DataType(DataType.EmailAddress)]
    public string EmailAddress { get; set; }

    [Required]
    [DataType(DataType.PhoneNumber)]
    public string PhoneNumber { get; set; }
    

    //public ICollection<Room> Rooms { get; set; }
    public ICollection<Booking> Bookings { get; set; }
    public Room Room { get; set; }
    

}
