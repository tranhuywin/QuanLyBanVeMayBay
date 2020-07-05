using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuTextbox;
using BUS_QuanLy.BUS_TimKiemKH;
using DTO_QuanLy;

namespace QuanLyBanVeMayBay.Components.ComponentsTimKiemKH
{
    public partial class TimKiemKH : UserControl
    {
        private String _hoten = "";
        private String _email = "";
        private String _sdt = "";
        private String _cmnd = "";

        private DataSet ds = new DataSet();

        BUS_TimKiemKH bus_TimKiemKH;
        List<DTO_KhachHang> dto_KhachHang;

        public TimKiemKH()
        {
            InitializeComponent();
        }

        private void HoTenKHTxt_TextChange(object sender, EventArgs e)
        {
            _hoten = HoTenKHTxt.Text.ToString();
            _email = EmailTxt.Text.ToString();
            _sdt = SDTTxt.Text.ToString();
            _cmnd = CMNDTxt.Text.ToString();
            ds.Clear();
            if (hasValidSearchField())
            {
                bus_TimKiemKH.LoadDataTableTimKiemKH(dto_KhachHang, HoTenKHTxt.Text,
                    EmailTxt.Text, SDTTxt.Text, CMNDTxt.Text);
            }
        }

        private void EmailTxt_TextChange(object sender, EventArgs e)
        {
            _hoten = HoTenKHTxt.Text.ToString();
            _email = EmailTxt.Text.ToString();
            _sdt = SDTTxt.Text.ToString();
            _cmnd = CMNDTxt.Text.ToString();
            ds.Clear();
            if (hasValidSearchField())
            {
                bus_TimKiemKH.LoadDataTableTimKiemKH(dto_KhachHang, HoTenKHTxt.Text,
                    EmailTxt.Text, SDTTxt.Text, CMNDTxt.Text);
            }
        }

        private void SDTTxt_TextChange(object sender, EventArgs e)
        {
            _hoten = HoTenKHTxt.Text.ToString();
            _email = EmailTxt.Text.ToString();
            _sdt = SDTTxt.Text.ToString();
            _cmnd = CMNDTxt.Text.ToString();
            ds.Clear();
            if (hasValidSearchField())
            {
                bus_TimKiemKH.LoadDataTableTimKiemKH(dto_KhachHang, HoTenKHTxt.Text,
                    EmailTxt.Text, SDTTxt.Text, CMNDTxt.Text);
            }
        }

        private void CMNDTxt_TextChange(object sender, EventArgs e)
        {
            _hoten = HoTenKHTxt.Text.ToString();
            _email = EmailTxt.Text.ToString();
            _sdt = SDTTxt.Text.ToString();
            _cmnd = CMNDTxt.Text.ToString();
            ds.Clear();
            if (hasValidSearchField())
            {
                bus_TimKiemKH.LoadDataTableTimKiemKH(dto_KhachHang, HoTenKHTxt.Text,
                    EmailTxt.Text, SDTTxt.Text, CMNDTxt.Text);
            }
        }

        private bool hasValidSearchField()
        {
            if (isEmpty(HoTenKHTxt) && isEmpty(EmailTxt) && isEmpty(SDTTxt) && isEmpty(CMNDTxt))
                return false;
            return true;
        }

        private bool isEmpty(BunifuTextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return true;
            else return false;
        }

    }
}
