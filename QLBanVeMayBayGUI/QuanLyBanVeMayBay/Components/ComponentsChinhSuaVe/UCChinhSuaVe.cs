using System;
using System.Data;
using System.Windows.Forms;
using DTO_QuanLy;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace QuanLyBanVeMayBay.Components.ComponentsChinhSuaVe
{
    public partial class UCChinhSuaVe : UserControl
    {
        //declare url, client
        static HttpClient client = new HttpClient();
        private string URLAddress = Properties.Settings.Default.URLAddress;
        // end
        public UCChinhSuaVe()
        {
            InitializeComponent();
            // innit client
            client.BaseAddress = new Uri(URLAddress);   // init base address
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // end
        }

        private void UCChinhSuaVe_Load(object sender, EventArgs e)
        {

        }
        DTO_TuyenBay dtoTuyenBay = new DTO_TuyenBay();
        DTO_ChiTietChuyenBay dtoChiTietChuyenBay = new DTO_ChiTietChuyenBay();
        DTO_ChuyenBay dtoChuyenBay = new DTO_ChuyenBay();

        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            dtoChuyenBay.MaChuyenBay = MaChuyenBayTxt.Text;
            //start get value
            String JSONresult = "{}"; // init
            HttpResponseMessage response = await client.PostAsJsonAsync("chinhsuave/GetTableVe", dtoChuyenBay); //Get, Post, Put, Delete method
            if (response.IsSuccessStatusCode)   //response success
            {
                JSONresult = await response.Content.ReadAsStringAsync();
            }
            JSONresult = JsonConvert.DeserializeObject<string>(JSONresult); // remove backslash from json string
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(JSONresult, (typeof(DataTable)));   //fill json to datatable
            //end
            VeDataGridView.DataSource = dt;
            VeDataGridView.Show();
        }


        private void Newbtn_Click(object sender, EventArgs e)
        {
            ucChinhSuaChuyenBay1.LoadMaChuyenBay();
            ucChinhSuaChuyenBay1.Show();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            ucEditChuyenBay1.LoadDTOEditChuyenBay(dtoChiTietChuyenBay, dtoChuyenBay, dtoTuyenBay);
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
