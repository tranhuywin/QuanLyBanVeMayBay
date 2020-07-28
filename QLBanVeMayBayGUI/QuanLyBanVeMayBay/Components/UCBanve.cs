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

namespace QuanLyBanVeMayBay.Components
{
    public partial class UCBanve : UserControl
    {
        public DTO_ChuyenBay dtoChuyenBayXuatPhat = new DTO_ChuyenBay { NgayGio = "", ThoiGianBay = "", SoGheHang1 = 0, SoGheHang2 = 0 };
        public DTO_TuyenBay dtoTuyenBayXuatPhat = new DTO_TuyenBay { SanBayDi = "", SanBayDen = "" };

        public bool KhuHoi = false;
        public DTO_ChuyenBay dtoChuyenBayKhuHoi = new DTO_ChuyenBay { NgayGio = "", ThoiGianBay = "", SoGheHang1 = 0, SoGheHang2 = 0 };
        public DTO_TuyenBay dtoTuyenBayKhuHoi = new DTO_TuyenBay { SanBayDi = "", SanBayDen = "" };

        public DTO_PhieuDatCho dtoPhieuDatChoXuatPhat = new DTO_PhieuDatCho { MaChuyenBay = "", MaPhieu = "", NgayDat = DateTime.Today.ToString(), SoGhe = "0" };
        public DTO_PhieuDatCho dtoPhieuDatChoKhuHoi = new DTO_PhieuDatCho { MaChuyenBay = "", MaPhieu = "", NgayDat = DateTime.Today.ToString(), SoGhe = "0" };

        public UCBanve()
        {
            InitializeComponent();
        }

        private void Step1Btn_Click(object sender, EventArgs e)
        {
            ContentBanVePanel.Controls.Clear();
            ContentBanVePanel.Controls.Add(step11);
        }

        private void Step2Btn_Click(object sender, EventArgs e)
        {
            ContentBanVePanel.Controls.Clear();
            ContentBanVePanel.Controls.Add(step21);

            dtoChuyenBayXuatPhat = step21.dtoChuyenBayXuatPhat = step11.dtoChuyenBayXuatPhat;
            dtoTuyenBayXuatPhat = step21.dtoTuyenBayXuatPhat = step11.dtoTuyenBayXuatPhat;
            KhuHoi = step21.KhuHoi = step11.KhuHoi;
            dtoChuyenBayKhuHoi = step21.dtoChuyenBayKhuHoi = step11.dtoChuyenBayKhuHoi;
            dtoTuyenBayKhuHoi = step21.dtoTuyenBayKhuHoi = step11.dtoTuyenBayKhuHoi;
            step21.Step2_Load();
        }


        private void Step3Btn_Click(object sender, EventArgs e)
        {
            ContentBanVePanel.Controls.Clear();
            ContentBanVePanel.Controls.Add(step31);
            dtoPhieuDatChoXuatPhat.MaChuyenBay = step21.dtoPhieuDatChoXuatPhat.MaChuyenBay;
            dtoPhieuDatChoKhuHoi.MaChuyenBay = step21.dtoPhieuDatChoKhuHoi.MaChuyenBay;

            step31.dtoChuyenBayXuatPhat = dtoChuyenBayXuatPhat;
            step31.dtoTuyenBayXuatPhat = dtoTuyenBayXuatPhat;
            step31.dtoPhieuDatChoXuatPhat = dtoPhieuDatChoXuatPhat;
            if (KhuHoi)
            {
                step31.KhuHoi = KhuHoi;
                step31.dtoChuyenBayKhuHoi = dtoChuyenBayKhuHoi;
                step31.dtoTuyenBayKhuHoi = dtoTuyenBayKhuHoi;
                step31.dtoPhieuDatChoKhuHoi = dtoPhieuDatChoKhuHoi;
            }
            step31.Step3_Load();
        }

        private void UCBanve_Load(object sender, EventArgs e)
        {
            ContentBanVePanel.Controls.Clear();
            ContentBanVePanel.Controls.Add(step11);
        }
    }
}
