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
using BUS_QuanLy.BUS_BanVe;

namespace QuanLyBanVeMayBay.Components.ComponentsBanVe
{
    public partial class Step1 : UserControl
    {
        BUS_Step1 busStep1 = new BUS_Step1();
        
        public Step1()
        {
            InitializeComponent();
            XuatPhatTime.Format = DateTimePickerFormat.Time; // tao thoi gian xuat phat
            XuatPhatTime.ShowUpDown = true;
            KhuHoiTime.Format = DateTimePickerFormat.Time; // tao thoi gian khu hoi
            KhuHoiTime.ShowUpDown = true;
            ConstructorDiaChiComBoBox();
        }
       
        private void ConstructorDiaChiComBoBox()
        {
            XuatPhatDrDwn.DataSource = busStep1.LoadSanBayComboBox();
            XuatPhatDrDwn.DisplayMember = "TenSanBay";
            XuatPhatDrDwn.ValueMember = "TenSanBay";
        }
        private void NguoiLonTxt_KeyPress(object sender, KeyPressEventArgs e)   // nguoitontxt chi duoc nhap so, sai thi thong bao
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Vui long nhap so !");
            }
        }

        private void KhuHoiCheckBox_OnChange(object sender, EventArgs e)    // check box khu hoi bat,tat time va date
        {
            if (KhuHoiTime.Enabled || KhuHoiDate.Enabled)
            {
                KhuHoiTime.Enabled = false;
                KhuHoiDate.Enabled = false;
            }
            else
            {
                KhuHoiTime.Enabled = true;
                KhuHoiDate.Enabled = true;
            }
        }

        private void KhuHoiDate_ValueChanged(object sender, EventArgs e)    // kiem tra ngay khu hoi nhap vao phai lon hon ngay xuat phat
        {
            if(KhuHoiDate.Value < XuatPhatDate.Value)
            {
                MessageBox.Show("Ngày khứ hồi phải lớn hơn ngày xuất phát !!!");
            }
            
        }
    }
}
