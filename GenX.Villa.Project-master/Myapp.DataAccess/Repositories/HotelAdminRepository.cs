using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Myapp.DataAccess.HotelDbContext;
using Myapp.DataAccess.Interface;

namespace Myapp.DataAccess.Repositories
{
    public class HotelAdminRepository : IRepository
    {
        private readonly HotelAdminDbContext _dbContext;

        public HotelAdminRepository(HotelAdminDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<Room> CreateRoomAsync(Room room)
        {
            try
            {
                await _dbContext.Rooms.AddAsync(room);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return room;
        }

        public async Task<List<Room>> GetAllDataAsync()
        {
            var nonBookedRooms = await _dbContext.Rooms.Where(room => !_dbContext.Bookings.Any(booking => booking.RoomId == room.Id))
                .ToListAsync();

            return nonBookedRooms;

        }

        public async Task<Room> GetByIdAsync(Guid Id)
        {
            var FindData = await _dbContext.Rooms.FirstOrDefaultAsync(e => e.Id == Id);

            return FindData;
        }
    }
}
