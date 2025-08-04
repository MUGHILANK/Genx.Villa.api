using Myapp.DataAccess.Models.Dtos.Booking;
using Myapp.DataAccess.Models.Dtos.Payment;

namespace Myapp.BusinessLayer.Interface
{
    public interface IBookingServices
    {
        Task<BookingResponse> CreateBookingDetailsAsync(CreateBookingDto bookingDto);
        Task<PaymentResponse> paymentStatusAsync(PaymentDto payment);
    }
}
