using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W11.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace W11
{
    public partial class UserControl3 : UserControl
    {
        StudiesContext context = new StudiesContext();
        List<Instructor> instructorList;
        
        public UserControl3()
        {
            InitializeComponent();
            //FillDataSource();
            //listBox1.DisplayMember = "Name";

            var instructors = from i in context.Instructors
                              select new
                              {
                                  Salutation= i.Salutation,
                                  Name = i.Name,
                                  Status = i.StatusFkNavigation.Name,
                                  Employment = i.EmployementFkNavigation.Name
                              };
            dataGridView1.DataSource = instructors.ToList();
        }

        private void FillDataSource()
        {
            //listBox1.DataSource = (from i in context.Instructors
            //                       where i.Name.Contains(textBox1.Text)
            //                       select i).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //FillDataSource();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listBox1.SelectedItem == null) return;
            //Instructor selectedInstructor = listBox1.SelectedItem as Instructor;

            //var instructors = from i in context.Instructors
            //              //where i.EmployementFk == 
            //              select new
            //              {
            //                  Kurzus = i.StatusFkNavigation.Name
            //                  //Nap = l.DayFkNavigation.Name,
            //                  //Sáv = l.TimeFkNavigation.Name
            //              };
            //dataGridView1.DataSource = instructors.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("instructors.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                // Runtime conversion error
                csv.WriteRecords((List<Instructor>?)dataGridView1.DataSource);
            }
        }
    }
}
