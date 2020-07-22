using BUS_QuanLy.BUS_BanVe;
using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy.BUS_TaiKhoan;

namespace QuanLyBanVeMayBay.Components.ComponentsTimKiemVe
{
    public partial class TimKiemVe : UserControl
    {
        public TimKiemVe()
        {
            InitializeComponent();
        }
        public DTO_User dtoUser = new DTO_User();
        private BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        private DataTable dt;
        private void AnHienMatKhauCheckBox_OnChange(object sender, EventArgs e) // an hien mat khau
        {
            if (!AnHienMatKhauCheckBox.Checked)
            {
                MatKhauText.UseSystemPasswordChar = false;
            }
            else
                MatKhauText.UseSystemPasswordChar = true;
        }

        private void TimKiemVe_Load(object sender, EventArgs e) // load form
        {
            TaiKhoanTxt.Text = dtoUser.User;
            MatKhauText.Text = dtoUser.Password;
            MatKhauText.UseSystemPasswordChar = true;
        }
        public void LoadUser() // load user tu main
        {
            TaiKhoanTxt.Text = dtoUser.User;
            MatKhauText.Text = dtoUser.Password;
            dt = busTaiKhoan.LoadTaiKhoan(dtoUser);
            HoTenTxt.Text = (string)dt.Rows[0][0];
            DiaChiTxt.Text = (string)dt.Rows[0][1];
            CMNDTxt.Text = (string)dt.Rows[0][2];
            string birthdate = dt.Rows[0][3].ToString();
            NgaySinhDateTimePicker.Value = DateTime.Parse(birthdate);
        }
        //enable textbox to edit
        private void HoTenBtn_Click(object sender, EventArgs e)
        {
            if (HoTenTxt.Enabled)
                HoTenTxt.Enabled = false;
            else
                HoTenTxt.Enabled = true;
        }

        private void CMNDBtn_Click(object sender, EventArgs e)
        {
            if (CMNDTxt.Enabled)
                CMNDTxt.Enabled = false;
            else
                CMNDTxt.Enabled = true;
        }

        private void NgaySinhBtn_Click(object sender, EventArgs e)
        {
            if (NgaySinhDateTimePicker.Enabled)
                NgaySinhDateTimePicker.Enabled = false;
            else
                NgaySinhDateTimePicker.Enabled = true;
        }

        private void DiaChiBtn_Click(object sender, EventArgs e)
        {
            if (DiaChiTxt.Enabled)
                DiaChiTxt.Enabled = false;
            else
                DiaChiTxt.Enabled = true;
        }

        private void TaiKhoanBtn_Click(object sender, EventArgs e)
        {
            if (TaiKhoanTxt.Enabled)
                TaiKhoanTxt.Enabled = false;
            else
                TaiKhoanTxt.Enabled = true;
        }

        private void MatKhauBtn_Click(object sender, EventArgs e)
        {
            if (MatKhauText.Enabled)
                MatKhauText.Enabled = false;
            else
                MatKhauText.Enabled = true;
        }

        private void LuuBtn_Click(object sender, EventArgs e) // luu thong tin tai khoan
        {
            dtoUser.HoTen = HoTenTxt.Text;
            dtoUser.NgaySinh = NgaySinhDateTimePicker.Value.ToString();
            dtoUser.DiaChi = DiaChiTxt.Text;
            dtoUser.CMND = CMNDTxt.Text;
            bool luu;
            luu = busTaiKhoan.LuuTaiKhoan(dtoUser);
            if (!luu)
                MessageBox.Show("Lưu thông tin tài khoản thất bại");
            else
                MessageBox.Show("Lưu thông tin tài khoản thành công");
        }
    }
}
