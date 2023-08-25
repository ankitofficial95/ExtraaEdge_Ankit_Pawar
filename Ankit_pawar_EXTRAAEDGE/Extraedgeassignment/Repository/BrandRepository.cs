using Extraedgeassignment.Data;
using Extraedgeassignment.Model;

namespace Extraedgeassignment.Repository
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ApplicationDbContext db;
        public BrandRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddBrand(Brand brand)
        {
            int result = 0;
            db.Brands.Add(brand);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteBrand(int id)
        {
            int result = 0;

            var brand = db.Brands.Where(x => x.BrandId == id).FirstOrDefault();
            if (brand != null)
            {
                db.Brands.Remove(brand);
                result = db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Brand> GetAllBrand()
        {
            return db.Brands.ToList();
        }

        public Brand GetBrandById(int id)
        {
            return db.Brands.Where(x => x.BrandId == id).FirstOrDefault();
        }

        public int UpdateBrand(Brand brand)
        {
            int result = 0;

            var b = db.Brands.Where(x => x.BrandId == brand.BrandId).FirstOrDefault();
            if (b != null)
            {
                b.BrandName =brand.BrandName;
                b.BrandDescription = brand.BrandDescription;
               
                result = db.SaveChanges();
            }
            return result;
        }
    }
}
