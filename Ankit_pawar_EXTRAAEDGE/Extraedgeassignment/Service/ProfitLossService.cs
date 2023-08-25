using Extraedgeassignment.Model;
using Extraedgeassignment.Repository;

namespace Extraedgeassignment.Service
{
    public class ProfitLossService : IProfitLossService
    {
        private readonly IProfitLossRepository repo;
        public ProfitLossService(IProfitLossRepository repo)
        {
            this.repo = repo;
        }
        public IEnumerable<ProfitLoss> GetProfitLossReport(DateTime fromDate, DateTime toDate)
        {
            return repo.GetProfitLossReport(fromDate,toDate);
        }
    }
}
