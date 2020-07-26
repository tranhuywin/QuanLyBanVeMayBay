using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy.BUS_BanVe;
using DTO_QuanLy;

namespace QuanLyBanVeMayBay.Components.ComponentsBanVe
{
    public partial class Step2 : UserControl
    {
        private BUS_Step2 busStep2 = new BUS_Step2();
        public DTO_ChuyenBay dtoChuyenBayXuatPhat = new DTO_ChuyenBay { NgayGio = "", ThoiGianBay = "", SoGheHang1 = 0, SoGheHang2 = 0 };
        public DTO_TuyenBay dtoTuyenBayXuatPhat = new DTO_TuyenBay { SanBayDi = "", SanBayDen = "" };

        public bool KhuHoi;
        public DTO_ChuyenBay dtoChuyenBayKhuHoi = new DTO_ChuyenBay { NgayGio = "", ThoiGianBay = "", SoGheHang1 = 0, SoGheHang2 = 0 };
        public DTO_TuyenBay dtoTuyenBayKhuHoi = new DTO_TuyenBay { SanBayDi = "", SanBayDen = "" };

        public DTO_PhieuDatCho dtoPhieuDatChoXuatPhat = new DTO_PhieuDatCho { MaChuyenBay = "", MaPhieu = "", NgayDat = DateTime.Today.ToString() };
        public DTO_PhieuDatCho dtoPhieuDatChoKhuHoi = new DTO_PhieuDatCho { MaChuyenBay = "", MaPhieu = "", NgayDat = DateTime.Today.ToString() };

        public Step2()
        {
            InitializeComponent();
        }

        public void Step2_Load()
        {
            VemayBayDataGridView.DataSource = busStep2.LoadVeMayBayDatagridViewXuatPhat(dtoChuyenBayXuatPhat, dtoTuyenBayXuatPhat);
            if (KhuHoi)     // an va hien button chon ve khu hoi
            {
                TiepBtn.Visible = true;
            }
            else
            {
                TiepBtn.Visible = false;
            }
        }

        private void XongBtn_Click(object sender, EventArgs e)
        {
            if (KhuHoi && dtoPhieuDatChoXuatPhat.MaChuyenBay != "" && dtoPhieuDatChoKhuHoi.MaChuyenBay != "")
            {
                MessageBox.Show("Bạn đã chọn vé xuất phát có mã chuyến bay là : " + dtoPhieuDatChoXuatPhat.MaChuyenBay);
                MessageBox.Show("Bạn đã chọn vé khứ hồi có mã chuyến bay là : " + dtoPhieuDatChoKhuHoi.MaChuyenBay);
            }
            else if (dtoPhieuDatChoXuatPhat.MaChuyenBay != "")
            {
                MessageBox.Show("Bạn đã chọn vé xuất phát có mã chuyến bay là : " + dtoPhieuDatChoXuatPhat.MaChuyenBay);
            }
            else
                MessageBox.Show("Vui lòng chọn vé chuyến bay");
        }

        private void TiepBtn_Click(object sender, EventArgs e)  // Button doi chon ve khu hoi va ve xuat phat
        {
            if(TiepBtn.Text == "Chọn vé khứ hồi")
            {
                XuatPhatLabel.Visible = false; // an lable xuat phat
                KhuHoiLable.Visible = true; // hien lable khu hoi
                TiepBtn.Text = "Trở lại";
                VemayBayDataGridView.DataSource = busStep2.LoadVeMayBayDatagridViewKhuHoi(dtoChuyenBayKhuHoi, dtoTuyenBayKhuHoi);
            }
            else
            {
                XuatPhatLabel.Visible = true; // hien lable xuat phat
                KhuHoiLable.Visible = false; // an lable khu hoi
                TiepBtn.Text = "Chọn vé khứ hồi";
                VemayBayDataGridView.DataSource = busStep2.LoadVeMayBayDatagridViewXuatPhat(dtoChuyenBayXuatPhat, dtoTuyenBayXuatPhat);
            }
        }

        private void VemayBayDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TiepBtn.Text == "Chọn vé khứ hồi")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.VemayBayDataGridView.Rows[e.RowIndex];
                    dtoPhieuDatChoXuatPhat.MaChuyenBay = row.Cells["Mã chuyến bay"].Value.ToString().Trim();
                }
                MessageBox.Show("Bạn đã chọn chuyến bay xuất phát có mã: " + dtoPhieuDatChoXuatPhat.MaChuyenBay);
            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.VemayBayDataGridView.Rows[e.RowIndex];
                    dtoPhieuDatChoKhuHoi.MaChuyenBay = row.Cells["Mã chuyến bay"].Value.ToString().Trim();
                }
                MessageBox.Show("Bạn đã chọn chuyến bay khứ hồi có mã: " + dtoPhieuDatChoKhuHoi.MaChuyenBay);
            }
        }
    }
}
