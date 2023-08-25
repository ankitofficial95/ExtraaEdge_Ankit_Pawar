using Extraedgeassignment.Model;
using Extraedgeassignment.Repository;

namespace Extraedgeassignment.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository repo;
        public CustomerService(ICustomerRepository repo)
        {
            this.repo = repo;
        }
        public int AddCustomer(Customer cust)
        {
            return repo.AddCustomer(cust);
        }

        public int DeleteCustomer(int id)
        {
            return repo.DeleteCustomer(id);
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return repo.GetAllCustomer();
        }

        public Customer GetCustomerById(int id)
        {
            return repo.GetCustomerById(id);
        }

        public int UpdateCustomer(Customer cust)
        {
            return repo.UpdateCustomer(cust);
        }
    }
}
