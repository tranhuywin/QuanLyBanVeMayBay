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
using BUS_QuanLy.BUS_ChinhSuaVe;

namespace QuanLyBanVeMayBay.Components.ComponentsChinhSuaVe
{
    public partial class UCEditChuyenBay : UserControl
    {
        public UCEditChuyenBay()
        {
            InitializeComponent();
        }
        DTO_TuyenBay dtoTuyenBay = new DTO_TuyenBay();
        DTO_ChiTietChuyenBay dtoChiTieTChuyenBay = new DTO_ChiTietChuyenBay();
        DTO_ChuyenBay dtoChuyenBay = new DTO_ChuyenBay();

        BUS_EditChuyenBay busEditChuyenBay = new BUS_EditChuyenBay();
        private void Donebtn_Click(object sender, EventArgs e)
        {

                dtoChuyenBay.MaChuyenBay = MaChuyenBaytext.Text;
                dtoTuyenBay.SanBayDi = SanBayDitext.Text;
                dtoTuyenBay.SanBayDen = SanBayDentext.Text;
                dtoChuyenBay.NgayGio = NgayGioBaytext.Text;
                dtoChiTieTChuyenBay.SanBayTrungGian = SanBayTrungGiantext.Text;
                dtoChiTieTChuyenBay.ThoiGianDung = ThoiGianDungtext.Text;
                dtoChuyenBay.TenMayBay = TenMayBaytext.Text;
                dtoChuyenBay.ThoiGianBay = ThoiGianBaytext.Text;
                if (busEditChuyenBay.LoadEditChuyenBay(dtoChiTieTChuyenBay, dtoChuyenBay, dtoTuyenBay))
                {
                    MessageBox.Show("Sửa thành công");
                    this.Hide();
                }
                else
                    MessageBox.Show("Sửa thất bại");

            
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadDTOEditChuyenBay(DTO_ChiTietChuyenBay dtoChiTieTChuyenBay,DTO_ChuyenBay dtoChuyenBay,DTO_TuyenBay dtoTuyenBay)
        {
            this.dtoChiTieTChuyenBay = dtoChiTieTChuyenBay;
            this.dtoChuyenBay = dtoChuyenBay;
            this.dtoTuyenBay = dtoTuyenBay;
            ThoiGianDungtext.Text = dtoChiTieTChuyenBay.ThoiGianDung;
            MaChuyenBaytext.Text = dtoChuyenBay.MaChuyenBay;
            SanBayDentext.Text = dtoTuyenBay.SanBayDen;
            SanBayDitext.Text = dtoTuyenBay.SanBayDi;
            NgayGioBaytext.Text = dtoChuyenBay.NgayGio;
            SanBayTrungGiantext.Text = dtoChiTieTChuyenBay.SanBayTrungGian;
            ThoiGianBaytext.Text = dtoChuyenBay.ThoiGianBay;
            TenMayBaytext.Text = dtoChuyenBay.TenMayBay;
        }

    }
}
