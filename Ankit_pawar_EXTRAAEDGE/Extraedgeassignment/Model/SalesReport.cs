using System.ComponentModel.DataAnnotations;

namespace Extraedgeassignment.Model
{
    public class SalesReport
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        [DataType(DataType.Date)]
        public DateTime FromDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime ToDate { get; set; }
        //public int MobileId { get; set; }
        public string MobileName { get; set; }
        public string Description { get; set; }
        public int MobilePrice { get; set; }
     

    }
}
