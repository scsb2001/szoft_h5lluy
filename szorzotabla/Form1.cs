namespace szorzotabla
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
                for (int col = 0; col < 10; col++)
                {
                    Button button = new /*Button*/();
                    button.Text = (row * col).ToString();

                    button.Width = 40;
                    button.Height = 40;
                    button.Top = button.Height * row;
                    button.Left = button.Width * col;
                    Controls.Add(button);
                }
            }
        }
    }
}