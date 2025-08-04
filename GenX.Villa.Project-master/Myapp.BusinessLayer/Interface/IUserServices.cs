using Myapp.DataAccess.Models.Dtos.CustomersDtos;

namespace Myapp.BusinessLayer.Interface
{
    public interface IUserServices
    {
        Task<UserResponseDto>createUserAsync(CreateUserRequestDto requestDto);
        Task<List<GetAllCustomerDto>> getAllAsync();
        Task<UserResponseDto> getByIdAsync(Guid id);

    }
}
