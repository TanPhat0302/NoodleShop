using BookApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace BookApplication.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet <PhoOrder> PhoOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
    }
}
