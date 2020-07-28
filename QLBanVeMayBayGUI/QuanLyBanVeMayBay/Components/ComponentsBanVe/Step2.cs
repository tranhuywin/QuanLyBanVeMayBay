using System;
using System.Data;
using System.Windows.Forms;
using DTO_QuanLy;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace QuanLyBanVeMayBay.Components.ComponentsBanVe
{
    public partial class Step2 : UserControl
    {
        //declare url, client
        static HttpClient client = new HttpClient();
        private string URLAddress = Properties.Settings.Default.URLAddress;
        // end

        public DTO_ChuyenBay dtoChuyenBayXuatPhat = new DTO_ChuyenBay { NgayGio = "", ThoiGianBay = "", SoGheHang1 = 0, SoGheHang2 = 0 };
        public DTO_TuyenBay dtoTuyenBayXuatPhat = new DTO_TuyenBay { SanBayDi = "", SanBayDen = "" };

        public bool KhuHoi;
        public DTO_ChuyenBay dtoChuyenBayKhuHoi = new DTO_ChuyenBay { NgayGio = "", ThoiGianBay = "", SoGheHang1 = 0, SoGheHang2 = 0 };
        public DTO_TuyenBay dtoTuyenBayKhuHoi = new DTO_TuyenBay { SanBayDi = "", SanBayDen = "" };

        public DTO_PhieuDatCho dtoPhieuDatChoXuatPhat = new DTO_PhieuDatCho { MaChuyenBay = "", MaPhieu = "", NgayDat = DateTime.Today.ToString() };
        public DTO_PhieuDatCho dtoPhieuDatChoKhuHoi = new DTO_PhieuDatCho { MaChuyenBay = "", MaPhieu = "", NgayDat = DateTime.Today.ToString() };

        private DataTable dtXuatPhat, dtKhuHoi;
        public Step2()
        {
            InitializeComponent();
            // innit client
            client.BaseAddress = new Uri(URLAddress);   // init base address
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // end
        }
        public class ObjectPostLoadVe
        {
            public DTO_ChuyenBay dtochuyenbay { get; set; }
            public DTO_TuyenBay dtoTuyenBay { get; set; }
        }

        public async void Step2_Load()
        {
            ObjectPostLoadVe objLoadVe = new ObjectPostLoadVe { dtochuyenbay = dtoChuyenBayXuatPhat, dtoTuyenBay = dtoTuyenBayXuatPhat };
            //start get value
            String JSONresult = "{}"; // init
            HttpResponseMessage response = await client.PostAsJsonAsync("banve/step2/load-ve-may-bay-xuat-phat", objLoadVe); //Get, Post, Put, Delete method
            if (response.IsSuccessStatusCode)   //response success
            {
                JSONresult = await response.Content.ReadAsStringAsync();
            }
            JSONresult = JsonConvert.DeserializeObject<string>(JSONresult); // remove backslash from json string
            dtXuatPhat = (DataTable)JsonConvert.DeserializeObject(JSONresult, (typeof(DataTable)));   //fill json to datatable
            //end

            VemayBayDataGridView.DataSource = dtXuatPhat;
            if (KhuHoi)     // an va hien button chon ve khu hoi
            {
                TiepBtn.Visible = true;
            }
            else
            {
                TiepBtn.Visible = false;
            }
        }

        private void XongBtn_Click(object sender, EventArgs e)
        {
            if (KhuHoi && dtoPhieuDatChoXuatPhat.MaChuyenBay != "" && dtoPhieuDatChoKhuHoi.MaChuyenBay != "")
            {
                MessageBox.Show("Bạn đã chọn vé xuất phát có mã chuyến bay là : " + dtoPhieuDatChoXuatPhat.MaChuyenBay);
                MessageBox.Show("Bạn đã chọn vé khứ hồi có mã chuyến bay là : " + dtoPhieuDatChoKhuHoi.MaChuyenBay);
            }
            else if (dtoPhieuDatChoXuatPhat.MaChuyenBay != "")
            {
                MessageBox.Show("Bạn đã chọn vé xuất phát có mã chuyến bay là : " + dtoPhieuDatChoXuatPhat.MaChuyenBay);
            }
            else
                MessageBox.Show("Vui lòng chọn vé chuyến bay");
        }

        private async void TiepBtn_Click(object sender, EventArgs e)  // Button doi chon ve khu hoi va ve xuat phat
        {
            if (TiepBtn.Text == "Chọn vé khứ hồi")
            {
                XuatPhatLabel.Visible = false; // an lable xuat phat
                KhuHoiLable.Visible = true; // hien lable khu hoi
                TiepBtn.Text = "Trở lại";

                ObjectPostLoadVe objLoadVe = new ObjectPostLoadVe { dtochuyenbay = dtoChuyenBayKhuHoi, dtoTuyenBay = dtoTuyenBayKhuHoi };
                //start get value
                String JSONresult = "{}"; // init
                HttpResponseMessage response = await client.PostAsJsonAsync("banve/step2/load-ve-may-bay-khu-hoi", objLoadVe); //Get, Post, Put, Delete method
                if (response.IsSuccessStatusCode)   //response success
                {
                    JSONresult = await response.Content.ReadAsStringAsync();
                }
                JSONresult = JsonConvert.DeserializeObject<string>(JSONresult); // remove backslash from json string
                dtKhuHoi = (DataTable)JsonConvert.DeserializeObject(JSONresult, (typeof(DataTable)));   //fill json to datatable
                //end

                VemayBayDataGridView.DataSource = dtKhuHoi;
            }
            else
            {
                XuatPhatLabel.Visible = true; // hien lable xuat phat
                KhuHoiLable.Visible = false; // an lable khu hoi
                TiepBtn.Text = "Chọn vé khứ hồi";
                VemayBayDataGridView.DataSource = dtXuatPhat;
            }
        }

        private void VemayBayDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TiepBtn.Text == "Chọn vé khứ hồi")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.VemayBayDataGridView.Rows[e.RowIndex];
                    dtoPhieuDatChoXuatPhat.MaChuyenBay = row.Cells["Mã chuyến bay"].Value.ToString().Trim();
                }
                MessageBox.Show("Bạn đã chọn chuyến bay xuất phát có mã: " + dtoPhieuDatChoXuatPhat.MaChuyenBay);
            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.VemayBayDataGridView.Rows[e.RowIndex];
                    dtoPhieuDatChoKhuHoi.MaChuyenBay = row.Cells["Mã chuyến bay"].Value.ToString().Trim();
                }
                MessageBox.Show("Bạn đã chọn chuyến bay khứ hồi có mã: " + dtoPhieuDatChoKhuHoi.MaChuyenBay);
            }
        }
    }
}
