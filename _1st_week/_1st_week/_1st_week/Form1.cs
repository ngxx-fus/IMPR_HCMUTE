
using Emgu.CV.Util;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using System.Windows.Forms;
using Emgu.CV;

namespace _1st_week
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string img_path = @"D:\DOC\23-24_HK02\IMPR\_1st_week\_1st_week\IMG.jpg";
            if (!File.Exists(img_path))
            {
                label2.Text = "Couldn't load IMG!\n";
                return;
            }

            Image<Bgr, byte> Img = new Image<Bgr, byte>(img_path);
            int w = Img.Width;
            int h = Img.Height;

            Image_Box.Height = h;
            Image_Box.Width = w;
            Image_Box.Image = Img;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
