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
using System.Globalization;

namespace fightCrypto.Forms
{
    public partial class Trangchu : Form
    {
        // Tạo một HttpClient để tái sử dụng
        private static readonly HttpClient client = new HttpClient();

        public Trangchu()
        {
            InitializeComponent();

            // Sửa lỗi 418 (I'm a teapot)
            client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/100.0.0.0 Safari/537.36");

            // Hiện panel thị trường
            this.panel_Thitruong.Visible = true;

            // Gán sự kiện Load cho Form
            this.Load += Trangchu_Load;

            // Khử flicker
            typeof(DataGridView).InvokeMember(
               "DoubleBuffered",
               System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
               null,
               this.dgv_Thitruong,
               new object[] { true });
        }

        // --- HÀM LOAD (CHẠY 1 LẦN) ---
        private async void Trangchu_Load(object sender, EventArgs e)
        {
            // BẮT BUỘC: Đặt cái này bằng code (vì Designer của bạn bị lỗi)
            this.dgv_Thitruong.AutoGenerateColumns = false;

            try
            {
                await LoadSpotMarketData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ Binance: " + ex.Message);
            }
        }

        // --- HÀM TICK (CHẠY LIÊN TỤC) ---
        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                await LoadSpotMarketData();
            }
            catch (Exception ex)
            {
                // Bỏ qua lỗi timer
            }
        }

        private async Task LoadSpotMarketData()
        {
            string apiUrl = "https://api.binance.com/api/v3/ticker/24hr";
            string jsonResponse = await client.GetStringAsync(apiUrl);

            List<BinanceTicker> tickers = JsonConvert.DeserializeObject<List<BinanceTicker>>(jsonResponse);

            var filteredTickers = tickers
                .Where(t => t.Symbol.EndsWith("USDT") || t.Symbol.EndsWith("BUSD"))
                .Take(100)
                .ToList();

            // Gán dữ liệu
            this.dgv_Thitruong.DataSource = filteredTickers;
        }


        // ... code các nút bấm của bạn ...
        private void btn_thịtruong_Click(object sender, EventArgs e)
        {
            this.panel_Thitruong.Visible = true;
            this.panel_future.Visible = false;
        }

        private void btn_future_Click(object sender, EventArgs e)
        {
            this.panel_Thitruong.Visible = false;
            this.panel_future.Visible = true;
        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            menuGiaoDich.Show(btnGiaoDich, 0, btnGiaoDich.Height);
        }

        // --- HÀM HỖ TRỢ ĐỊNH DẠNG SỐ ---
        private string FormatLargeNumber(double number)
        {
            if (number >= 1_000_000_000_000) return $"${(number / 1_000_000_000_000):F2}T";
            if (number >= 1_000_000_000) return $"${(number / 1_000_000_000):F2}B";
            if (number >= 1_000_000) return $"${(number / 1_000_000):F2}M";
            if (number >= 1_000) return $"${(number / 1_000):F2}K";
            return $"${number:N2}";
        }


        // --- HÀM ĐỊNH DẠNG Ô (ĐÃ NÂNG CẤP TỐI ĐA) ---
        private void dgv_Thitruong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Lấy tên cột hiện tại
            string colName = this.dgv_Thitruong.Columns[e.ColumnIndex].Name;

            // --- 1. XỬ LÝ CỘT ICON (colIcon) ---
            if (colName == "colIcon")
            {
                if (e.RowIndex >= 0)
                {
                    // Lấy đối tượng dữ liệu của hàng này
                    var row = this.dgv_Thitruong.Rows[e.RowIndex];
                    if (row.DataBoundItem is BinanceTicker ticker)
                    {
                        // Dọn dẹp tên symbol (ví dụ: "BTCUSDT" -> "btc")
                        string cleanSymbol = ticker.Symbol
                            .Replace("USDT", "")
                            .Replace("BUSD", "");
                           

                        // Thử lấy ảnh từ Resources (bạn phải tự thêm ảnh vào)
                        try
                        {
                            e.Value = (Image)Properties.Resources.ResourceManager.GetObject(cleanSymbol);
                        }
                        catch
                        {
                            e.Value = null; // Không tìm thấy ảnh
                        }
                    }
                }
                return; // Xong việc với ô này
            }

            // --- 2. XỬ LÝ CÁC Ô CÓ DỮ LIỆU (VALUE) ---
            if (e.Value == null) return;
            string stringValue = e.Value.ToString();

            // --- 2a. SỬA TÊN (colSymbol) ---
            if (colName == "colSymbol")
            {
                // Sửa "BTCUSDT" thành "BTC"
                e.Value = stringValue.Replace("USDT", "").Replace("BUSD", "");
            }

            // --- 2b. ĐỊNH DẠNG SỐ (Giá, %, Khối lượng) ---
            double numericValue;
            bool isNumber = double.TryParse(stringValue, NumberStyles.Any, CultureInfo.InvariantCulture, out numericValue);
            if (!isNumber) return; // Bỏ qua nếu không phải là số

            if (colName == "colLastPrice")
            {
                e.Value = $"{numericValue.ToString("N2")} $";
            }
            else if (colName == "colPriceChangePercent")
            {
                string formattedPercent = $"{numericValue:F2}%";
                if (numericValue > 0)
                {
                    e.CellStyle.ForeColor = Color.LimeGreen;
                    e.Value = $"+{formattedPercent}";
                }
                else if (numericValue < 0)
                {
                    e.CellStyle.ForeColor = Color.FromArgb(255, 100, 100);
                    e.Value = formattedPercent;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.Value = formattedPercent;
                }
            }
            else if (colName == "colQuoteVolume")
            {
                e.Value = FormatLargeNumber(numericValue);
            }
        }
    }


    // --- LỚP HỖ TRỢ ĐỂ ĐỰNG DỮ LIỆU TỪ BINANCE ---
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