using System.ComponentModel.DataAnnotations;

namespace chit_chat_be.Models
{
   public class Token
   {
      [Key]
      [Required]
      [MaxLength(36)]
      public string Username { get; set; }

      [Required]
      [MaxLength(511)]
      public string TokenString { get; set; }

      [Required]
      public DateTime ExpirationTime { get; set; }

      // Foreign relationship:
      public virtual User User { get; set; }
   }
}