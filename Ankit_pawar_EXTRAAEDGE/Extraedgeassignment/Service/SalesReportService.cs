using Extraedgeassignment.Model;
using Extraedgeassignment.Repository;

namespace Extraedgeassignment.Service
{
    public class SalesReportService : ISalesReportService
    {
        private readonly ISalesReportReository repo;
        public SalesReportService(ISalesReportReository repo)
        {
            this.repo = repo;
        }
        public IEnumerable<SalesReport> GetSalesMonthlyReport(DateTime fromDate, DateTime toDate)
        {
            return repo.GetSalesMonthlyReport(fromDate, toDate);
        }
    }
}
