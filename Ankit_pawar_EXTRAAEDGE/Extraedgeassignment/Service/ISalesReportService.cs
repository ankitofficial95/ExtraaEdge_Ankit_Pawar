using Extraedgeassignment.Model;

namespace Extraedgeassignment.Service
{
    public interface ISalesReportService
    {
        IEnumerable<SalesReport> GetSalesMonthlyReport(DateTime fromDate, DateTime toDate);
    }
}
