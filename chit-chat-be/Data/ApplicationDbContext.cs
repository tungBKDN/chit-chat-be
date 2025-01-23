using chit_chat_be.Models;
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
      public DbSet<User> Users { get; set; }
      public DbSet<Token> Tokens { get; set; }
   }
}