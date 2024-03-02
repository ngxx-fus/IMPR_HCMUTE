using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace MN_05RGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap HinhGoc = new Bitmap(@"D:\DOC\23-24_HK02\IMPR\LANG_DAI_HOC-4 (Custom).jpg");
            picBoxHinhGoc.Image = HinhGoc;
            // tính hình mức xám theo phương pháp Luminance và cho hiển thị
            // BÂY GIỜ GỌI CÁC HÀM ĐÃ VIẾT ĐỂ VẼ BIỂU ĐỒ HISTOGRAM
            // ==============================================
            // tính Histogram

            double[,] histogram = TinhHistogram(HinhGoc);

            // chuyển đổi dữ liệu.
            List<PointPairList> points = ChuyenDoiHistogram(histogram);// sẽ tạo một danh sách các PointPairList từ kết quả của hàm ChuyenDoiHistogram(histogram).
            // Vẽ biểu đồ histogram và cho hiển thị
            zGHistogram.GraphPane = BieuDoHistogram(points);
            zGHistogram.Refresh();

        }

        // tính histogram của ảnh màu RGB
        public double[,] TinhHistogram(Bitmap bmp)
        {
            // chúng ta dùng mảng 2 chiều để chứa thông tin histogram
            // cho các kênh R,G,B
            // 3: là số kênh màu cần lưu
            //256: là cần 256 vị trí trương ứng với giá trị màu từ 0 -255
            double[,] histogram = new double[3, 256];//khai báo một mảng hai chiều (double[,]) với kích thước là 3 hàng và 256 cột. Mỗi phần tử trong mảng là một số thực kiểu double.



            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color color = bmp.GetPixel(x, y);
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;
                    histogram[0, R]++; // Histogram của kênh màu R
                    histogram[1, G]++; // Histogram của kênh màu G
                    histogram[2, B]++; // Histogram của kênh màu B

                }

            return histogram;


            
        }

        List<PointPairList> ChuyenDoiHistogram(double[,] histogram)//định nghĩa một hàm có tên là ChuyenDoiHistogram nhận vào một mảng hai chiều kiểu double (double[,] histogram) và trả về một danh sách (List) của đối tượng PointPairList.
        {

            // Dùng một mảng không cần khai báo trước số lượng phần từ
            // để chứa các chuyển đổi .
            List<PointPairList> points = new List<PointPairList>();//khai báo một biến points là một danh sách (List) các đối tượng PointPairList
            PointPairList redPoints = new PointPairList();// chuyển đổi histogram kênh R
            PointPairList greenPoints = new PointPairList();// chuyển đổi histogram kênh G
            PointPairList bluePoints = new PointPairList();// chuyển đổi histogram kênh B


            for (int i = 0; i < 256; i++)//Trong vòng lặp, redPoints, greenPoints, và bluePoints (các đối tượng PointPairList lưu trữ dữ liệu của kênh màu đỏ, xanh lá cây và xanh dương) được điền với các giá trị tương ứng từ mảng histogram
            {

                // i tương ứng trục nằm ngang, từ 0 - 255
                // histogram[i] tương ứng trục đứng, là pixel cùng màu
                redPoints.Add(i, histogram[0, i]);// Chuyển đổi cho kênh R
                greenPoints.Add(i, histogram[1, i]);// Chuyển đổi cho kênh G
                bluePoints.Add(i, histogram[2, i]);// Chuyển đổi cho kênh B

                // sau khi kết thúc vòng for thì thông tin histogram của các kênh RGB đã được chuyển 
                // đổi thành công, giờ add các kênh vào mảng points để trả về cho hàm
                points.Add(redPoints);
                points.Add(greenPoints);
                points.Add(bluePoints);

            }
            return points;
        }
        public GraphPane BieuDoHistogram(List<PointPairList> histogram)
        {
            // graphpane là đối tượng biểu đồ trong ZedGraph
            GraphPane gp = new GraphPane();// tạo một đối tượng GraphPane mới. Đối tượng này là một phần của thư viện ZedGraph, được sử dụng để vẽ biểu đồ.

            gp.Title.Text = @"Biểu Đồ Histogram";// tên của biểu đồ
            gp.Rect = new Rectangle(0, 0, 700, 500);// khung chứa biểu đồ
            // Thiết lập trục Ngang
            gp.XAxis.Title.Text = @"Giá trị màu của các điểm ảnh";
            gp.XAxis.Scale.Min = 0;// nhỏ nhất là 0
            gp.XAxis.Scale.Max = 255; // lớn nhất là 255
            gp.XAxis.Scale.MajorStep = 5; // mỗi bước chính là 5 . Thuộc tính này định rõ khoảng cách giữa các điểm chính trên trục X của biểu đồ. Trong trường hợp này, mỗi bước chính trên trục X sẽ có một giá trị là 5. Điều này có nghĩa là giữa hai điểm chính liên tiếp trên trục X sẽ có một khoảng cách là 5 đơn vị.
            gp.XAxis.Scale.MinorStep = 1; // mỗi bước trong một bước chính là 1 // Thuộc tính này định rõ khoảng cách giữa các điểm nhỏ (minor ticks) trên trục X của biểu đồ.


            // Tương tự, Thiết lập cho trục đứng
            gp.YAxis.Title.Text = @"số điểm ảnh có cùng giá trị màu";
            gp.YAxis.Scale.Min = 0;// nhỏ nhất là 0 
            gp.YAxis.Scale.Max = 1500; // số này phải lớn hơn kích thước ảnh(wxh)
            gp.YAxis.Scale.MajorStep = 5; // mỗi bước chính là 5
            gp.YAxis.Scale.MinorStep = 1; // Thuộc tính này định rõ khoảng cách giữa các điểm nhỏ (minor ticks) trên trục Y của biểu đồ.

            // Dùng biểu đồ dạng bar để biễu diễn histogram.
            gp.AddBar("Histogram Red ", histogram[0], Color.Red);//để thêm một thanh cột vào biểu đồ dạng bar. Đây là cách bạn thêm một thanh cột tượng trưng cho histogram của kênh màu đỏ (Red) vào biểu đồ.
            gp.AddBar("Histogram Green ", histogram[1], Color.Green);
            gp.AddBar("Histogram Blue ", histogram[2], Color.Blue);

            return gp;

        }







        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
