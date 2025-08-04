namespace Myapp.DataAccess.Models.Dtos.CustomersDtos
{
    public class UserResponseDto
    {
        public Guid Id { get; set; }
        public Guid RoomId { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

    }
}
