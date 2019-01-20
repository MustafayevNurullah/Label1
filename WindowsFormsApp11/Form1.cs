using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Point point1;
        public Point point2;
        public Point point3;
        public int counter=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            point1.X = e.X;
            point1.Y = e.Y;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {


                counter++;
                point2 = (e as MouseEventArgs).Location;
                Label label = new Label();
                label.Location = point2;
                label.Text = counter.ToString();
                label.BackColor = Color.Red;
                if (point1.X == point2.X & point1.Y == point2.Y)
                {
                    label.Location = point2;
                    label.Size = new Size(10, 10);

                }
                else
                {
                    if (point2.X < point1.X)
                    {
                        point3.X = point1.X - point2.X;
                        point3.Y = point1.Y - point2.Y;
                        label.Location = point3;
                    }
                    if(point2.X>point1.X)
                    {
                        point3.X = point2.X - point1.X;
                        point3.Y = point2.Y - point1.Y;
                        label.Location = point3;
                    }
                    label.Size = new Size(point3.X, point3.Y);
                }

                label.MouseDoubleClick += Label_MouseDoubleClick;
                Controls.Add(label);
            }
        }

        private void Label_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            (sender as Label).Dispose();
            counter--;

        }
    

       
    }
}
