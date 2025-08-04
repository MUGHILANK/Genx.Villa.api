using System.ComponentModel.DataAnnotations;

namespace Myapp.DataAccess.Models.Dtos.Booking
{
    public class CreateBookingDto
    {
        public Guid RoomId { get; set; }

        
        public Guid CustomerId { get; set; }

        
        public DateTime FromDate { get; set; }

        
        public DateTime ToDate { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }
    }
}
