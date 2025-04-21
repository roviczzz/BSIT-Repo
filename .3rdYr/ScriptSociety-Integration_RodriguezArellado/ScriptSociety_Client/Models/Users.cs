using System.ComponentModel.DataAnnotations;

namespace ScriptSociety_Client.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int ContactNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string AccountRole { get; set; } = "User";
    }
}
