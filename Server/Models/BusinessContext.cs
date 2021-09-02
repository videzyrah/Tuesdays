using Microsoft.EntityFrameworkCore;
using Tuesdays.Shared;
namespace Tuesdays.Server.Models {
    public class BusinessContext : DbContext {
        public BusinessContext (DbContextOptions<BusinessContext> options) : base (options) { }
        public DbSet<Business> Businesses{ get; set; }
    }
}