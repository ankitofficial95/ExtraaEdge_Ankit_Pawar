using Extraedgeassignment.Data;
using Extraedgeassignment.Model;

namespace Extraedgeassignment.Repository
{
    public class SellRepository : ISellRepository
    {
        private readonly ApplicationDbContext db;
        public SellRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddSell(Sell sell)
        {
            int result = 0;
            db.Sales.Add(sell);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteSell(int id)
        {
            int result = 0;

            var cust = db.Sales.Where(x => x.SellId == id).FirstOrDefault();
            if (cust != null)
            {
                db.Sales.Remove(cust);
                result = db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Sell> GetAllSell()
        {
            return db.Sales.ToList();
        }

        public Sell GetSellById(int id)
        {
            var cust = db.Sales.Where(x => x.SellId == id).FirstOrDefault();
            return cust;
        }

        public int UpdateSell(Sell sell)
        {
            int result = 0;

            var c = db.Sales.Where(x => x.SellId == sell.SellId).FirstOrDefault();
            if (c != null)
            {
                c.SellPrice = sell.SellPrice;
                c.FinalPrice=sell.FinalPrice;
                c.Discount = sell.Discount;
                c.FinalPrice = sell.FinalPrice;
                c.CustomerId = sell.CustomerId;
                c.SellDate = sell.SellDate;
                c.Quantity = sell.Quantity;

                result = db.SaveChanges();
            }
            return result;
        }
    }
}
