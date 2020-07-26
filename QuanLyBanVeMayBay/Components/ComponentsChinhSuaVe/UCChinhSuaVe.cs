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
    public partial class UCChinhSuaVe : UserControl
    {
        public UCChinhSuaVe()
        {
            InitializeComponent();
        }
        private string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }

        private void UCChinhSuaVe_Load(object sender, EventArgs e)
        {

        }
        DTO_TuyenBay dtoTuyenBay = new DTO_TuyenBay();
        DTO_ChiTietChuyenBay dtoChiTietChuyenBay = new DTO_ChiTietChuyenBay();
        DTO_ChuyenBay dtoChuyenBay = new DTO_ChuyenBay();



        BUS_ChinhSuaVe busChinhSuaVe = new BUS_ChinhSuaVe();
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            dtoChuyenBay.MaChuyenBay = MaChuyenBayTxt.Text;
            VeDataGridView.DataSource = busChinhSuaVe.LoadTableVe(dtoChuyenBay);
            VeDataGridView.Show();
        }


        private void Newbtn_Click(object sender, EventArgs e)
        {
            ucChinhSuaChuyenBay1.LoadMaChuyenBay();
            ucChinhSuaChuyenBay1.Show();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            ucEditChuyenBay1.LoadDTOEditChuyenBay(dtoChiTietChuyenBay,dtoChuyenBay,dtoTuyenBay);
            ucEditChuyenBay1.Show();
        }

        private void VeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = VeDataGridView.Rows[e.RowIndex];
            dtoChuyenBay.MaChuyenBay = row.Cells["MaChuyenBay"].Value.ToString().Trim();
            dtoChuyenBay.NgayGio = row.Cells["NgayGio"].Value.ToString().Trim();
            dtoChuyenBay.ThoiGianBay = row.Cells["ThoiGianBay"].Value.ToString().Trim();
            dtoChiTietChuyenBay.SanBayTrungGian = row.Cells["SanBayTrungGian"].Value.ToString().Trim();
            dtoTuyenBay.SanBayDi = row.Cells["SanBayDi"].Value.ToString().Trim();
            dtoTuyenBay.SanBayDen = row.Cells["SanBayDen"].Value.ToString().Trim();
            dtoChuyenBay.TenMayBay = row.Cells["TenMayBay"].Value.ToString().Trim();
            dtoChiTietChuyenBay.ThoiGianDung = row.Cells["ThoiGianDung"].Value.ToString().Trim();
            Editbtn.Enabled = true;
            Deletebtn.Enabled = true;
        }

        private void ucChinhSuaChuyenBay1_Load(object sender, EventArgs e)
        {

        }
    }
}
