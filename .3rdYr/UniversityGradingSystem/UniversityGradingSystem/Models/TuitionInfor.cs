namespace UniversityGradingSystem.Models
{
    public class TuitionInfor
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public decimal TuitionFee { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal Balance => TuitionFee - PaidAmount;
    }
}
