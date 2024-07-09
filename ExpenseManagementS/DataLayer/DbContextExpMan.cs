using ExpenseManagementS.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseManagementS.DataLayer
{
    public class DbContextExpMan : DbContext
    {
        public DbContextExpMan(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ExpenseEntity> Expenses { get; set; }
    }
}
