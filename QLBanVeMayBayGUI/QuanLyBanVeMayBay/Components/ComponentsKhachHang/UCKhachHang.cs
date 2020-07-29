using System;
using System.Data;
using System.Windows.Forms;
using DTO_QuanLy;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace QuanLyBanVeMayBay.Components.ComponentsKhachHang
{
    public partial class UCKhachHang : UserControl
    {
        DTO_KhachHang dtoKhachHang = new DTO_KhachHang();
        //declare url, client
        static HttpClient client = new HttpClient();
        private string URLAddress = Properties.Settings.Default.URLAddress;
        // end
        private void UCKhachHang_Load(object sender, EventArgs e)
        {
        }
        public UCKhachHang()
        {
            InitializeComponent();
            // innit client
            client.BaseAddress = new Uri(URLAddress);   // init base address
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // end

            // loi :D
            ucUpdateKhachHang1.Show();
            ucChinhSuaKH1.Show();
            ucUpdateKhachHang1.Hide();
            ucChinhSuaKH1.Hide();
        }
        private void Newbtn_Click_1(object sender, EventArgs e)
        {
            ucChinhSuaKH1.Show();
        }

        private async void SearchBtn_Click_1(object sender, EventArgs e)
        {
            DTO_KhachHang dtoKhachHang1 = new DTO_KhachHang { HoTenKH = HoTenKHTxt.Text, CMND = CMNDTxt.Text };
            //start get value
            String JSONresult = "{}"; // init
            HttpResponseMessage response = await client.PostAsJsonAsync("khachHang/loadKhachHangCombobox", dtoKhachHang1); //Get, Post, Put, Delete method
            if (response.IsSuccessStatusCode)   //response success
            {
                JSONresult = await response.Content.ReadAsStringAsync();
            }
            JSONresult = JsonConvert.DeserializeObject<string>(JSONresult); // remove backslash from json string
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(JSONresult, (typeof(DataTable)));   //fill json to datatable
            //end
            KhachHangDataGridView.DataSource = dt;
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
            // start get value
            var responseKhachHang = client.PostAsJsonAsync("/khachhang/xoakhachhang", dtoKhachHang).Result;     // gui DTO user len web sever bang Method POST, va nhan ket qua tra ve
            var Detele = responseKhachHang.Content.ReadAsStringAsync();   // khong biet
            // end

            bool DeteleKH = bool.Parse(Detele.Result);
            if (DeteleKH)
                MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bại");
        }
    }
}
