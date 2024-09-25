namespace Rodriguez_GradeCalculator.Models
{
    public class Grade
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string CYS { get; set; }

        private decimal subject1Grade;
        private decimal subject2Grade;
        private decimal subject3Grade;
        private decimal subject4Grade;
        private decimal subject5Grade;
        private decimal subject6Grade;

        public decimal Subject1Grade
        {
            get { return subject1Grade; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(Subject1Grade), "Grade must be between 0 and 100.");
                subject1Grade = value;
            }
        }

        public decimal Subject2Grade
        {
            get { return subject2Grade; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(Subject2Grade), "Grade must be between 0 and 100.");
                subject2Grade = value;
            }
        }

        public decimal Subject3Grade
        {
            get { return subject3Grade; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(Subject3Grade), "Grade must be between 0 and 100.");
                subject3Grade = value;
            }
        }

        public decimal Subject4Grade
        {
            get { return subject4Grade; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(Subject4Grade), "Grade must be between 0 and 100.");
                subject4Grade = value;
            }
        }

        public decimal Subject5Grade
        {
            get { return subject5Grade; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(Subject5Grade), "Grade must be between 0 and 100.");
                subject5Grade = value;
            }
        }

        public decimal Subject6Grade
        {
            get { return subject6Grade; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(Subject6Grade), "Grade must be between 0 and 100.");
                subject6Grade = value;
            }
        }

        public decimal ComputeAverage()
        {
            decimal averageGrade = (Subject1Grade + Subject2Grade + Subject3Grade + Subject4Grade + Subject5Grade + Subject6Grade) / 6;
            return averageGrade;
        }

        public string GetRemark(decimal averageGrade)
        {
            if (averageGrade >= 98)
                return "4.00";
            else if (averageGrade >= 95)
                return "3.75";
            else if (averageGrade >= 92)
                return "3.50";
            else if (averageGrade >= 89)
                return "3.25";
            else if (averageGrade >= 86)
                return "3.00";
            else if (averageGrade >= 83)
                return "2.75";
            else if (averageGrade >= 80)
                return "2.50";
            else if (averageGrade >= 77)
                return "2.25";
            else if (averageGrade >= 74)
                return "2.00";
            else if (averageGrade >= 71)
                return "1.75";
            else if (averageGrade >= 68)
                return "1.50";
            else if (averageGrade >= 64)
                return "1.25";
            else if (averageGrade >= 60)
                return "1.00";
            else
                return "0.00";
        }
    }
}