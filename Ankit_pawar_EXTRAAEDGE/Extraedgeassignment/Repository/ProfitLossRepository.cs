using Extraedgeassignment.Data;
using Extraedgeassignment.Model;

namespace Extraedgeassignment.Repository
{
    
    public class ProfitLossRepository : IProfitLossRepository
    {
        private readonly ApplicationDbContext db;
        public ProfitLossRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<ProfitLoss> GetProfitLossReport(DateTime fromDate, DateTime toDate)
        {
            /* var count = from a in db.Brands
                         group a by a.BrandId into gp
                         select gp;*/
            
            var totalQuantity = db.Sales.Sum(s => s.Quantity);

            var result = (from b in db.Brands
                          join m in db.Mobiles on b.BrandId equals m.BrandId
                          join s in db.Sales on m.MobileId equals s.MobileId
                          where s.SellDate >= fromDate && s.SellDate <= toDate
                          select new ProfitLoss
                          {

                              ActualPrice = m.MobilePrice,
                              SalePrice = s.SellPrice,
                              Discount = s.Discount

                          }).ToList();

            foreach (var item in result)
            {
                if (item.ActualPrice > item.SalePrice)
                {
                    item.Loss += (item.ActualPrice - item.SalePrice);
                }
                else if (item.ActualPrice < item.SalePrice)
                {
                    item.Profit += (item.SalePrice - item.ActualPrice);
                }
                item.Quantity = totalQuantity;
            }


            return result;


        }
    }
}
