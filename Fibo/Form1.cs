using System.Reflection.Metadata.Ecma335;

namespace Fibo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Row<int, int>> dict = new List<Row<int, int>>();
            for (int i = 0; i < 10; i++) dict.Add(new Row<int, int>(i, Fibo(i)));
            dataGridView1.DataSource = dict;
        }

        private int Fibo(int num)
        {
            return (num == 0) ? 0 : ((num == 1) ? 1 : Fibo(num - 1) + Fibo(num - 2));
        }
    }
}