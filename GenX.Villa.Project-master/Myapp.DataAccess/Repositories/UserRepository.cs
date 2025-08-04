using Microsoft.EntityFrameworkCore;
using Myapp.DataAccess.HotelDbContext;
using Myapp.DataAccess.Interface;

namespace Myapp.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly HotelAdminDbContext _dbContext;

        public UserRepository(HotelAdminDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<Customer> createUserRepoAsync(Customer customer)
        {
            try
            {
                await _dbContext.Customers.AddAsync(customer);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return customer;
        }

        public async Task<List<Customer>> getAllCustomerAsync()
        {
            var allCustomerDetails =  await _dbContext.Customers.ToListAsync();
            return allCustomerDetails;
        }

        public Task<Customer> getByIdAsync(Guid id)
        {
            var customerDetail = _dbContext.Customers.FirstOrDefaultAsync(c=>c.Id == id);
            return customerDetail;
        }
    }
}
