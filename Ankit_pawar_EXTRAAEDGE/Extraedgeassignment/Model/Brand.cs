using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extraedgeassignment.Model
{
    [Table("Brand")]
    public class Brand
    {
        [Key]
        
        public int BrandId { get; set; }
        [Required]
        public string? BrandName { get; set; }
        [Required]
        public string? BrandDescription { get; set; }
    }
}
