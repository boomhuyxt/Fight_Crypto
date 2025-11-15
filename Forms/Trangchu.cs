using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Thêm các thư viện này
using System.Net.Http;
using Newtonsoft.Json;

namespace fightCrypto.Forms
{
    public partial class Trangchu : Form
    {
        // Tạo một HttpClient để tái sử dụng
        private static readonly HttpClient client = new HttpClient();

        public Trangchu()
        {
            InitializeComponent();

            // Hiện panel thị trường
            this.panel_Thitruong.Visible = true;

            // Gán sự kiện Load cho Form
            this.Load += Trangchu_Load;

            // --- THÊM DÒNG NÀY ĐỂ KHỬ FLICKER ---
            typeof(DataGridView).InvokeMember(
               "DoubleBuffered",
               System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
               null,
               this.dgv_Thitruong, // Tên DataGridView của bạn
               new object[] { true });
            // --- HẾT PHẦN THÊM ---
        }

        // --- HÀM MỚI: LẤY DỮ LIỆU KHI FORM ĐƯỢC LOAD ---
        private async void Trangchu_Load(object sender, EventArgs e)
        {
            try
            {
                // Gọi hàm để lấy dữ liệu thị trường (Spot)
                await LoadSpotMarketData();

                // (Bạn sẽ tạo một hàm tương tự cho Future)
                // await LoadFutureMarketData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ Binance: " + ex.Message);
            }
        }

        private async Task LoadSpotMarketData()
        {
            // 1. GỌI API
            // Đây là API lấy thông tin 24h cho TẤT CẢ các cặp Spot
            string apiUrl = "https://api.binance.com/api/v3/ticker/24hr";
            string jsonResponse = await client.GetStringAsync(apiUrl);

            // 2. CHUYỂN ĐỔI JSON
            // Chuyển đổi chuỗi JSON thành một danh sách các đối tượng
            List<BinanceTicker> tickers = JsonConvert.DeserializeObject<List<BinanceTicker>>(jsonResponse);

            // 3. HIỂN THỊ LÊN DATAGRIDVIEW
            // (Giả sử bạn đã kéo dgv_Thitruong vào panel_Thitruong)

            // Chỉ lấy 100 cặp đầu tiên cho nhẹ
            this.dgv_Thitruong.DataSource = tickers.Take(100).ToList();
        }

        // === XÓA CÁC HÀM PAINT VÌ CHÚNG KHÔNG CẦN THIẾT ===
        // private void panel_future_Paint(object sender, PaintEventArgs e) { }
        // private void panel_Thitruong_Paint(object sender, PaintEventArgs e) { }


        // ... code các nút bấm của bạn ...
        private void btn_thịtruong_Click(object sender, EventArgs e)
        {
            this.panel_Thitruong.Visible = true;
        }

        // (Bạn cần thêm 1 nút cho Future)
        private void btn_future_Click(object sender, EventArgs e)
        {
            this.panel_Thitruong.Visible = false;
            this.panel_future.Visible = true; // Hiện panel future
        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            menuGiaoDich.Show(btnGiaoDich, 0, btnGiaoDich.Height);
        }


        private void dgv_Thitruong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_Thitruong.Columns[e.ColumnIndex].Name == "PriceChangePercent")
            {
                if (e.Value != null)
                {
                    // 1. Lấy giá trị (là string)
                    string stringValue = e.Value.ToString();

                    // 2. Chuyển nó thành số
                    double numericValue;
                    if (double.TryParse(stringValue, out numericValue))
                    {
                        // 3. Đổi màu dựa trên giá trị
                        if (numericValue > 0)
                        {
                            e.CellStyle.ForeColor = Color.LimeGreen; // Màu xanh
                        }
                        else if (numericValue < 0)
                        {
                            e.CellStyle.ForeColor = Color.FromArgb(255, 100, 100); // Màu đỏ
                        }
                        else
                        {
                            e.CellStyle.ForeColor = Color.White; // Màu trắng
                        }
                    }
                }
            }
        }
    }

    // --- LỚP HỖ TRỢ ĐỂ ĐỰNG DỮ LIỆU TỪ BINANCE ---
    // (Bạn phải định nghĩa lớp này để Json hoạt động)
    public class BinanceTicker
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("priceChange")]
        public string PriceChange { get; set; }

        [JsonProperty("priceChangePercent")]
        public string PriceChangePercent { get; set; }

        [JsonProperty("lastPrice")]
        public string LastPrice { get; set; }

        [JsonProperty("highPrice")]
        public string HighPrice { get; set; }

        [JsonProperty("lowPrice")]
        public string LowPrice { get; set; }

        [JsonProperty("volume")]
        public string Volume { get; set; }
    }
}