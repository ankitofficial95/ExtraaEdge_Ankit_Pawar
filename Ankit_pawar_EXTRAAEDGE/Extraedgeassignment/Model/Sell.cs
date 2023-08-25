using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extraedgeassignment.Model
{
    [Table("sell")]
    public class Sell
    {
        [Key]
        public int SellId { get; set; }
        public int CustomerId { get; set; }
        public DateTime SellDate { get; set; }
        public int SellPrice { get; set; }
        public int Discount { get; set; }
        public int FinalPrice { get; set; }
        public int MobileId { get; set; }
        public int Quantity { get; set; }
    }
}
