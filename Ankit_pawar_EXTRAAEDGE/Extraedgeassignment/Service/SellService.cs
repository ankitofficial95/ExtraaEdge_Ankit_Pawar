using Extraedgeassignment.Model;
using Extraedgeassignment.Repository;

namespace Extraedgeassignment.Service
{
    public class SellService : ISellService
    {
        private readonly ISellRepository repo;
        public SellService(ISellRepository repo)
        {
            this.repo = repo;
        }
        public int AddSell(Sell sell)
        {
            return repo.AddSell(sell);
        }

        public int DeleteSell(int id)
        {
            return repo.DeleteSell(id);

        }

        public IEnumerable<Sell> GetAllSell()
        {
            return repo.GetAllSell();
        }

        public Sell GetSellById(int id)
        {
            return repo.GetSellById(id);
        }

        public int UpdateSell(Sell sell)
        {
            return repo.UpdateSell(sell);
        }
    }
}

