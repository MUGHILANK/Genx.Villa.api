namespace Myapp.DataAccess.Interface
{
    public interface IRepository
    {
        Task<Room> CreateRoomAsync(Room room);
        Task<List<Room>> GetAllDataAsync();
        Task<Room> GetByIdAsync(Guid Id);
    }
}
