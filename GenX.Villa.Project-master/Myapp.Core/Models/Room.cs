using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myapp.Core.Models
{
    public class Room
    {
        public Guid Id { get; set; }
        public string RoomNumber { get; set; }
        public string Type { get; set; }
        public int Person {  get; set; }
        public decimal Price { get; set; }



        public RoomDetail? RoomDetail { get; set; }
        public ICollection<Booking>? Bookings { get; set; }

    }
}
