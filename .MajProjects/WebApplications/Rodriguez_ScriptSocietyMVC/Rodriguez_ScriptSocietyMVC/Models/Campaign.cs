using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rodriguez_ScriptSocietyMVC.Models
{

    public class Campaign
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CampaignId { get; set; }

        [Required]
        [ForeignKey("Inventory")]
        public int ProductId { get; set; }

        public Inventory? Inventory { get; set; }

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
