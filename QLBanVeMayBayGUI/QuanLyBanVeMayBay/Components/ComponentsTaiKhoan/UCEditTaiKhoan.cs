using DTO_QuanLy;
using System;
using System.Data;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace QuanLyBanVeMayBay.Components.ComponentsTimKiemVe
{
    public partial class TimKiemVe : UserControl
    {
        //declare url, client
        static HttpClient client = new HttpClient();
        private string URLAddress = Properties.Settings.Default.URLAddress;
        // end
        public DTO_User dtoUser = new DTO_User();
        //private BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        private DataTable dt;
        public TimKiemVe()
        {
            InitializeComponent();
            // innit client
            client.BaseAddress = new Uri(URLAddress);   // init base address
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // end
        }


        private void AnHienMatKhauCheckBox_OnChange(object sender, EventArgs e) // an hien mat khau
        {
            if (!AnHienMatKhauCheckBox.Checked)
            {
                MatKhauText.UseSystemPasswordChar = false;
            }
            else
                MatKhauText.UseSystemPasswordChar = true;
        }

        private void TimKiemVe_Load(object sender, EventArgs e) // load form
        {
            TaiKhoanTxt.Text = dtoUser.User;
            MatKhauText.Text = dtoUser.Password;
            MatKhauText.UseSystemPasswordChar = true;
        }
        public async void LoadUser() // load user tu main
        {
            TaiKhoanTxt.Text = dtoUser.User;
            MatKhauText.Text = dtoUser.Password;

            //start get value
            String JSONresult = "{}"; // init
            HttpResponseMessage response = await client.PostAsJsonAsync("taikhoan/load-tai-khoan", dtoUser); //Get, Post, Put, Delete method
            if (response.IsSuccessStatusCode)   //response success
            {
                JSONresult = await response.Content.ReadAsStringAsync();
            }
            JSONresult = JsonConvert.DeserializeObject<string>(JSONresult); // remove backslash from json string
            dt = (DataTable)JsonConvert.DeserializeObject(JSONresult, (typeof(DataTable)));   //fill json to datatable
            //end

            //dt = busTaiKhoan.LoadTaiKhoan(dtoUser);
            HoTenTxt.Text = (string)dt.Rows[0][0];
            DiaChiTxt.Text = (string)dt.Rows[0][1];
            CMNDTxt.Text = (string)dt.Rows[0][2];
            string birthdate = dt.Rows[0][3].ToString();
            NgaySinhDateTimePicker.Value = DateTime.Parse(birthdate);
        }
        //enable textbox to edit
        private void HoTenBtn_Click(object sender, EventArgs e)
        {
            if (HoTenTxt.Enabled)
                HoTenTxt.Enabled = false;
            else
                HoTenTxt.Enabled = true;
        }

        private void CMNDBtn_Click(object sender, EventArgs e)
        {
            if (CMNDTxt.Enabled)
                CMNDTxt.Enabled = false;
            else
                CMNDTxt.Enabled = true;
        }

        private void NgaySinhBtn_Click(object sender, EventArgs e)
        {
            if (NgaySinhDateTimePicker.Enabled)
                NgaySinhDateTimePicker.Enabled = false;
            else
                NgaySinhDateTimePicker.Enabled = true;
        }

        private void DiaChiBtn_Click(object sender, EventArgs e)
        {
            if (DiaChiTxt.Enabled)
                DiaChiTxt.Enabled = false;
            else
                DiaChiTxt.Enabled = true;
        }

        private void TaiKhoanBtn_Click(object sender, EventArgs e)
        {
            if (TaiKhoanTxt.Enabled)
                TaiKhoanTxt.Enabled = false;
            else
                TaiKhoanTxt.Enabled = true;
        }

        private void MatKhauBtn_Click(object sender, EventArgs e)
        {
            if (MatKhauText.Enabled)
                MatKhauText.Enabled = false;
            else
                MatKhauText.Enabled = true;
        }

        private void LuuBtn_Click(object sender, EventArgs e) // luu thong tin tai khoan
        {
            dtoUser.HoTen = HoTenTxt.Text;
            dtoUser.NgaySinh = NgaySinhDateTimePicker.Value.ToString();
            dtoUser.DiaChi = DiaChiTxt.Text;
            dtoUser.CMND = CMNDTxt.Text;

            // start get value
            var response = client.PostAsJsonAsync("/taikhoan/luu-tai-khoan", dtoUser).Result;     // gui DTO user len web sever bang Method POST, va nhan ket qua tra ve
            var luutaiKhoan = response.Content.ReadAsStringAsync();   // khong biet
            // end

            bool luu;
            luu = bool.Parse(luutaiKhoan.Result);
            if (!luu)
                MessageBox.Show("Lưu thông tin tài khoản thất bại");
            else
                MessageBox.Show("Lưu thông tin tài khoản thành công");
        }
    }
}
