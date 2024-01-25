using Emgu.CV;
using Emgu.Util;
using Emgu.CV.UI;
using System.IO;

namespace gray_scale
{
    public partial class Form1 : Form
    {
        //var
        public String IMAGE_PATH = @"";
        public Bitmap Original = new Bitmap(1, 1);

        //method average
        public static Bitmap to_gray_average(Bitmap original)
        {
            Bitmap result = new Bitmap(original.Width, original.Height);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);
                    byte avg = (byte) (pixel.R / 3.0f + pixel.G / 3.0f + pixel.B / 3.0f);
                    Color gray_pixel = Color.FromArgb(pixel.A, avg, avg, avg);
                    result.SetPixel(x, y, gray_pixel);
                }
            }
            return result;
        }

        //method lightness
        public static Bitmap to_gray_lightness(Bitmap original)
        {
            Bitmap result = new Bitmap(original.Width, original.Height);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);
                    byte min_ = Math.Min(pixel.R, Math.Min(pixel.G, pixel.B));
                    byte max_ = Math.Max(pixel.R, Math.Max(pixel.G, pixel.B));
                    byte lightness = (byte) (min_ + (max_ - min_) / 2.0f);
                    Color gray_pixel = Color.FromArgb(pixel.A, lightness, lightness, lightness);
                    result.SetPixel(x, y, gray_pixel);
                }
            }
            return result;
        }

        //method lightness
        public static Bitmap to_gray_luminance(Bitmap original)
        {
            Bitmap result = new Bitmap(original.Width, original.Height);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);
                    byte luminance = (byte)(0.3f * pixel.R + 0.59f * pixel.G + 0.11f * pixel.B);
                    Color gray_pixel = Color.FromArgb(pixel.A, luminance, luminance, luminance);
                    result.SetPixel(x, y, gray_pixel);
                }
            }
            return result;
        }
        public Form1()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IMAGE_PATH = img_path_textbox.Text;

            if (File.Exists(IMAGE_PATH) == false) return;

            Original = new Bitmap(IMAGE_PATH);
            pictureBox1.Image = Original;

            Bitmap tmp = Original;
            
            tmp = to_gray_average(Original);
            pictureBox2.Image = tmp;

            tmp = to_gray_lightness(Original);
            pictureBox3.Image = tmp;

            tmp = to_gray_luminance(Original);
            pictureBox4.Image = tmp;
        }
    }
}
