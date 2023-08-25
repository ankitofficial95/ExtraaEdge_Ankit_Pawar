using Extraedgeassignment.Model;

namespace Extraedgeassignment.Service
{
    public interface IBrandService
    {
        IEnumerable<Brand> GetAllBrand();
        int AddBrand(Brand brand);
        Brand GetBrandById(int id);
        int UpdateBrand(Brand brand);
        int DeleteBrand(int id);
    }
}
