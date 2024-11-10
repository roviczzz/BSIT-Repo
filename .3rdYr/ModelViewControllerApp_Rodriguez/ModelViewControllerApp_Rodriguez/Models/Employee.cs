namespace ModelViewControllerApp_Rodriguez.Models
{
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string City { get; set; }
        public decimal DailyRate { get; set; }
        public int DaysWorked { get; set; }

        public decimal CalculateTotalEarnings()
        {
            decimal baseEarnings = DailyRate * DaysWorked;
            if (DaysWorked == 6)
            {
                baseEarnings += 500; // Incentive
            }
            return baseEarnings;
        }
    }
}
