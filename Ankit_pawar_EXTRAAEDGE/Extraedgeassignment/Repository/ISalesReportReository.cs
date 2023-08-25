using Extraedgeassignment.Model;

namespace Extraedgeassignment.Repository
{
    public interface ISalesReportReository
    {
        IEnumerable<SalesReport> GetSalesMonthlyReport(DateTime fromDate, DateTime toDate);
    }
}
