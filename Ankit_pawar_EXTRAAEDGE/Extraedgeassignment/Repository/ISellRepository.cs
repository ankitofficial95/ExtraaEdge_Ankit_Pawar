using Extraedgeassignment.Model;

namespace Extraedgeassignment.Repository
{
    public interface ISellRepository
    {
        IEnumerable<Sell> GetAllSell();
        Sell GetSellById(int id);
        int AddSell(Sell sell);
        int UpdateSell(Sell sell);
        int DeleteSell(int id);
    }
}
