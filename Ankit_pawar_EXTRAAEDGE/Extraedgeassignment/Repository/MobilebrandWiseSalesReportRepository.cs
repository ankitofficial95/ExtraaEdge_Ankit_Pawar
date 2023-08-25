using Extraedgeassignment.Data;
using Extraedgeassignment.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Extraedgeassignment.Repository
{
    public class MobilebrandWiseSalesReportRepository : IMobilebrandWiseSalesReportRepository
    {
        private readonly ApplicationDbContext db;
        public MobilebrandWiseSalesReportRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<BrandWiseMobile> MobilebrandWiseSalesReport(DateTime fromDate, DateTime toDate)
        {
            /* var result = (from b in db.Brands
                           join m in db.Mobiles on b.BrandId equals m.BrandId
             join s in db.Sales on m.MobileId equals s.MobileId
                           where b.BrandId==id
                           orderby b.BrandName
                           select new SalesReport
                           {
                               BrandId = b.BrandId,
                               BrandName = b.BrandName,
                               MobileName = m.Model,
                               MobilePrice = m.MobilePrice,
                               Description = m.MobileDescription
                           }).ToList();
             return result;*/

            /* var count = from a in db.Brands
                        group a by a.BrandId into gp
                        select gp;*/


 /*           var groupByLastNamesQuery =
    from student in students
    group student by student.LastName into newGroup
    orderby newGroup.Key
    select newGroup;*/

            var result = (from b in db.Brands
                          join m in db.Mobiles on b.BrandId equals m.BrandId
                          join s in db.Sales on m.MobileId  equals s.MobileId
                          where s.SellDate >= fromDate && s.SellDate <= toDate




                          select new BrandWiseMobile
                          {

                              BrandName = b.BrandName,
                              BrandId = b.BrandId,
                              Quantity = s.Quantity
                              // mobileId=x.FirstOrDefault(a=>a.BrandId==m)

                          }).ToList();

            var r = (from x in result
                     group x by x.BrandId into aa
                     select new BrandWiseMobile
                     {
                        BrandId=aa.FirstOrDefault().BrandId,
                         BrandName = aa.FirstOrDefault().BrandName,
                         Quantity = aa.Sum(p => (int)p.Quantity)
                     }).ToList();
            
            return r;
        }
    }
}
