using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myapp.Core.Models
{
    public class RoomDetail
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public string? Amenities { get; set; }
        public string? Reviews { get; set; }


        public Room? Room { get; set; }
    }
}
