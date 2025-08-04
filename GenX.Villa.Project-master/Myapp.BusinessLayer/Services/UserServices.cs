using AutoMapper;
using Myapp.BusinessLayer.Interface;
using Myapp.DataAccess.Interface;
using Myapp.DataAccess.Models.Dtos.CustomersDtos;

namespace Myapp.BusinessLayer.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserServices(IUserRepository repository,IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        public async Task<UserResponseDto> createUserAsync(CreateUserRequestDto requestDto)
        {
            if (requestDto == null)
            {
                throw new ArgumentNullException(nameof(requestDto));
            }

            var entity =  _mapper.Map<Customer>(requestDto);
            var getFromRepository = await _repository.createUserRepoAsync(entity);
            var User = _mapper.Map<UserResponseDto>(getFromRepository);

            return User;
        }

        public async Task<List<GetAllCustomerDto>> getAllAsync()
        {
            var allCustomer = await _repository.getAllCustomerAsync();

            return _mapper.Map<List<GetAllCustomerDto>>(allCustomer);
        }

        public async Task<UserResponseDto> getByIdAsync(Guid id)
        {
            var customerData = await _repository.getByIdAsync(id);
            if(customerData == null)
            {
                return null;
            }
            var entity = _mapper.Map<UserResponseDto>(customerData);

            return entity;
        }
    }
}
