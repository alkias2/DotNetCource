using Microsoft.EntityFrameworkCore;

namespace SpentSmart.Data
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app) {
            StoreDbContext context = app.ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any()) {
                context.Database.Migrate();
            }
        }
    }
}