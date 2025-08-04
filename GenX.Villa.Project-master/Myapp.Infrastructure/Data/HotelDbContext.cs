using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Myapp.

namespace Myapp.Infrastructure.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> dbContext) : base(dbContext) { }

        public DbSet<Room> Rooms{get;set;}

    }
}
