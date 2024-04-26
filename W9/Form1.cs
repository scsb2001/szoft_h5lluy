namespace W9
{
    public partial class Form1 : Form
    {
        Models.StudentContext studentContext = new Models.StudentContext();

        public Form1()
        {
            InitializeComponent();
            studentBindingSource.DataSource = studentContext.Students.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                studentContext.SaveChanges();
            }
            catch (Exception kivétel)
            {
                MessageBox.Show(kivétel.InnerException.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = studentContext.Students.Where(student => student.Name.Contains(tbFilter.Text) == true).ToList();
            //db.studenttable.Where(stdnt => stdnt.ClassId == cboClassList.SelectedIndex).ToList();
        }
    }
}