using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patterns4
{
    public partial class Form1 : Form
    {
        static string path = "TestImage.tif";
        static ProxyPic pic = new ProxyPic(path);
        public Form1()
        {
            InitializeComponent();
            //pictureBox1.Image = Image.FromFile(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, DragEventArgs e)
        {
            pic.X = e.X;
            pic.Y = e.Y;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Capture)
            {
                int dx = e.X - pic.X;
                int dy = e.Y - pic.Y;
                int hx, hy;
                hx = pictureBox1.Location.X + dx - (pictureBox1.Height / 2);
                hy = pictureBox1.Location.Y + dy - (pictureBox1.Width / 2);
                pictureBox1.Location = new Point(hx, hy);
                //pic.X = e.X;
                //pic.Y = e.Y;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = pic.picture;
            //pictureBox1.Location = new Point(e.X, e.Y);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.Image = pic.picture;
            //pictureBox1.Location = new Point(e.X, e.Y);
        }

    }
    class ProxyPic
    {
        public ProxyPic(string path)
        {
            picture = Image.FromFile(path);
        }
        public Image picture;
        public int X;
        public int Y;
    }
}
