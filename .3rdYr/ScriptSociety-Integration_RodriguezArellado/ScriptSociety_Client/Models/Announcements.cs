using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ScriptSociety_Client.Models
{
    public class Announcements
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnnouncementId { get; set; }

        [Required]
        [ForeignKey("Inventory")]
        public int ProductId { get; set; }

        [Required]
        [StringLength(200)]
        public string? Series { get; set; }

        [Required]
        [StringLength(200)]
        public string? Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [Required]
        public string? Status { get; set; }
    }
}
