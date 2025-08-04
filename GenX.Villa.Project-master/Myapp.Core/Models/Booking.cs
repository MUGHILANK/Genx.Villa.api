using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myapp.Core.Models
{
    public class Booking
    {
        public Guid Id { get; set; }

        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public string BookingStatus { get; set; }

        public Customer? Customer { get; set; }
        public Room? Room {  get; set; }

    }
}
