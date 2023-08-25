using Extraedgeassignment.Model;

namespace Extraedgeassignment.Service
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomer();
        Customer GetCustomerById(int id);
        int AddCustomer(Customer cust);
        int UpdateCustomer(Customer cust);
        int DeleteCustomer(int id);
    }
}
