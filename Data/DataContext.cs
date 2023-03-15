using BankAppAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace BankAppAPI.Data
{
    
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
        }
        public  DbSet<Account> Accounts { get; set; }
        public DbSet<ProccesHistry> ProccesHistrys { get; set;}

        public DbSet<User> Users { get; set; }
    }
}
