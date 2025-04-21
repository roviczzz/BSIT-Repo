namespace UniversityGradingSystem.Models
{
    public class GradesInfo
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public decimal MidtermGrade { get; set; }
        public decimal FinalGrade { get; set; }
        public decimal SemesterGrade => (MidtermGrade + FinalGrade) / 2;
    }
}
