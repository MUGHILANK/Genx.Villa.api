using AutoMapper;
using Microsoft.VisualBasic;
using Myapp.BusinessLayer.Interface;
using Myapp.DataAccess.Interface;
using Myapp.DataAccess.Models.Dtos.Booking;
using Myapp.DataAccess.Models.Dtos.Payment;

namespace Myapp.BusinessLayer.Services
{
    public class BookingServices : IBookingServices
    {
        private readonly IMapper _mapper;
        private readonly IBookingRepository _repository;

        public BookingServices(IMapper mapper, IBookingRepository repository)
        {
            this._mapper = mapper;
            this._repository = repository;
        }
        public async Task<BookingResponse> CreateBookingDetailsAsync(CreateBookingDto bookingDto)
        {
            var CheckRoomavilable = await _repository.CheckRoomStatus(bookingDto.RoomId);
            if (!CheckRoomavilable)
            {
                var entity = _mapper.Map<Booking>(bookingDto);

                Console.WriteLine($"Data : {entity}");

                var GetRepo = await _repository.CreateBookerAsync(entity);
                return _mapper.Map<BookingResponse>(GetRepo);
            }
            return null;
        }

        public async Task<PaymentResponse> paymentStatusAsync(PaymentDto paymentDto)
        {
            var entity = _mapper.Map<Payment>(paymentDto);
            var getRepo = await _repository.paymentStatusAsync(entity);
            var paymentresponse = _mapper.Map<PaymentResponse>(getRepo);

            return paymentresponse;
        }
    }
}
