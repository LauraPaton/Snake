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
        private List<Point> locations = new List<Point>(); 

        private int nX = 0;
        private int nY = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random_pixel();
            this.snake.Add(lblHead);
            this.locations.Add(lblHead.Location);
            this.Timer.Interval = 100;
            this.Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        { 
            moveBody(new Point(lblHead.Location.X + nX, lblHead.Location.Y + nY));
            wall_touched();
            collision_pixel();
        }

        public void collision_pixel()
        {
            if (lblHead.Bounds.IntersectsWith(lblPixel.Bounds))
            {
                Label label = createLabel();
                locations.Add(locations[snake.Count() - 1]);
                snake.Add(label);
                Controls.Add(label);
                random_pixel();
            }
        }
        
        private void wall_touched()
        {
            Point point = new Point();

            if (lblHead.Top < 0)
            {
                point = new Point(lblHead.Location.X, this.Height - lblHead.Height);
                moveBody(point);
            }
            if (lblHead.Location.Y + lblHead.Height > this.Height)
            {
                point = new Point(lblHead.Location.X, 0);
                moveBody(point);
            }
            if (lblHead.Left <= 0)
            {
                point = new Point(this.Width - lblHead.Width, lblHead.Location.Y);
                moveBody(point);
            }
            if (lblHead.Location.X + lblHead.Width > this.Width)
            {
                point = new Point(0, lblHead.Location.Y);
                moveBody(point);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    nY = -10;
                    nX = 0;
                    break;
                case Keys.Down:
                    nY = 10;
                    nX = 0;
                    break;
                case Keys.Right:
                    nY = 0;
                    nX = 10;
                    break;
                case Keys.Left:
                    nY = 0;
                    nX = -10;
                    break;
            }
        }

        private void random_pixel()
        {
            Random rnd = new Random();
            int w = rnd.Next(0, this.Width-lblPixel.Width);
            int h = rnd.Next(0, this.Height-lblPixel.Height);
            
            lblPixel.Location = new Point(w, h);
        }

        private void moveBody(Point point)
        {
            for (int i = snake.Count - 1; i > 0; i--)
            {
                locations[i] = locations[i - 1];
                snake[i].Location = locations[i];
            }

            lblHead.Location = point;
            locations[0] = lblHead.Location;
        }

        private Label createLabel()
        {
            Label label = new Label();
            label.BackColor = Color.Lime;
            label.Location = locations[snake.Count() - 1];
            label.Name = "lblBody" + (snake.Count() - 1).ToString();
            label.Size = new Size(14, 14);
            label.FlatStyle = FlatStyle.Flat;

            return label;
        }
    }
}
