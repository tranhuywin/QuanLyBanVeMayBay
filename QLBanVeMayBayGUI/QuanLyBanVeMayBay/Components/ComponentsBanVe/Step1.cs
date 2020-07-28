using System;
using System.Data;
using System.Windows.Forms;
using DTO_QuanLy;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;

namespace QuanLyBanVeMayBay.Components.ComponentsBanVe
{
    public partial class Step1 : UserControl
    {
        //innit 
        static HttpClient client = new HttpClient();
        private string URLAddress = Properties.Settings.Default.URLAddress;
        // end

        public DTO_ChuyenBay dtoChuyenBayXuatPhat = new DTO_ChuyenBay { NgayGio = "", ThoiGianBay ="", SoGheHang1 = 0, SoGheHang2 = 0};
        public DTO_TuyenBay dtoTuyenBayXuatPhat = new DTO_TuyenBay {SanBayDi = "", SanBayDen = "" };

        public bool KhuHoi = false;
        public DTO_ChuyenBay dtoChuyenBayKhuHoi = new DTO_ChuyenBay { NgayGio = "", ThoiGianBay = "", SoGheHang1 = 0, SoGheHang2 = 0 };
        public DTO_TuyenBay dtoTuyenBayKhuHoi = new DTO_TuyenBay { SanBayDi = "", SanBayDen = "" };
        public bool ClickNextStep;
        public Step1()
        {
            InitializeComponent();
            XuatPhatTime.Format = DateTimePickerFormat.Time; // tao thoi gian xuat phat
            XuatPhatTime.Value = DateTime.Parse("12:00 AM");
            XuatPhatTime.ShowUpDown = true;
            KhuHoiTime.Format = DateTimePickerFormat.Time; // tao thoi gian khu hoi
            KhuHoiTime.ShowUpDown = true;
            KhuHoiTime.Value = DateTime.Parse("12:00 AM");
            ConstructorDiaChiComBoBox();
        }

        private async void ConstructorDiaChiComBoBox()
        {
            client.BaseAddress = new Uri(URLAddress);   // init base address
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //start get value
            String JSONresultXuatPhat = "{}"; // init
            HttpResponseMessage responseXuatPhat = await client.GetAsync("banve/step1/Load-San-Bay-ComboBox"); //Get, Post, Put, Delete method
            if (responseXuatPhat.IsSuccessStatusCode)   //response success
            {
                JSONresultXuatPhat = await responseXuatPhat.Content.ReadAsStringAsync();
            }
            JSONresultXuatPhat = JsonConvert.DeserializeObject<string>(JSONresultXuatPhat); // remove backslash from json string
            DataTable dtXuatPhat = (DataTable)JsonConvert.DeserializeObject(JSONresultXuatPhat, (typeof(DataTable)));   //fill json to datatable
            //end

            XuatPhatDrDwn.DataSource = dtXuatPhat; // load du lieu tu BUS len combo box
            XuatPhatDrDwn.DisplayMember = "TenSanBay";
            XuatPhatDrDwn.ValueMember = "TenSanBay";

            //start get value
            String JSONresultNoiDen = "{}"; // init
            HttpResponseMessage responseNoiDen = await client.GetAsync("banve/step1/Load-San-Bay-ComboBox"); //Get, Post, Put, Delete method
            if (responseNoiDen.IsSuccessStatusCode)   //response success
            {
                JSONresultNoiDen = await responseNoiDen.Content.ReadAsStringAsync();
            }
            JSONresultNoiDen = JsonConvert.DeserializeObject<string>(JSONresultNoiDen); // remove backslash from json string
            DataTable dtNoiDen = (DataTable)JsonConvert.DeserializeObject(JSONresultNoiDen, (typeof(DataTable)));   //fill json to datatable
            //end
            NoiDenDrpDwn.DataSource = dtNoiDen;// load du lieu tu BUS len combo box
            NoiDenDrpDwn.DisplayMember = "TenSanBay";
            NoiDenDrpDwn.ValueMember = "TenSanBay";
        }

        private void KhuHoiCheckBox_OnChange(object sender, EventArgs e)    // check box khu hoi bat,tat time va date
        {
            if (KhuHoiTime.Enabled || KhuHoiDate.Enabled)
            {
                KhuHoiTime.Enabled = false;
                KhuHoiDate.Enabled = false;
            }
            else
            {
                KhuHoiTime.Enabled = true;
                KhuHoiDate.Enabled = true;
            }
        }

        private void KhuHoiDate_ValueChanged(object sender, EventArgs e)    // kiem tra ngay khu hoi nhap vao phai lon hon ngay xuat phat
        {
            if(KhuHoiDate.Value < XuatPhatDate.Value)
            {
                MessageBox.Show("Ngày khứ hồi phải lớn hơn ngày xuất phát !!!");
            }
            
        }

        private void NoiDenDrpDwn_SelectedIndexChanged(object sender, EventArgs e)  // kiem tra noi den va noi xuat phat co trung nhau khong
        {
            if(NoiDenDrpDwn.SelectedValue.ToString() == XuatPhatDrDwn.SelectedValue.ToString())
            {
                MessageBox.Show("Nơi đến phải khác nơi xuất phát !!!");
            }
        }

        private void NextStep2Btn_Click(object sender, EventArgs e)         //truyen dtoChuyenBay, dtoTuyenBay sang step 2 de loc thong tin ve
        {
            int hang1 = 0, hang2 = 0;
            if (HangVeDrpDwn.Text == "1")
                hang1 = int.Parse(HangVeDrpDwn.Text);
            else hang2 = int.Parse(HangVeDrpDwn.Text);
            dtoChuyenBayXuatPhat = new DTO_ChuyenBay { NgayGio = XuatPhatDate.Text, ThoiGianBay = XuatPhatTime.Text, SoGheHang1 = hang1, SoGheHang2 = hang2 };
            dtoTuyenBayXuatPhat = new DTO_TuyenBay { SanBayDi = XuatPhatDrDwn.Text, SanBayDen = NoiDenDrpDwn.Text };
            if (KhuHoiCheckBox.Checked)
            {
                KhuHoi = true;
                dtoChuyenBayKhuHoi = new DTO_ChuyenBay { NgayGio = KhuHoiDate.Text, ThoiGianBay = KhuHoiTime.Text, SoGheHang1 = hang1, SoGheHang2 = hang2 };
                dtoTuyenBayKhuHoi = new DTO_TuyenBay { SanBayDi = NoiDenDrpDwn.Text, SanBayDen = XuatPhatDrDwn.Text };
            }
            MessageBox.Show("Vui lòng tới bước 2 để điền thông tin");
        }

        private void SoGheTxt_KeyPress(object sender, KeyPressEventArgs e)  //Chi dc nhap so, nhap chu thi thong bao
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Vui long nhap so !!!");
            }
        }
    }
}
