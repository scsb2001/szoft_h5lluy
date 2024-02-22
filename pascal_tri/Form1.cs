namespace pascal_tri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < row + 1; col++)
                {
                    Button button = new /*Button*/();
                    //button.Text = (row * col).ToString();
                    int m = 40;
                    button.Width = 40;
                    button.Height = 40;
                    button.Top = button.Height * row;
                    button.Left = button.Width * col - row * button.Width/2 + 300;
                    Controls.Add(button);

                    int x = Fact(row) / (Fact(col) * Fact(row - col));
                    button.Text= x.ToString();
                }
            }
        }

        private int Fact(int num)
        {
            return (num == 0) ? 1 : Fact(num - 1) * num;
        }
    }
}