using Microsoft.EntityFrameworkCore;

namespace chit_chat_be.Data
{
   public class ApplicationDbContext : DbContext
   {
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
      {
      }

      // Define your DbSets here
      // public DbSet<YourEntity> YourEntities { get; set; }
   }
}