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
            this.dgv_Thitruong.AutoGenerateColumns = false;

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

        // --- HÀM TICK (CHẠY LIÊN TỤC MỖI 5 GIÂY) ---
        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // Cập nhật lại dữ liệu
                await LoadSpotMarketData();
                // await LoadFutureMarketData();
            }
            catch (Exception ex)
            {
                
            }
        }

        private async Task LoadSpotMarketData()
        {
            string apiUrl = "https://api.binance.com/api/v3/ticker/24hr";
            string jsonResponse = await client.GetStringAsync(apiUrl);

            List<BinanceTicker> tickers = JsonConvert.DeserializeObject<List<BinanceTicker>>(jsonResponse);

            // --- LỌC DỮ LIỆU ĐỂ GIỐNG BINANCE HƠN ---
            // Chỉ lấy các cặp giao dịch với USDT và BUSD (giống trang chủ Binance)
            var filteredTickers = tickers
                .Where(t => t.Symbol.EndsWith("USDT") || t.Symbol.EndsWith("BUSD"))
                .Take(100) // Lấy 100 cặp đầu
                .ToList();

            // Gán dữ liệu
            this.dgv_Thitruong.DataSource = filteredTickers;
        }


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
            this.dgv_Thitruong.Cursor = Cursors.Default;
            // KIỂM TRA LẠI TÊN CỘT CỦA BẠN (colPriceChangePercent)
            if (this.dgv_Thitruong.Columns[e.ColumnIndex].Name == "colPriceChangePercent")
            {
                if (e.Value != null)
                {
                    string stringValue = e.Value.ToString();
                    double numericValue;
                    if (double.TryParse(stringValue, out numericValue))
                    {
                        if (numericValue > 0)
                        {
                            e.CellStyle.ForeColor = Color.LimeGreen;
                        }
                        else if (numericValue < 0)
                        {
                            e.CellStyle.ForeColor = Color.FromArgb(255, 100, 100);
                        }
                        else
                        {
                            e.CellStyle.ForeColor = Color.White;
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

        [JsonProperty("quoteVolume")]
        public string QuoteVolume { get; set; }
    }
}