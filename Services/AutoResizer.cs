using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fightCrypto.Services
{
    internal class AutoResizer
    {
        private List<Rectangle> _ctrlOriginalRects = new List<Rectangle>();
        private List<float> _ctrlOriginalFontSizes = new List<float>();
        private Size _frmOriginalSize;
        private Form _form;

        public AutoResizer(Form form)
        {
            _form = form;
            _frmOriginalSize = form.Size;

            // Lưu lại vị trí, kích thước và cỡ chữ ban đầu của tất cả control
            GetAllControls(_form).ForEach(c =>
            {
                _ctrlOriginalRects.Add(new Rectangle(c.Location, c.Size));
                _ctrlOriginalFontSizes.Add(c.Font.Size);
            });
        }

        // Hàm đệ quy lấy tất cả control con, cháu...
        private List<Control> GetAllControls(Control container)
        {
            var list = new List<Control>();
            foreach (Control c in container.Controls)
            {
                list.Add(c);
                if (c.Controls.Count > 0)
                    list.AddRange(GetAllControls(c));
            }
            return list;
        }

        public void Resize()
        {
            // Tính tỷ lệ thay đổi
            float xRatio = (float)_form.Width / (float)_frmOriginalSize.Width;
            float yRatio = (float)_form.Height / (float)_frmOriginalSize.Height;

            int counter = 0;
            var controls = GetAllControls(_form);

            foreach (Control c in controls)
            {
                if (counter < _ctrlOriginalRects.Count)
                {
                    // Tính toán lại vị trí và kích thước
                    Rectangle r = _ctrlOriginalRects[counter];
                    float newX = r.X * xRatio;
                    float newY = r.Y * yRatio;
                    float newWidth = r.Width * xRatio;
                    float newHeight = r.Height * yRatio;

                    c.Location = new Point((int)newX, (int)newY);
                    c.Size = new Size((int)newWidth, (int)newHeight);

                    // Tính toán lại cỡ chữ (tùy chọn, nếu muốn chữ to theo)
                    float newFontSize = _ctrlOriginalFontSizes[counter] * ((xRatio + yRatio) / 2);
                    // Giới hạn cỡ chữ không quá nhỏ
                    if (newFontSize > 5)
                        c.Font = new Font(c.Font.FontFamily, newFontSize, c.Font.Style);

                    counter++;
                }
            }
        }
    }
}
