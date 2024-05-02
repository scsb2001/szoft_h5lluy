using W10.Models;

namespace W10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen pen = new Pen(Color.Yellow);
            Brush brush = new SolidBrush(Color.White);
            g.FillEllipse(brush, 0, 0, 100, 100);

            hajosContext context = new hajosContext();

            var stars = from x in context.StarData
                        select new { x.Hip, x.Magnitude, x.X, x.Y }; // Anon type

            double zoom = Math.Min(ClientRectangle.Width, ClientRectangle.Height) / 2;
            //double zoom = 300;
            int ox = ClientRectangle.Width / 2, oy = ClientRectangle.Height / 2;

            g.Clear(Color.DarkBlue);

            foreach (var star in stars)
            {
                if (Math.Sqrt(Math.Pow(star.X, 2) + Math.Pow(star.Y, 2)) > 1
                    || star.Magnitude > 6)
                    continue;
                double size = 20 * Math.Pow(10, star.Magnitude / -2.5);
                if (size < 1) size = 1;

                double x = star.X * zoom + ox;
                double y = star.Y * zoom + oy;

                g.FillEllipse(brush, (float)(x - size / 2), (float)(y - size / 2), (float)size, (float)size);
            }

            var lines = context.ConstellationLines.ToList();
            foreach (var line in lines)
            {

                var star1 = (from x in stars where x.Hip == line.Star1 select x).FirstOrDefault();
                var star2 = (from x in stars where x.Hip == line.Star2 select x).FirstOrDefault();
                if (star1 == null || star2 == null) continue;
                if (Math.Sqrt(Math.Pow(star1.X, 2) + Math.Pow(star1.Y, 2)) > 1) continue;
                if (Math.Sqrt(Math.Pow(star2.X, 2) + Math.Pow(star2.Y, 2)) > 1) continue;
                double x1 = star1.X * zoom + ox;
                double y1 = star1.Y * zoom + oy;
                double x2 = star2.X * zoom + ox;
                double y2 = star2.Y * zoom + oy;

                g.DrawLine(pen, (float)x1, (float)y1, (float)x2, (float)y2);
            }
        }
    }
}