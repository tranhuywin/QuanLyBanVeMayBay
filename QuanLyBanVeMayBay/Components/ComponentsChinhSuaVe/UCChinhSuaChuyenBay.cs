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
    public partial class UCChinhSuaChuyenBay : UserControl
    {
        DTO_TuyenBay dtoTuyenBay = new DTO_TuyenBay();
        DTO_ChiTietChuyenBay dtoChiTieTChuyenBay = new DTO_ChiTietChuyenBay();
        DTO_ChuyenBay dtoChuyenBay = new DTO_ChuyenBay();

        BUS_ThemChuyenBay busThemChuyenBay = new BUS_ThemChuyenBay();
        private string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }
        public UCChinhSuaChuyenBay()
        {
            InitializeComponent();
            dtoChiTieTChuyenBay.MaChiTietChuyenBay = dtoChuyenBay.MaChiTietChuyenBay = generateID();
            dtoChuyenBay.MaTuyenBay = dtoTuyenBay.MaTuyenBay = generateID();
            dtoChuyenBay.MaChuyenBay  = generateID();
        }
        

        private void Donebtn_Click(object sender, EventArgs e)
        {
            dtoTuyenBay.SanBayDi = SanBayDitext.Text;
            dtoTuyenBay.SanBayDen = SanBayDentext.Text;
            dtoChuyenBay.NgayGio = NgayGioBaytext.Text;
            dtoChiTieTChuyenBay.SanBayTrungGian = SanBayTrungGiantext.Text;
            dtoChiTieTChuyenBay.ThoiGianDung = ThoiGianDungtext.Text;
            dtoChuyenBay.TenMayBay = TenMayBaytext.Text;
            if (busThemChuyenBay.LoadThemMoiChuyenBay(dtoChiTieTChuyenBay,dtoChuyenBay,dtoTuyenBay))
            {
                MessageBox.Show("Thêm thành công");
                this.Hide();
            }
            else
                MessageBox.Show("Thêm thất bại");

        }
        public void LoadMaChuyenBay()
        {         

            MaChuyenBaytext.Text=dtoChuyenBay.MaChuyenBay;
        }
    }
    
}
