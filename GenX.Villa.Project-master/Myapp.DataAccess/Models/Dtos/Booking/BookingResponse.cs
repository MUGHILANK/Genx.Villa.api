namespace Myapp.DataAccess.Models.Dtos.Booking
{
    public class BookingResponse
    {
        public Guid Id { get; set; }
        public Guid RoomId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
