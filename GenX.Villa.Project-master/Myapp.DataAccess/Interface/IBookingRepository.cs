using Myapp.DataAccess.Models.Dtos.Booking;

namespace Myapp.DataAccess.Interface
{
    public interface IBookingRepository 
    {
        Task<Booking> CreateBookerAsync(Booking entity);
        Task<Payment> paymentStatusAsync(Payment payment);
        Task<bool> CheckRoomStatus(Guid id);


    }
}
