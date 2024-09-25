using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Drawing.Text;

namespace WinFormApp3_Rodriguez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double partialFee(int units)
        {
            if (units >= 15)
            {
                double partialFee = units * 500;
                return partialFee - (partialFee * .03);
            }
            if (units >= 20)
            {
                double partialFee = units * 500;
                return partialFee - (partialFee * .05);
            }
            if (units >= 24)
            {
                double partialFee = units * 500;
                return partialFee - (partialFee * .07);
            }
            else
            {
                return 0;
            }
        }

        private String DiscountString(int units)
        {
            if (units >= 15)
            {
                return "3%";
            }
            if (units >= 20)
            {
                return "5%";
            }
            if (units >= 24)
            {
                return "7%";
            }
            else
            {
                return null;
            }
        }
        private double Discount(int units)
        {
            if (units >= 15)
            {
                return .03;
            }
            if (units >= 20)
            {
                return .05;
            }
            if (units >= 24)
            {
                return .07;
            }
            else
            {
                return 0;
            }
        }

        private double totalFee (double partialFee, double discount)
        {
            return partialFee - (partialFee * discount);
        }

            private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string id = textBoxStudentID.Text;
            string lastName = textBoxLname.Text;
            string firstName = textBoxFname.Text;
            string course = textBoxCourse.Text;
            int units = int.Parse(textBoxUnits.Text);

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(course) || string.IsNullOrEmpty(units.ToString()))
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }

            // Create an XML document and save the data
            XElement student = new XElement("Student",
                new XElement("ID", id),
                new XElement("LastName", lastName),
                new XElement("FirstName", firstName),
                new XElement("Course", course),
                new XElement("Units", units),
                new XElement("DiscountString", DiscountString(units)),
                new XElement("Discount", Discount(units)),
                new XElement("PartialFee", partialFee(units)),
                new XElement("TotalFee", totalFee(partialFee(units), Discount(units)))
                );

            XDocument doc;
            string xmlFile = "StudentDiscount.xml";

            // Check if XML file exists
            if (System.IO.File.Exists(xmlFile))
            {
                doc = XDocument.Load(xmlFile); // Load the existing file
                doc.Element("Student").Add(student); // Add new employee to the root
            }
            else
            {
                // Create a new XML document if file doesn't exist
                doc = new XDocument(
                    new XElement("Students", student));
            }

            doc.Save(xmlFile); // Save the document
            MessageBox.Show("Student data saved to XML successfully.");
        }

        

            private void button1_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();  // Clear existing items in the list
            string xmlFile = "StudentDiscount.xml";

            if (System.IO.File.Exists(xmlFile))
            {
                // Load the XML file
                XDocument doc = XDocument.Load(xmlFile);
                XElement studentsElement = doc.Element("Students");

                foreach (XElement student in studentsElement.Elements("Student"))
                {
                    string id = student.Element("ID")?.Value ?? "No ID";
                    string lastName = student.Element("LastName")?.Value ?? "No Last Name";
                    string firstName = student.Element("FirstName")?.Value ?? "No First Name";
                    string course = student.Element("Course")?.Value ?? "No Course";
                    int units = int.Parse(student.Element("Units")?.Value ?? "No Units");
                    string discountString = student.Element("DiscountString")?.Value ?? "No Discount String";
                    string partialFee = student.Element("PartialFee")?.Value ?? "No Partial Fee";
                    string totalFee = student.Element("TotalFee")?.Value ?? "No Total Fee";

                    listBoxData.Items.Add($"ID:{id}"); listBoxData.Items.Add($"Last Name: {lastName}");
                    listBoxData.Items.Add($"FirstName:{firstName}"); listBoxData.Items.Add($"Course: {course}");
                    listBoxData.Items.Add($"Units: {units}");
                    listBoxData.Items.Add($"Partial Fee: {partialFee}");
                    listBoxData.Items.Add($"Discount: {discountString}");
                    listBoxData.Items.Add($"Total: {totalFee}");
                    listBoxData.Items.Add(new string('-', 40));

                }
            }
            else
            {
                MessageBox.Show("No XML file found. Please add data first.");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string xmlFile = "StudentDiscount.xml";

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            textBoxStudentID.Text = string.Empty;
            textBoxFname.Text = string.Empty;
            textBoxLname.Text = string.Empty;  
            textBoxCourse.Text = string.Empty;
            textBoxUnits.Text = string.Empty;
        }
    }
    }