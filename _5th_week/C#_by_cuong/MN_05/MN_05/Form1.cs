using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;
using System.Windows.Forms;


namespace MN_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap HinhGoc = new Bitmap(@"E:\IM_PR\bird_small.jpg");      

            // cho hiển thị trên PicturBox  
            picBoxHinhGoc.Image = HinhGoc;
            // tính hình mức xám theo phương pháp Luminance và cho hiển thị
            Bitmap HinhMucXam = ChuyenHinhRGBSangHinhXamLuminance(HinhGoc);// hinhgoc là truyền vào đối tượng HinhGoc (đã được tạo trước đó).
            picBoxHinhMucXam.Image = HinhMucXam;

            // BÂY GIỜ GỌI CÁC HÀM ĐÃ VIẾT ĐỂ VẼ BIỂU ĐỒ HISTOGRAM
            // ==============================================
            // tính Histogram

            double[] histogram = TinhHistogram(HinhMucXam); // đang khai báo một mảng số thực kiểu double có tên là histogram và gán giá trị của nó bằng kết quả trả về từ phương thức TinhHistogram.

            // chuyển đổi dữ liệu.
            PointPairList points = ChuyenDoiHistogram(histogram); // đang tạo một đối tượng PointPairList có tên là points và gán giá trị cho nó bằng kết quả trả về từ phương thức ChuyenDoiHistogram với đối số là mảng histogram.
            // Vẽ biểu đồ histogram và cho hiển thị
            zGHistogram.GraphPane = BieuDoHistogram(points);//gán đối tượng GraphPane cho đối tượng zGHistogram. 
            zGHistogram.Refresh();




        }

        public Bitmap ChuyenHinhRGBSangHinhXamLuminance(Bitmap HinhGoc)

        {
            Bitmap HinhMucXam = new Bitmap(HinhGoc.Width, HinhGoc.Height);//Tạo một đối tượng Bitmap mới có kích thước tương tự như hình ảnh gốc để chứa hình ảnh mức xám.
            // chú ý: điểm tọa độ gốc(0,0) của hình là điểm gốc trái trên cùng của hình, chiều x sẽ từ gốc tính về phải, chiều Y sẽ từ gốc tính xuống dưới

            for (int x = 0; x < HinhGoc.Width; x++)
                for (int y = 0; y < HinhGoc.Height; y++)
                { // lấy đeiẻm ảnh
                    Color pixel = HinhGoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    // tinhs gias tri muc xam cho điểm ảnh tại (x,y)

                    byte gray = (byte)(0.2126 * R + 0.7152 * G + 0.0772 * B);
                    //gray được khai báo là kiểu byte trong khi max + min /2 sẽ là kiểu số thực, cần phải ép kết quả của phép chia này về kiểu byte

                    // phân loại điểm ảnh sang nhị phân dựa vào giá trị ngưỡng


                    // gán giá trị mức nhị phân vừa tính vào hình  nhị phân
                    HinhMucXam.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            return HinhMucXam;


        }

        // tính histogram của ảnh xám
        public double[] TinhHistogram(Bitmap HinhMucXam)
        {
            // Mỗi pixel mức xám có giá trị từ 0 - 255, do vật ta khai báo một mảng
            // có 256 phần tử dùng để chứa số đếm của các pixels có cùng mức xám trong ảnh.
            // Chúng ta nên dùng kiểu double vì tổng số đếm có thể raát lớn, phụ thuộc
            // vào kích thước của ảnh.
            double[] histogram = new double[256];//một mảng double có tên là histogram được khai báo với kích thước 256 phần tử. Mảng này được sử dụng để lưu trữ thông tin về histogram, là số lần xuất hiện của các mức xám khác nhau trong hình ảnh mức xám


            for (int x = 0; x < HinhMucXam.Width; x++)
                for (int y = 0; y < HinhMucXam.Height; y++)
                {
                    Color color = HinhMucXam.GetPixel(x, y);
                    byte gray = color.R;
                    
                    // trong hình mức xám giá trị kênh r cũng giống G hoặc B

                    // giá trị gray tính ra cũng chính là phần tử thứ gray trong mảng histogram
                    // đã khai báo. sẽ tăng số đếm của phần tử thứ gray lên 1.
                    histogram[gray]++;



                }

            return histogram;
        }
    
        // dùng thư viện ZedGraph để vẽ biểu đồ Histogram
        PointPairList ChuyenDoiHistogram(double[] histogram)
        {
           
            // PointPairList là kiểu dữ liệu của ZedGraph để vẽ biểu đồ 
            PointPairList points = new PointPairList();// tạo một đối tượng PointPairList trong thư viện ZedGraph. PointPairList là một danh sách các đối tượng PointPair được sử dụng để lưu trữ các cặp giá trị (X, Y) dùng để vẽ biểu đồ trong thư viện ZedGraph.

            for (int i = 0; i < histogram.Length; i++)
            {

                // i tương ứng trục nằm ngang, từ 0 - 255
                // histogram[i] tương ứn trục đứng, là pixel cùng màu
                points.Add(i, histogram[i]);//được sử dụng để thêm một điểm mới vào danh sách points (đã được khởi tạo là một đối tượng PointPairList).

            }
            return points;
        }
        // thiết lập một biểu đồ trong Zedgraph
        public GraphPane BieuDoHistogram(PointPairList histogram)
        {
            // graphpane là đối tượng biểu đồ trong ZedGraph
            GraphPane gp = new GraphPane();// tạo một đối tượng GraphPane trong thư viện ZedGraph. GraphPane là thành phần chính để tạo và quản lý biểu đồ trong ZedGraph.

            gp.Title.Text = @"Biểu Đồ Histogram";// tên của biểu đồ
            gp.Rect = new Rectangle(0, 0, 700, 500);// khung chứa biểu đồ
            // Thiết lập trục Ngang
            gp.XAxis.Title.Text = @"Giá trị mức xám của các điểm ảnh";
            gp.XAxis.Scale.Min = 0;// nhỏ nhất là 0
            gp.XAxis.Scale.Max = 255; // lớn nhất là 255
            gp.XAxis.Scale.MajorStep = 5; // mỗi bước chính là 5
            gp.XAxis.Scale.MinorStep = 1; // mỗi bước trong một bước chính là 1


            // Tương tự, Thiết lập cho trục đứng
            gp.YAxis.Title.Text = @"số điểm ảnh có cùng mức xám";
            gp.YAxis.Scale.Min = 0;// nhỏ nhất là 0 
            gp.YAxis.Scale.Max = 1500; // số này phải lớn hơn kích thước ảnh(wxh)
            gp.YAxis.Scale.MajorStep = 5; // mỗi bước chính là 5
            gp.YAxis.Scale.MinorStep = 1;

            // Dùng biểu đồ dạng bar để biễu diễn histogram.
            gp.AddBar("Histogram", histogram, Color.OrangeRed);

            return gp;

        }














        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}


