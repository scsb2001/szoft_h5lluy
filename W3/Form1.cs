namespace W3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            Button b = new Button();
            Controls.Add(b);

            b.Left = ClientRectangle.Width / 2 - b.Width / 2;
            b.Top = ClientRectangle.Height / 2 - b.Height / 2;

            int size = 20;

            for (int row = 0; row < 20; row++)
            {
                for (int col = 0; col < 20; col++)
                {
                    SzamoloGomb o = new SzamoloGomb(size);
                    Controls.Add(o);
                    o.Height = size;
                    o.Width = size;
                    o.Left = size * col;
                    o.Top = size * row;
                    o.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }
            }

        }
    }
}