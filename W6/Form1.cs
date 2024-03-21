using System.Diagnostics;

namespace W6
{
    public partial class Form1 : Form
    {
        private List<SnakeElem> snake = new List<SnakeElem>();
        private List<Tuple<int, int>> borders = new List<Tuple<int, int>>();
        private int head_x = 100;
        private int head_y = 100;
        private int dir_x = 1;
        private int dir_y = 0;
        private int step = 0;
        private int len = 0;

        public Form1()
        {
            InitializeComponent();

            InitBorders();

            SnakeElem head = new SnakeElem(head_x, head_y);
            snake.Add(head);
            Controls.Add(head);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            step++;
            head_x += dir_x * SnakeElem.Size;
            head_y += dir_y * SnakeElem.Size;

            foreach (SnakeElem item in Controls)
            {
                if ((item.Top == head_y && item.Left == head_x) || borders.Contains(new Tuple<int, int>(item.Top, item.Left)))
                {
                    timer1.Enabled = false;
                    return;
                }
            }

            len = Controls.Count;

            SnakeElem elem = new SnakeElem(head_x, head_y);
            //if (step % 2 == 0) elem.BackColor = Color.Yellow;
            snake.Add(elem);
            Controls.Add(elem);
            if (Controls.Count > len)
            {
                SnakeElem tail = snake[0];
                snake.RemoveAt(0);
                Controls.Remove(tail);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    dir_y = -1;
                    dir_x = 0;
                    break;
                case Keys.Down:
                    dir_y = 1;
                    dir_x = 0;
                    break;
                case Keys.Left:
                    dir_x = -1;
                    dir_y = 0;
                    break;
                case Keys.Right:
                    dir_x = 1;
                    dir_y = 0;
                    break;
            }
        }

        private void InitBorders()
        {
            for (int i = 0; i < 1000; i += 20)
            {
                borders.Add(new Tuple<int, int>(i, 0));
            }

            for (int i = 0; i < 1000; i += 20)
            {
                borders.Add(new Tuple<int, int>(i, 700));
            }

            for (int i = 0; i < 700; i += 20)
            {
                borders.Add(new Tuple<int, int>(0, i));
            }

            for (int i = 0; i < 700; i += 20)
            {
                borders.Add(new Tuple<int, int>(1000, i));
            }

        }
    }
}