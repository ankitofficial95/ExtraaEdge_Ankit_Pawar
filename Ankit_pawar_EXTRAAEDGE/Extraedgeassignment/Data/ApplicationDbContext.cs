using Extraedgeassignment.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Extraedgeassignment.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Mobile> Mobiles { get; set; }
        public DbSet<Sell> Sales { get; set; }
        //public DbSet<LoginOutput> LoginOutputs { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}
