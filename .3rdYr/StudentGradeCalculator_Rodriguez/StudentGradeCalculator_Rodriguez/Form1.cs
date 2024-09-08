using System.Windows.Forms;

namespace StudentGradeCalculator_Rodriguez
{
    public partial class Form1 : Form
    {
        // Define delegate function
        public delegate float CalculateAverage(float midterm, float final);
        public Form1()
        {
            InitializeComponent();
        }

        // CalculateGrade method
        private float CalculateGrade(float midterm, float final)
        {
            return (midterm + final) / 2;
        }

        // Calculation button and instantiation of delegate function
        private void button1_Click(object sender, EventArgs e)
        {
            {
                CalculateAverage calculate = new CalculateAverage(CalculateGrade);

                float Midterm = Convert.ToInt32(txtMid.Text);
                float Final = Convert.ToInt32(txtFinal.Text);

                float AvgGrade = calculate(Midterm, Final);
                lblAvgGrade.Text = AvgGrade.ToString();
            }
        }
        // Calculation button and instantiation of delegate function
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateAverage calculate = new CalculateAverage(CalculateGrade);

            float Midterm = Convert.ToInt32(txtMid.Text);
            float Final = Convert.ToInt32(txtFinal.Text);

            float AvgGrade = calculate(Midterm, Final);
            lblAvgGrade.Text = AvgGrade.ToString();
        }
    }
}
