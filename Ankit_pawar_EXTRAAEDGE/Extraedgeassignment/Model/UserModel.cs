using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extraedgeassignment.Model
{
   // [Table("user2")]
    public class UserModel
    {
        [Key]
       public int userId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
       // public string EmailAddress { get; set; }

    }
}
