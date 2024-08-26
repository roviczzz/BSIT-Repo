using System.Windows.Forms;

namespace GradeCalculator_RodriguezBIT33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                    float Mid = Convert.ToInt32(txtMid.Text);
                    float Final = Convert.ToInt32(txtFinal.Text);
                    float AvgGrade = (Mid + Final)/2;

                    lblAvgGrade.Text = AvgGrade.ToString();
            }
        }
    }
}
