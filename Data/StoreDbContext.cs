using Microsoft.EntityFrameworkCore;
using SpentSmart.Models;

namespace SpentSmart.Data {
    public class StoreDbContext: DbContext {
        public StoreDbContext(
            DbContextOptions<StoreDbContext> options
        ) : base(options) { }

        public DbSet<Expense> Customer => Set<Expense>();
    }
}
