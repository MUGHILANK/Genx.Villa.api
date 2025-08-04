using Myapp.DataAccess.Interface;
using Myapp.DataAccess.HotelDbContext;
using Myapp.DataAccess.Models.Dtos.Booking;
using Microsoft.EntityFrameworkCore;

namespace Myapp.DataAccess.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly HotelAdminDbContext _dbContext;
        //private bool _disposed;

        public BookingRepository(HotelAdminDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<Booking> CreateBookerAsync(Booking entity)
        {
            try
            {
                await _dbContext.Bookings.AddAsync(entity);
                await _dbContext.SaveChangesAsync();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return entity;
        }

        public async Task<Payment> paymentStatusAsync(Payment payment)
        {
            try
            {
                await _dbContext.Payments.AddAsync(payment);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return payment;
        }

        public async Task<bool> CheckRoomStatus(Guid id)
        {
            var returnData = await _dbContext.Bookings.AnyAsync(e=>e.RoomId == id);
            return returnData;
        }
    }
}
