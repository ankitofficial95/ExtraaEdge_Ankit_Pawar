using Extraedgeassignment.Data;
using Extraedgeassignment.Model;

namespace Extraedgeassignment.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext db;
        public CustomerRepository(ApplicationDbContext db)
        {
            this.db = db; 
        }
        public int AddCustomer(Customer cust)
        {
            int result = 0;
            db.Customers.Add(cust);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteCustomer(int id)
        {
            int result = 0;

            var cust= db.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
            if (cust != null)
            {
                db.Customers.Remove(cust);
                result = db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return db.Customers.ToList(); 
        }

        public Customer GetCustomerById(int id)
        {
            var cust = db.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
            return cust;
        }

        public int UpdateCustomer(Customer cust)
        {
            int result = 0;

            var c = db.Customers.Where(x => x.CustomerId == cust.CustomerId).FirstOrDefault();
            if (c != null)
            {
                c.CustomerName = cust.CustomerName;
                c.CustomerAdress = cust.CustomerAdress;

                result = db.SaveChanges();
            }
            return result;
        }
    }
}
