using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy.BUS_HuyVe;
using DTO_QuanLy;

namespace QuanLyBanVeMayBay.Components.ComponentsHuyVe
{
    public partial class DienThongTinkH : UserControl
    {
        BUS_HuyVe busHuyVe = new BUS_HuyVe();
        DTO_KhachHang dtoKhachHang = new DTO_KhachHang { CMND = "" };
        DTO_VeChuyenBay dtoVeChuyenbay = new DTO_VeChuyenBay { MaVeChuyenBay = "" };
        public DienThongTinkH()
        {
            InitializeComponent();
        }

        private void TimKiemBtn_Click(object sender, EventArgs e)
        {
            if(CMNDTxt.Text != "" && MaVeChuyenBayTxt.Text != "")
            {
                dtoKhachHang.CMND = CMNDTxt.Text;
                dtoVeChuyenbay.MaVeChuyenBay = MaVeChuyenBayTxt.Text;
                HuyVeDataGridView.DataSource = busHuyVe.LoadDataGridViewHuyVe(dtoKhachHang, dtoVeChuyenbay);
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!!");
            }
        }

        private void HuyVeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.HuyVeDataGridView.Rows[e.RowIndex];
                dtoVeChuyenbay.MaVeChuyenBay = row.Cells["Mã vé chuyến bay"].Value.ToString().Trim();
            }
            MessageBox.Show("Bạn đã chọn vé để huỷ có mã vé là: "+dtoVeChuyenbay.MaVeChuyenBay);
        }

        private void HuyVeBtn_Click(object sender, EventArgs e)
        {
            bool DeleteVe = busHuyVe.DeleteVeChuyenBay(dtoVeChuyenbay);
            if (DeleteVe)
            {
                MessageBox.Show("Xoá vé có mã " + dtoVeChuyenbay.MaVeChuyenBay + " thành công");
            }
            else
            {
                MessageBox.Show("Xoá vé có mã " + dtoVeChuyenbay.MaVeChuyenBay + " thất bại");
            }
        }
    }
}
