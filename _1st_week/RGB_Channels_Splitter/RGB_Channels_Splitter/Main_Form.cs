namespace RGB_Channels_Splitter
{
    public partial class Main_Form : Form
    {
        public string path_img = @"empty";
        public Bitmap Original = new Bitmap(1, 1),
                      Red_Channel = new Bitmap(1, 1),
                      Green_Channel = new Bitmap(1, 1),
                      Blue_Channel = new Bitmap(1, 1);
        public float scale_factor = 1;

        public Main_Form()
        {
            InitializeComponent();
        }
        private void split_channel()
        {
            Red_Channel = new Bitmap(Original.Width, Original.Height);
            Blue_Channel = new Bitmap(Original.Width, Original.Height);
            Green_Channel = new Bitmap(Original.Width, Original.Height);

            for (int x = 0; x < Original.Width; x++)
            {
                for (int y = 0; y < Original.Height; y++)
                {
                    Color pixel = Original.GetPixel(x, y);

                    Red_Channel.SetPixel(x, y, Color.FromArgb(pixel.A, pixel.R, 0, 0));
                    Green_Channel.SetPixel(x, y, Color.FromArgb(pixel.A, 0, pixel.G, 0));
                    Blue_Channel.SetPixel(x, y, Color.FromArgb(pixel.A, 0, 0, pixel.B));
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_button.Text = "load";
            load_button.Width = 75;

            path_img = textBox1.Text;

            if (File.Exists(path_img) == false ) //check extension is crorrect? (jpg, png, jpeg)
            {
                load_button.Text = "Loading failed!";
                load_button.Width = 120;
                return;
            }
            else
            {
                load_button.Text = "Loading successful!";
                load_button.Width = 140;
            }

            Original = new Bitmap(path_img);
            original_picture_box.Image = Original;
            split_channel();
            red_channel_picture_box.Image = Red_Channel;

            green_channel_picture_box.Image = Green_Channel;

            blue_channel_picture_box.Image = Blue_Channel;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void Origin_picture_box_Click(object sender, EventArgs e)
        {

        }
    }
}
