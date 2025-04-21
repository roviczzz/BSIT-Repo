using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ScriptSociety_Client.Models
{
    public class Item
    {

        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }
        public int StockTotal { get; set; }
        public string ImagePath { get; set; }

      
    }
}
