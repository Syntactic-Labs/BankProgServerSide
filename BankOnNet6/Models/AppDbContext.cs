using Microsoft.EntityFrameworkCore;

namespace BankOnNet6.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder) { }
    }
}
