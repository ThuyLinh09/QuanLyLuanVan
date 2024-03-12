using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLuanVan
{
    public partial class FSinhVien : Form
    {
        public FSinhVien()
        {
            InitializeComponent();
        }
        private void ShowFormInPanel(Form formToShow, Panel panel)
        {
            formToShow.TopLevel = false; // Đặt định cấu hình cho form con
            formToShow.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền của form con
            formToShow.Dock = DockStyle.Fill; // Đặt vị trí của form con đầy đủ trong panel
            panel.Controls.Add(formToShow); // Thêm form con vào panel
            formToShow.Show(); // Hiển thị form con
        }

        private void ShowUserControlInPanel(UserControl userControlToShow, Panel panel)
        {
            panel.Controls.Clear(); // Xóa bất kỳ UserControl nào đang hiển thị trước đó trong panel
            userControlToShow.Dock = DockStyle.Fill; // Đặt vị trí của UserControl đầy đủ trong panel
            panel.Controls.Add(userControlToShow); // Thêm UserControl vào panel
        }
        // Sự kiện click button để hiển thị form lên panel
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UCDSDoAn uCDSDoAn = new UCDSDoAn();
            ShowUserControlInPanel(uCDSDoAn, guna2Panel2);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
