using Myapp.DataAccess.Models.Dtos.AdminDtos;

namespace Myapp.BusinessLayer.Interface
{
    public interface IHotelManagement
    {
        Task<CreateResponseDto> CreateRoomAsync(RoomRequestDto requestDto);
        Task<List<GetAllresponseDto>> GetAllAsync();
        Task<GetAllresponseDto> GetByIdAsync(Guid id);
    }
}
