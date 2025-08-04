using Myapp.BusinessLayer.Interface;
using AutoMapper;
using Myapp.DataAccess.Interface;
using Myapp.DataAccess.Models.Dtos.AdminDtos;

namespace Myapp.BusinessLayer.Services
{
    public class HotelManagementAdmin : IHotelManagement
    {
        private readonly IMapper _mapper;
        private readonly IRepository _repository;

        public HotelManagementAdmin(IMapper mapper,IRepository repository)
        {
            this._mapper = mapper;
            this._repository = repository;
        }
        
        public async Task<CreateResponseDto> CreateRoomAsync(RoomRequestDto requestDto)
        {
            if (requestDto == null)
            {
                throw new ArgumentNullException(nameof(requestDto), "Request DTO cannot be null");
            }

            var entity = _mapper.Map<Room>(requestDto);
            var createdRoom = await _repository.CreateRoomAsync(entity);  

            return _mapper.Map<CreateResponseDto>(createdRoom);          
        }

        public async Task<List<GetAllresponseDto>> GetAllAsync()
        {

            var GetallData = await _repository.GetAllDataAsync();

            


            return _mapper.Map<List<GetAllresponseDto>>(GetallData);


        }

        public async Task<GetAllresponseDto> GetByIdAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            var ResponseData = _mapper.Map<GetAllresponseDto>(entity);

            return ResponseData;
        }

    }
}
