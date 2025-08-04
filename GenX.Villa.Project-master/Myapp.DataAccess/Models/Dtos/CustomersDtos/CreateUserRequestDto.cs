using System.ComponentModel.DataAnnotations;

namespace Myapp.DataAccess.Models.Dtos.CustomersDtos
{
    public class CreateUserRequestDto
    {
        public Guid RoomId { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
