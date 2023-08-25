using Extraedgeassignment.Model;

namespace Extraedgeassignment.Service
{
    public interface IProfitLossService
    {
        IEnumerable<ProfitLoss> GetProfitLossReport(DateTime fromDate, DateTime toDate);
    }
}
