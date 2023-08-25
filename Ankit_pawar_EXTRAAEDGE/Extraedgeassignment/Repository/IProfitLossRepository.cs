using Extraedgeassignment.Model;

namespace Extraedgeassignment.Repository
{
    public interface IProfitLossRepository
    {
        IEnumerable<ProfitLoss> GetProfitLossReport(DateTime fromDate, DateTime toDate);
    }
}
