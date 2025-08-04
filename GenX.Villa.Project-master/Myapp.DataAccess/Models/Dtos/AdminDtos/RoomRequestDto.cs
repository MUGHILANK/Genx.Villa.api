namespace Myapp.DataAccess.Models.Dtos.AdminDtos
{
    public class RoomRequestDto
    {
        public string RoomNumber { get; set; }
        public string Type { get; set; } 
        public int Capacity { get; set; }
        public decimal PricePerDay { get; set; }
        public string Description { get; set; }

    }
}
