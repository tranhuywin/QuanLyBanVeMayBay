using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy.BUS_TaoTaiKhoan;

namespace QuanLyBanVeMayBay.Components.ComponentsTaoTaiKhoan
{
    public partial class UCTaoTaiKhoan : UserControl
    {
        public UCTaoTaiKhoan()
        {
            InitializeComponent();
            MatKhauText.UseSystemPasswordChar = true;
        }
        DTO_User dtoUser = new DTO_User();
        BUS_TaoTaiKhoan busTaoTaiKhoan = new BUS_TaoTaiKhoan();
        private void TaoTaiKhoanBtn_Click(object sender, EventArgs e)
        {
            dtoUser.ChucVu = "1";
            dtoUser.CMND = CMNDTxt.Text;
            dtoUser.DiaChi = DiaChiTxt.Text;
            dtoUser.HoTen = HoTenTxt.Text;
            dtoUser.NgaySinh = NgaySinhDateTimePicker.Value.ToString();
            dtoUser.User = TaiKhoanTxt.Text;
            dtoUser.Password = MatKhauText.Text;
            bool create;
            create = busTaoTaiKhoan.TaoTaiKhoan(dtoUser);
            if (create)
                MessageBox.Show("Tạo tài khoản thành công");
            else
                MessageBox.Show("Tạo tài khoản thất bại");
        }

        private void AnHienMatKhauCheckBox_OnChange(object sender, EventArgs e)
        {
            if (MatKhauText.UseSystemPasswordChar)
                MatKhauText.UseSystemPasswordChar = false;
            else
                MatKhauText.UseSystemPasswordChar = true;
        }
    }
}
