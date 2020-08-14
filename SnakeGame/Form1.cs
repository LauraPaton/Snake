using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private List<Label> snake = new List<Label>(); 

        private int nX = 0;
        private int nY = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random_pixel();
            this.snake.Add(lblHead);
            this.Timer.Interval = 10;
            this.Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            moveBody(new Point(lblHead.Location.X + nX, lblHead.Location.Y + nY));
            wall_touched();
            collision_pixel();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (nY != 5)
                    {
                        nY = -5;
                        nX = 0;
                    }
                    break;
                case Keys.Down:
                    if (nY != -5)
                    {
                        nY = 5;
                        nX = 0;
                    }
                    break;
                case Keys.Right:
                    if (nX != -5)
                    {
                        nY = 0;
                        nX = 5;
                    }
                    break;
                case Keys.Left:
                    if (nX != 5)
                    {
                        nY = 0;
                        nX = -5;
                    }
                    break;
            }
        }

        public void collision_pixel()
        {
            if (lblHead.Bounds.IntersectsWith(lblPixel.Bounds))
            {
                Label label = createLabel();
                snake.Add(label);
                Controls.Add(label);
                random_pixel();
            }
        }

        public void collision_itself()
        {
            for (int i = 1; i < snake.Count; i++)
            {
                if (snake[i].Location == snake[0].Location)
                {
                    Timer.Stop();
                    MessageBox.Show("GAME OVER");
                }
            }
        }
        private void wall_touched()
        {

            if (lblHead.Top < 0)
            {
                moveBody(new Point(lblHead.Location.X, this.Height - lblHead.Height));
            }
            if (lblHead.Location.Y + lblHead.Height > this.Height)
            {
                moveBody(new Point(lblHead.Location.X, 0));
            }
            if (lblHead.Left <= 0)
            {
                moveBody(new Point(this.Width - lblHead.Width, lblHead.Location.Y));
            }
            if (lblHead.Location.X + lblHead.Width > this.Width)
            {
                moveBody(new Point(0, lblHead.Location.Y));
            }
        }

        private void random_pixel()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, this.Width-lblPixel.Width);
            int y = rnd.Next(0, this.Height-lblPixel.Height);
            lblPixel.Location = new Point(x, y);
        }

        private void moveBody(Point point)
        {
            for (int i = snake.Count - 1; i > 0; i--)
            {
                snake[i].Location = snake[i-1].Location;
            }

            lblHead.Location = point;
            collision_itself();
        }

        private Label createLabel()
        {
            Label label = new Label();
            label.BackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            label.Name = "lblBody" + (snake.Count() - 1).ToString();
            label.Size = new Size(11, 12);
            label.FlatStyle = FlatStyle.Flat;
            return label;
        }
    }
}
