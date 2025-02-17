using System.ComponentModel.DataAnnotations;

namespace HrPayrollSync.Models;

public class Payroll
{
    [Key]
    public int EmployeeId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public decimal Salary { get; set; }
    public DateTime LastUpdated { get; set; } = DateTime.Now;
}