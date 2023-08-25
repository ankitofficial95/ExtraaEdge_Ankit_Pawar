using Extraedgeassignment.Model;

namespace Extraedgeassignment.Service
{
    public interface IMobileBrandWiseSalesReportService
    {
        IEnumerable<BrandWiseMobile> MobilebrandWiseSalesReport(DateTime fromDate, DateTime toDate);
    }
}
