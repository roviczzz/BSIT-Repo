using System.ComponentModel.DataAnnotations;

namespace HrPayrollSync.Models;

public class Employee
{
    [Key]
    public int EmployeeId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Department { get; set; }
    public DateTime LastUpdated { get; set; } = DateTime.Now;
    
}