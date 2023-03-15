using System.ComponentModel.DataAnnotations;

namespace BankAppAPI.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        public string Hname { get; set; }


        public long hamount { get; set; }
    }
}
