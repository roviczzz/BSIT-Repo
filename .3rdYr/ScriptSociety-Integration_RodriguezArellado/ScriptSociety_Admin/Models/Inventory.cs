using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ScriptSociety_Admin.Models
{
    public class Inventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        [StringLength(30)]
        public string? Type { get; set; }

        [Required]
        [StringLength(30)]
        public string? Color { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        [StringLength(10)]
        public string? Size { get; set; }

        [Required]
        public int StockTotal { get; set; }

        [Required]
        public string? ImagePath { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
    }
}
