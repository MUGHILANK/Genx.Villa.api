namespace Myapp.DataAccess.Interface
{
    public interface IUserRepository
    {
        Task<Customer> createUserRepoAsync(Customer customer);
        Task<List<Customer>> getAllCustomerAsync();
        Task<Customer> getByIdAsync(Guid id);
    }
}
