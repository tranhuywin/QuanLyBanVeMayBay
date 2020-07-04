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
        private BUS_Step1 busStep1 = new BUS_Step1();

        public DTO_ChuyenBay dtoChuyenBayXuatPhat = new DTO_ChuyenBay { NgayGio = "", ThoiGianBay ="", SoGheHang1 = 0, SoGheHang2 = 0};
        public DTO_TuyenBay dtoTuyenBayXuatPhat = new DTO_TuyenBay {SanBayDi = "", SanBayDen = "" };

        public bool KhuHoi = false;
        public DTO_ChuyenBay dtoChuyenBayKhuHoi = new DTO_ChuyenBay { NgayGio = "", ThoiGianBay = "", SoGheHang1 = 0, SoGheHang2 = 0 };
        public DTO_TuyenBay dtoTuyenBayKhuHoi = new DTO_TuyenBay { SanBayDi = "", SanBayDen = "" };
        public bool ClickNextStep;
        public Step1()
        {
            InitializeComponent();
            XuatPhatTime.Format = DateTimePickerFormat.Time; // tao thoi gian xuat phat
            XuatPhatTime.Value = DateTime.Parse("12:00 AM");
            XuatPhatTime.ShowUpDown = true;
            KhuHoiTime.Format = DateTimePickerFormat.Time; // tao thoi gian khu hoi
            KhuHoiTime.ShowUpDown = true;
            KhuHoiTime.Value = DateTime.Parse("12:00 AM");
            ConstructorDiaChiComBoBox();
        }

        private void ConstructorDiaChiComBoBox()
        {
            XuatPhatDrDwn.DataSource = busStep1.LoadSanBayComboBox(); // load du lieu tu BUS len combo box
            XuatPhatDrDwn.DisplayMember = "TenSanBay";
            XuatPhatDrDwn.ValueMember = "TenSanBay";

            NoiDenDrpDwn.DataSource = busStep1.LoadSanBayComboBox();// load du lieu tu BUS len combo box
            NoiDenDrpDwn.DisplayMember = "TenSanBay";
            NoiDenDrpDwn.ValueMember = "TenSanBay";
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

        private void NoiDenDrpDwn_SelectedIndexChanged(object sender, EventArgs e)  // kiem tra noi den va noi xuat phat co trung nhau khong
        {
            if(NoiDenDrpDwn.SelectedValue.ToString() == XuatPhatDrDwn.SelectedValue.ToString())
            {
                MessageBox.Show("Nơi đến phải khác nơi xuất phát !!!");
            }
        }

        private void NextStep2Btn_Click(object sender, EventArgs e)         //truyen dtoChuyenBay, dtoTuyenBay sang step 2 de loc thong tin ve
        {
            int hang1 = 0, hang2 = 0;
            if (HangVeDrpDwn.Text == "1")
                hang1 = int.Parse(HangVeDrpDwn.Text);
            else hang2 = int.Parse(HangVeDrpDwn.Text);
            dtoChuyenBayXuatPhat = new DTO_ChuyenBay { NgayGio = XuatPhatDate.Text, ThoiGianBay = XuatPhatTime.Text, SoGheHang1 = hang1, SoGheHang2 = hang2 };
            dtoTuyenBayXuatPhat = new DTO_TuyenBay { SanBayDi = XuatPhatDrDwn.Text, SanBayDen = NoiDenDrpDwn.Text };
            if (KhuHoiCheckBox.Checked)
            {
                KhuHoi = true;
                dtoChuyenBayKhuHoi = new DTO_ChuyenBay { NgayGio = KhuHoiDate.Text, ThoiGianBay = KhuHoiTime.Text, SoGheHang1 = hang1, SoGheHang2 = hang2 };
                dtoTuyenBayKhuHoi = new DTO_TuyenBay { SanBayDi = NoiDenDrpDwn.Text, SanBayDen = XuatPhatDrDwn.Text };
            }
            MessageBox.Show("Vui lòng tới bước 2 để điền thông tin");
        }

        private void SoGheTxt_KeyPress(object sender, KeyPressEventArgs e)  //Chi dc nhap so, nhap chu thi thong bao
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Vui long nhap so !!!");
            }
        }
    }
}
