using MaquetadoPemex.Models;
using Microsoft.EntityFrameworkCore;

namespace gastosBlazorMaui.Data
{
    public class SpendsDataContext : DbContext
    {
        public SpendsDataContext(DbContextOptions<SpendsDataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; } 
    }
}
