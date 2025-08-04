using AutoMapper;
using Myapp.DataAccess.Models.Dtos.AdminDtos;
using Myapp.DataAccess.Models.Dtos.Booking;
using Myapp.DataAccess.Models.Dtos.CustomersDtos;
using Myapp.DataAccess.Models.Dtos.Payment;

namespace Myapp.BusinessLayer.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RoomRequestDto, Room>();
            CreateMap<Room, CreateResponseDto>();
            CreateMap<Room, GetAllresponseDto>();

            CreateMap<Customer, CreateUserRequestDto>();
            CreateMap<CreateUserRequestDto, Customer>();

            CreateMap<Customer, UserResponseDto>();
            CreateMap<UserResponseDto, Customer>();
            CreateMap<Customer, GetAllCustomerDto>().ReverseMap();

            CreateMap<Booking , CreateBookingDto>();
            CreateMap<CreateBookingDto, Booking>();

            CreateMap<Booking, BookingResponse>();
            CreateMap<BookingResponse, Booking>();

            CreateMap<Payment, PaymentDto>().ReverseMap();
            CreateMap<Payment,PaymentResponse>().ReverseMap();
        }
    }
}
