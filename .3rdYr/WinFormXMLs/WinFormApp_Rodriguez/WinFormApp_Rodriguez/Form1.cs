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

namespace WinFormApp_Rodriguez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Load the XML file
                string filePath = "C:\\Users\\student\\source\\repos\\WinFormApp_Rodriguez\\WinFormApp_Rodriguez\\Merch.xml"; // Path to your XML file
                XDocument xdoc = XDocument.Load(filePath);

                // Clear previous items in the ListBox
                listBox.Items.Clear();

                // Parse and add XML data to the ListBox
                var values = xdoc.Descendants("item")
                                  .Select(item => new
                                  {
                                      Name = item.Element("name")?.Value ?? "No Name",
                                      Value = item.Element("value")?.Value
                                  })
                                  .Select(x => new
                                  {
                                      x.Name,
                                      Value = double.TryParse(x.Value, out double result) ? result : (double?)null
                                  })
                                  .ToList();

                foreach (var item in values)
                {
                    listBox.Items.Add($"Name: {item.Name}, Value: {item.Value}");
                }

                // Compute sum and average
                double sum = values.Where(v => v.Value.HasValue).Sum(v => v.Value.Value);
                double average = values.Where(v => v.Value.HasValue).Average(v => v.Value.Value);

                // Display the results by prefixing dollar sign after the equal sign;            
                lblTotal.Text = sum.ToString(); lblAverage.Text = average.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

