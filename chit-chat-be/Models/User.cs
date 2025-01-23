using System.ComponentModel.DataAnnotations;

namespace chit_chat_be.Models
{
   public class User
   {
      [Key]
      [Required]
      [MaxLength(36)]
      public string Username { get; set; }

      [Required]
      [MaxLength(50)]
      public string Password { get; set; }

      [Required]
      [MaxLength(100)]
      public string FirstName { get; set; }

      [Required]
      [MaxLength(100)]
      public string LastName { get; set; }

      [Required]
      public DateOnly JoinDate { get; set; }

      public string ProfilePicture { get; set; }

      // Foreign relationship:
      public virtual ICollection<Token> Tokens { get; set; }
   }
}