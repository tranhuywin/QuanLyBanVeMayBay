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
using BUS_QuanLy.BUS_KhachHang;

namespace QuanLyBanVeMayBay.Components.ComponentsKhachHang
{
    public partial class UCKhachHang : UserControl
    {
        DTO_KhachHang dtoKhachHang = new DTO_KhachHang();

        private void UCKhachHang_Load(object sender, EventArgs e)
        {
        }
        public UCKhachHang()
        {
            InitializeComponent();
        }
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        BUS_XoaKH busXoaKH = new BUS_XoaKH();
        private void Newbtn_Click_1(object sender, EventArgs e)
        {
            ucChinhSuaKH1.Show();
        }

        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            DTO_KhachHang dtoKhachHang1 = new DTO_KhachHang { HoTenKH = HoTenKHTxt.Text, CMND = CMNDTxt.Text };
            KhachHangDataGridView.DataSource = busKhachHang.LoadKhachHangComboBox(dtoKhachHang1);
            KhachHangDataGridView.Show();
        }

        private void KhachHangDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = KhachHangDataGridView.Rows[e.RowIndex];
            dtoKhachHang.MaKhachHang = row.Cells["MaKH"].Value.ToString().Trim();
            dtoKhachHang.HoTenKH = row.Cells["HoTenKH"].Value.ToString().Trim();
            dtoKhachHang.SDT = row.Cells["SDT"].Value.ToString().Trim();
            dtoKhachHang.Email = row.Cells["Email"].Value.ToString().Trim();
            dtoKhachHang.GioiTinh = row.Cells["GioiTinh"].Value.ToString().Trim();
            dtoKhachHang.CMND = row.Cells["CMND"].Value.ToString().Trim();
            EditBtn.Enabled = true;
            Deletebtn.Enabled = true;

        }
       

       

        private void EditBtn_Click(object sender, EventArgs e)
        {
            ucUpdateKhachHang1.LoadDTOKhachHang(dtoKhachHang);
            ucUpdateKhachHang1.Show();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (busXoaKH.XoaKhachHang(dtoKhachHang))
                MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bại");
        }
    }
}
