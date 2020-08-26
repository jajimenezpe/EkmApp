using Microsoft.EntityFrameworkCore;
using EkmApp.Models;

namespace EkmApp.Data
{
    public class EkmAppContext : DbContext
    {
        public EkmAppContext(DbContextOptions<EkmAppContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Member> Member { get; set; }
    }
}