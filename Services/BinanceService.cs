using fightCrypto.Models; // << Thêm Model
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

// Namespace phải là thư mục chứa nó
namespace fightCrypto.Services
{
    // Tạo một lớp tĩnh để gọi API
    public static class BinanceService
    {
        // Chuyển HttpClient vào đây
        private static readonly HttpClient client = new HttpClient();

        // Hàm khởi tạo tĩnh, chạy 1 lần duy nhất
        static BinanceService()
        {
            // Sửa lỗi 418 (I'm a teapot)
            client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/100.0.0.0 Safari/537.36");
        }

        // Chuyển hàm LoadSpotMarketData vào đây
        // Hàm này giờ sẽ trả về một List, chứ không gán trực tiếp
        public static async Task<List<BinanceTicker>> LoadSpotMarketData()
        {
            string apiUrl = "https://api.binance.com/api/v3/ticker/24hr";
            string jsonResponse = await client.GetStringAsync(apiUrl);

            List<BinanceTicker> tickers = JsonConvert.DeserializeObject<List<BinanceTicker>>(jsonResponse);

            // Lọc dữ liệu
            var filteredTickers = tickers
                .Where(t => t.Symbol.EndsWith("USDT") || t.Symbol.EndsWith("BUSD"))
                .Take(100)
                .ToList();

            // Trả về danh sách đã lọc
            return filteredTickers;
        }

        // (Khi nào làm Future, bạn cũng thêm hàm LoadFutureMarketData vào đây)
    }
}