using Microsoft.EntityFrameworkCore;
using MvcBestStore.Models;

namespace MvcBestStore.Services
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
