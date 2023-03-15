using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAppAPI.Models
{
    public class ProccesHistry
    {
        
        public int Id { get; set; }

        public DateTime prhist { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }
       
        

        public string Prtype { get; set; }

        public int pramount { get; set; }
}
}
