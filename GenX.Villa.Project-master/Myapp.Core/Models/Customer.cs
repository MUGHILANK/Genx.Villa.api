using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myapp.DataAccess.Models
{
    public class Customer
    {
        public Guid Id { get; set; }

        public string FullName {  get; set; }
        public string EmialAddress { get; set; }
        public long MobileNumber { get; set; }



        public ICollection<Booking>? Bookings { get; set; }

    }
}
