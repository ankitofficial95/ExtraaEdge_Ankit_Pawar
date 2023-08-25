using Extraedgeassignment.Model;

namespace Extraedgeassignment.Repository
{
    public interface IMobilebrandWiseSalesReportRepository
    {
        IEnumerable<BrandWiseMobile> MobilebrandWiseSalesReport(DateTime fromDate, DateTime toDate);
    }
}
