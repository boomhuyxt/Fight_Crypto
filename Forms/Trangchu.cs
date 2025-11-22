using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Newtonsoft.Json;
using System.Globalization;

// --- THÊM CÁC DỊCH VỤ VÀ MÔ HÌNH MỚI ---
using fightCrypto.Models;
using fightCrypto.Services;

namespace fightCrypto.Forms
{
    public partial class Trangchu : Form
    {

        public Trangchu()
        {
            InitializeComponent();

         
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
            this.dgv_Thitruong.AutoGenerateColumns = false;

            try
            {
                // --- THAY ĐỔI CÁCH GỌI ---
                // 1. Gọi Service để lấy dữ liệu
                var data = await BinanceService.LoadSpotMarketData();
                // 2. Gán dữ liệu cho DataGridView
                this.dgv_Thitruong.DataSource = data;
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
             
                // 1. Gọi Service để lấy dữ liệu
                var data = await BinanceService.LoadSpotMarketData();
                // 2. Gán dữ liệu cho DataGridView
                this.dgv_Thitruong.DataSource = data;
            }
            catch (Exception ex)
            {
                // Bỏ qua lỗi timer
            }
        }

        // ... code các nút bấm của bạn (Giữ nguyên) ...
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


        // --- HÀM ĐỊNH DẠNG Ô ---
        private void dgv_Thitruong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Lấy tên cột hiện tại
            string colName = this.dgv_Thitruong.Columns[e.ColumnIndex].Name;

            // --- 1. XỬ LÝ CỘT ICON (colIcon) ---
            if (colName == "colIcon")
            {
                if (e.RowIndex >= 0)
                {
                    var row = this.dgv_Thitruong.Rows[e.RowIndex];
                    if (row.DataBoundItem is BinanceTicker ticker)
                    {
                        string cleanSymbol = ticker.Symbol
                            .Replace("USDT", "")
                            .Replace("BUSD", "");
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
                return;
            }

            // --- 2. XỬ LÝ CÁC Ô CÓ DỮ LIỆU (VALUE) ---
            if (e.Value == null) return;
            string stringValue = e.Value.ToString();

            // --- 2a. SỬA TÊN (colSymbol) ---
            if (colName == "colSymbol")
            {
                e.Value = stringValue.Replace("USDT", "").Replace("BUSD", "");
            }

            // --- 2b. ĐỊNH DẠNG SỐ (Giá, %, Khối lượng) ---
            double numericValue;
            bool isNumber = double.TryParse(stringValue, NumberStyles.Any, CultureInfo.InvariantCulture, out numericValue);
            if (!isNumber) return;

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
}