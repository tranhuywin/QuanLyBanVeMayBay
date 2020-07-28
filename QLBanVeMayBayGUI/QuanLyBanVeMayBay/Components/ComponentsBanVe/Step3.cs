using System;
using System.Windows.Forms;
using DTO_QuanLy;
using System.Net.Http;
using System.Net.Http.Headers;

namespace QuanLyBanVeMayBay.Components.ComponentsBanVe
{
    public partial class Step3 : UserControl
    {
        //declare url, client
        static HttpClient client = new HttpClient();
        private string URLAddress = Properties.Settings.Default.URLAddress;
        // end
        public DTO_ChuyenBay dtoChuyenBayXuatPhat = new DTO_ChuyenBay { NgayGio = "", ThoiGianBay = "", SoGheHang1 = 0, SoGheHang2 = 0 };
        public DTO_TuyenBay dtoTuyenBayXuatPhat = new DTO_TuyenBay { SanBayDi = "", SanBayDen = "" };

        public bool KhuHoi = false;
        public DTO_ChuyenBay dtoChuyenBayKhuHoi = new DTO_ChuyenBay { NgayGio = "", ThoiGianBay = "", SoGheHang1 = 0, SoGheHang2 = 0 };
        public DTO_TuyenBay dtoTuyenBayKhuHoi = new DTO_TuyenBay { SanBayDi = "", SanBayDen = "" };

        public DTO_PhieuDatCho dtoPhieuDatChoXuatPhat = new DTO_PhieuDatCho { MaChuyenBay = "", MaPhieu = "", NgayDat = DateTime.Today.ToString(), SoGhe = "0" };
        public DTO_PhieuDatCho dtoPhieuDatChoKhuHoi = new DTO_PhieuDatCho { MaChuyenBay = "", MaPhieu = "", NgayDat = DateTime.Today.ToString(), SoGhe = "0" };

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
            // innit client
            client.BaseAddress = new Uri(URLAddress);   // init base address
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // end
        }

        private void HoangThanhBtn_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                DTO_KhachHang dtokhachhang = new DTO_KhachHang { CMND = CmndTxt.Text, Email = EmailTxt.Text, GioiTinh = GioiTinhComboBox.Text, HoTenKH = HoTenKHTxt.Text, SDT = SDTTxt.Text, MaKhachHang = generateID() };

                // start get value
                var responseKhachHang = client.PostAsJsonAsync("/banve/step3/insert-khach-hang", dtokhachhang).Result;     // gui DTO user len web sever bang Method POST, va nhan ket qua tra ve
                var insert = responseKhachHang.Content.ReadAsStringAsync();   // khong biet
                // end

                bool insertKH = bool.Parse(insert.Result);
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

                // start get value
                var responseChangeTrangThai = client.PostAsJsonAsync("/banve/step3/change-trang-thai", dtoPhieuDatChoXuatPhat).Result;     // gui DTO user len web sever bang Method POST, va nhan ket qua tra ve
                var change = responseChangeTrangThai.Content.ReadAsStringAsync();   // khong biet
                // end

                bool changeTrangThai = bool.Parse(change.Result);

                bool changeTrangThaiVeMayBayXuatPhat = changeTrangThai;
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
