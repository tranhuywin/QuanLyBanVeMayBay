using DTO_QuanLy;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay.Components.ComponentsTimKiemKH
{
    public partial class TimKiemKH : UserControl
    {
        //declare url, client
        static HttpClient client = new HttpClient();
        private string URLAddress = Properties.Settings.Default.URLAddress;
        // end
        public TimKiemKH()
        {
            InitializeComponent();
            // innit client
            client.BaseAddress = new Uri(URLAddress);   // init base address
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // end
        }

        private bool KiemTraThongTinTextBox()
        {
            return true;
        }

        private async void TimKiemBtn_Click_1(object sender, EventArgs e)
        {
            if (KiemTraThongTinTextBox())
            {
                DTO_KhachHang dtoKhachHang = new DTO_KhachHang { CMND = CMNDTxt.Text, HoTenKH = HoTenKHTxt.Text, Email = EmailTxt.Text, SDT = SDTTxt.Text, GioiTinh = "", MaKhachHang = "" };

                //start get value
                String JSONresult = "{}"; // init
                HttpResponseMessage response = await client.PostAsJsonAsync("timkiemkh/tim-khach-hang", dtoKhachHang); //Get, Post, Put, Delete method
                if (response.IsSuccessStatusCode)   //response success
                {
                    JSONresult = await response.Content.ReadAsStringAsync();
                }
                JSONresult = JsonConvert.DeserializeObject<string>(JSONresult); // remove backslash from json string
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(JSONresult, (typeof(DataTable)));   //fill json to datatable
                //end

                KhachHangDataGridView.DataSource = dt;
            }
        }
    }
}
