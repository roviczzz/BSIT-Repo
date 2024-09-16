using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormApp2_Rodriguez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClearTextbox_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxLastName.Text = "";
            textBoxFirstName.Text = "";
            textBoxSalary.Text = "";
            textBoxSex.Text = "";
            textBoxDayHired.Text = "";
            textBoxSalary.Text = "";

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();  // Clears all the items in the ListBox
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();  // Clear existing items in the list
            string xmlFile = "employees.xml";

            if (System.IO.File.Exists(xmlFile))
            {
                // Load the XML file
                XDocument doc = XDocument.Load(xmlFile);
                XElement employeesElement = doc.Element("Employees");

                foreach (XElement employee in employeesElement.Elements("Employee"))
                {
                    string id = employee.Element("ID")?.Value ?? "No ID";
                    string lastName = employee.Element("LastName")?.Value ?? "No Last Name";
                    string firstName = employee.Element("FirstName")?.Value ?? "No First Name";
                    string sex = employee.Element("Sex")?.Value ?? "No Sex";
                    DateTime dayHired = DateTime.Parse(employee.Element("DayHired")?.Value ?? DateTime.MinValue.ToString());
                    decimal salaryPerMonth = decimal.Parse(employee.Element("SalaryPerMonth")?.Value ?? "0");
                    string department = employee.Element("Department")?.Value ?? "No Department";

                    int yearsEmployed = DateTime.Now.Year - dayHired.Year;
                    if (DateTime.Now < dayHired.AddYears(yearsEmployed)) yearsEmployed--;



                    decimal incentiveAmount = incentive(yearsEmployed);  // Call the method to get the incentive
                    decimal totalSalary = salaryPerMonth + incentiveAmount;  // Use the result of the method

                    // do not forget to insert $ sign before the strings in the Add();

                    listBoxData.Items.Add($"ID:{id}"); listBoxData.Items.Add($"Last Name: {lastName}");
                    listBoxData.Items.Add($"FirstName:{firstName}"); listBoxData.Items.Add($"Sex: {sex}");
                    listBoxData.Items.Add($"DayHired:{dayHired.ToShortDateString()}"); listBoxData.Items.Add($"Salary Per Month: {salaryPerMonth:C}");
                    listBoxData.Items.Add($"Department:{department}"); listBoxData.Items.Add($"Years Employed: {yearsEmployed}");
                    listBoxData.Items.Add($"Incentive:{incentiveAmount:C}"); listBoxData.Items.Add($"Total Salary: {totalSalary:C}");
                    listBoxData.Items.Add(new string('-', 40));
                }
            }
            else
            {
                MessageBox.Show("No XML file found. Please add data first.");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string xmlFile = "employees.xml";

            // Check if the file exists
            if (System.IO.File.Exists(xmlFile))
            {
                // Delete the file
                System.IO.File.Delete(xmlFile);
                MessageBox.Show("XML file cleared successfully.");

                // Optionally, clear the ListBox as well
                listBoxData.Items.Clear();
            }
            else
            {
                MessageBox.Show("No XML file found.");
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string lastName = textBoxLastName.Text;
            string firstName = textBoxFirstName.Text;
            string sex = textBoxSex.Text;
            DateTime dayHired;
            decimal salaryPerMonth;
            string department = textBoxDepartment.Text;

            if (!DateTime.TryParse(textBoxDayHired.Text, out dayHired))
            {
                MessageBox.Show("Please enter a valid Date Hired.");
                return;
            }

            if (!decimal.TryParse(textBoxSalary.Text, out salaryPerMonth))
            {
                MessageBox.Show("Please enter a valid Salary Per Month.");
                return;
            }

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(sex) || string.IsNullOrEmpty(department))
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }

            // Create an XML document and save the data
            XElement employee = new XElement("Employee",
                new XElement("ID", id),
                new XElement("LastName", lastName),
                new XElement("FirstName", firstName),
                new XElement("Sex", sex),
                new XElement("DayHired", dayHired.ToString("yyyy-MM-dd")),
                new XElement("SalaryPerMonth", salaryPerMonth),
                new XElement("Department", department)
            );

            XDocument doc;
            string xmlFile = "employees.xml";

            // Check if XML file exists
            if (System.IO.File.Exists(xmlFile))
            {
                doc = XDocument.Load(xmlFile); // Load the existing file
                doc.Element("Employees").Add(employee); // Add new employee to the root
            }
            else
            {
                // Create a new XML document if file doesn't exist
                doc = new XDocument(
                    new XElement("Employees", employee));
            }

            doc.Save(xmlFile); // Save the document
            MessageBox.Show("Employee data saved to XML successfully.");
        }
        private decimal incentive(int yearsEmployed)
        {
            if (yearsEmployed >= 20)
            {
                return 20000m;
            }
            else if (yearsEmployed >= 15)
            {
                return 10000m;
            }
            else if (yearsEmployed >= 10)
            {
                return 5000m;
            }
            else
            {
                return 0m;
            }
        }
    }
}
