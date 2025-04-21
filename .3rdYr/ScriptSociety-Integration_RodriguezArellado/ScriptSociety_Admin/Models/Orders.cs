using System.ComponentModel.DataAnnotations;

namespace ScriptSociety_Admin.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string Items { get; set; } // get items
        public int TotalPrice { get; set; }
        public string CustomerName { get; set; } //get customer fname lname combined
        public string CustomerAddress { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerContact { get; set; }
        public string PaymentMethod { get; set; }
    }
}
