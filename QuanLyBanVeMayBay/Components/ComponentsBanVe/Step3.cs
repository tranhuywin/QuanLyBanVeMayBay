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
    public partial class Step3 : UserControl
    {
        public DTO_ChuyenBay dtoChuyenBayXuatPhat = new DTO_ChuyenBay { NgayGio = "", ThoiGianBay = "", SoGheHang1 = 0, SoGheHang2 = 0 };
        public DTO_TuyenBay dtoTuyenBayXuatPhat = new DTO_TuyenBay { SanBayDi = "", SanBayDen = "" };

        public bool KhuHoi = false;
        public DTO_ChuyenBay dtoChuyenBayKhuHoi = new DTO_ChuyenBay { NgayGio = "", ThoiGianBay = "", SoGheHang1 = 0, SoGheHang2 = 0 };
        public DTO_TuyenBay dtoTuyenBayKhuHoi = new DTO_TuyenBay { SanBayDi = "", SanBayDen = "" };

        public DTO_PhieuDatCho dtoPhieuDatChoXuatPhat = new DTO_PhieuDatCho { MaChuyenBay = "", MaPhieu = "", NgayDat = DateTime.Today.ToString(), SoGhe = "0" };
        public DTO_PhieuDatCho dtoPhieuDatChoKhuHoi = new DTO_PhieuDatCho { MaChuyenBay = "", MaPhieu = "", NgayDat = DateTime.Today.ToString(), SoGhe = "0" };

        private BUS_Step3 busstep3 = new BUS_Step3();
        private string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }
        private bool KiemTraDuLieu() // kiem tra cac o nhap du lieu co dien day` du chua
        {
            if (CmndTxt.Text != "" && EmailTxt.Text != "" && SDTTxt.Text != "" && GioiTinhComboBox.Text != null && HoTenKHTxt.Text != "")
                return true; // cac o du lieu da dien day du
            else
            {
                return false; // co 1 hoac nhieu o dien thieu
            }
        }
        public Step3()
        {
            InitializeComponent();
        }

        private void HoangThanhBtn_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                DTO_KhachHang dtokhachhang = new DTO_KhachHang { CMND = CmndTxt.Text, Email = EmailTxt.Text, GioiTinh = GioiTinhComboBox.Text, HoTenKH = HoTenKHTxt.Text, SDT = SDTTxt.Text, MaKhachHang = generateID() };
                bool insertKH = busstep3.InsertKhachHang(dtokhachhang);
                
                if (insertKH)   // them khach hang vao trong CSDL
                {
                    MessageBox.Show("Thêm khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại!!!");
                }
                dtoPhieuDatChoXuatPhat.MaKH = dtokhachhang.MaKhachHang;
                dtoPhieuDatChoXuatPhat.MaPhieu = generateID();
                if (SoGheHang1XuatPhatLabel.Text == "0")
                    dtoPhieuDatChoXuatPhat.SoGhe = SoGheHang2XuatPhatLabel.Text;
                else dtoPhieuDatChoXuatPhat.SoGhe = SoGheHang1XuatPhatLabel.Text;

                bool changeTrangThaiVeMayBayXuatPhat = busstep3.ChangeTrangThaiVe(dtoPhieuDatChoXuatPhat);
                if (changeTrangThaiVeMayBayXuatPhat)    // Thay doi trang thai ve thanh da dat
                {
                    MessageBox.Show("Đặt vé thành công");
                }
                else
                    MessageBox.Show("Đặt vé thất bại");
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!!");
            }

        }

        public void Step3_Load()
        {
            NgayGioXuatPhatlabel.Text = dtoChuyenBayXuatPhat.NgayGio;
            ThoiGianBayXuatPhatLabel.Text = dtoChuyenBayXuatPhat.ThoiGianBay;
            SanBayDiXuatPhatLabel.Text = dtoTuyenBayXuatPhat.SanBayDi;
            SanBayDenXuatPhatLabel.Text = dtoTuyenBayXuatPhat.SanBayDen;
            SoGheHang1XuatPhatLabel.Text = dtoChuyenBayXuatPhat.SoGheHang1.ToString();
            SoGheHang2XuatPhatLabel.Text = dtoChuyenBayXuatPhat.SoGheHang2.ToString();
            MaChuyenBayLabel.Text = dtoPhieuDatChoXuatPhat.MaChuyenBay;

            if (KhuHoi)
            {
                KhuHoiLabel.Visible = true;
                NgayGioKhuHoiLabel.Text = dtoChuyenBayKhuHoi.NgayGio;
                ThoiGianKhuHoiLabel.Text = dtoChuyenBayKhuHoi.ThoiGianBay;
                SanBayDiKhuHoiLabel.Text = dtoTuyenBayKhuHoi.SanBayDi;
                SanBayDenKhuHoiLabel.Text = dtoTuyenBayKhuHoi.SanBayDen;
                SoGheHang1KhuHoiLabel.Text = dtoChuyenBayKhuHoi.SoGheHang1.ToString();
                SoGheHang2KhuHoiLabel.Text = dtoChuyenBayKhuHoi.SoGheHang2.ToString();
                MaChuyenBayKhuHoiLabel.Text = dtoPhieuDatChoKhuHoi.MaChuyenBay;
            }
        }

    }
}
