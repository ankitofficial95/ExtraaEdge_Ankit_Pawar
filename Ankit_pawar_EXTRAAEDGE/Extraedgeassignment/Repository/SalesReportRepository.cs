using Extraedgeassignment.Data;
using Extraedgeassignment.Model;

namespace Extraedgeassignment.Repository
{
    public class SalesReportRepository : ISalesReportReository
    {
        private readonly ApplicationDbContext _db;
        public SalesReportRepository(ApplicationDbContext _db)
        {
            this._db = _db;
        }
        public IEnumerable<SalesReport> GetSalesMonthlyReport(DateTime fromDate, DateTime toDate)
        {
            var result=(from b in _db.Brands
                       join m in _db.Mobiles on b.BrandId equals m.BrandId
                       join s in _db.Sales on m.MobileId equals s.MobileId  
                       where s.SellDate >= fromDate && s.SellDate <= toDate
                       orderby b.BrandName
                       select new SalesReport
                       {
                           BrandId=b.BrandId,
                            BrandName=b.BrandName,
                            MobileName=m.Model,
                            MobilePrice=m.MobilePrice,
                            Description=m.MobileDescription
                       }).ToList();
            return result;
        }
    }
}
