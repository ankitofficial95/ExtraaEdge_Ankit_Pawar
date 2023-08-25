using Extraedgeassignment.Model;

namespace Extraedgeassignment.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomer();
        Customer GetCustomerById(int id);
        int AddCustomer(Customer cust);
        int UpdateCustomer(Customer cust);
        int DeleteCustomer(int id);
    }
}
