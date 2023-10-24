using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PageCreator.Models
{
    public class Users
    {
        
        public Users(string Email, string Password) 
        { 
            this.Email = Email;
            this.Password = Password;
            CreatedAt = DateTime.UtcNow;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [EmailAddress]
        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password {get; set; }

        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
    }
}
