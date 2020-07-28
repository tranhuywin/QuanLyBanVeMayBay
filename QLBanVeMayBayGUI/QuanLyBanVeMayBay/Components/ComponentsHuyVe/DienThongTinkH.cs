using System;
using System.Windows.Forms;
using DTO_QuanLy;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Data;

namespace QuanLyBanVeMayBay.Components.ComponentsHuyVe
{
    public partial class DienThongTinkH : UserControl
    {
        //declare url, client
        static HttpClient client = new HttpClient();
        private string URLAddress = Properties.Settings.Default.URLAddress;
        // end
        DTO_KhachHang dtoKhachHang = new DTO_KhachHang { CMND = "" };
        DTO_VeChuyenBay dtoVeChuyenbay = new DTO_VeChuyenBay { MaVeChuyenBay = "" };
        public DienThongTinkH()
        {
            InitializeComponent();
            // innit client
            client.BaseAddress = new Uri(URLAddress);   // init base address
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // end
        }
        public class ObjectPostHuyVe
        {
            public DTO_KhachHang dtoKhachHang { get; set; }
            public DTO_VeChuyenBay dtoVeChuyenBay { get; set; }
        }
        private async void TimKiemBtn_Click(object sender, EventArgs e)
        {
            if (CMNDTxt.Text != "" && MaVeChuyenBayTxt.Text != "")
            {
                dtoKhachHang.CMND = CMNDTxt.Text;
                dtoVeChuyenbay.MaVeChuyenBay = MaVeChuyenBayTxt.Text;

                try
                {
                    ObjectPostHuyVe Obj = new ObjectPostHuyVe { dtoKhachHang = dtoKhachHang, dtoVeChuyenBay = dtoVeChuyenbay };
                    //start get value
                    String JSONresult = "{}"; // init
                    HttpResponseMessage response = await client.PostAsJsonAsync("huyve/load-ve-may-bay-huy", Obj); //Get, Post, Put, Delete method
                    if (response.IsSuccessStatusCode)   //response success
                    {
                        JSONresult = await response.Content.ReadAsStringAsync();
                    }
                    JSONresult = JsonConvert.DeserializeObject<string>(JSONresult); // remove backslash from json string
                    DataTable dtHuyVe = (DataTable)JsonConvert.DeserializeObject(JSONresult, (typeof(DataTable)));   //fill json to datatable
                                                                                                                     //end

                    HuyVeDataGridView.DataSource = dtHuyVe;
                }
                catch
                {
                    MessageBox.Show("Không có vé như thông tin");
                }
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
            MessageBox.Show("Bạn đã chọn vé để huỷ có mã vé là: " + dtoVeChuyenbay.MaVeChuyenBay);
        }

        private void HuyVeBtn_Click(object sender, EventArgs e)
        {
            // start get value
            var responseDelete = client.PostAsJsonAsync("/huyve/huy-ve", dtoVeChuyenbay).Result;     // gui DTO user len web sever bang Method POST, va nhan ket qua tra ve
            var delete = responseDelete.Content.ReadAsStringAsync();   // khong biet
            //end
            bool DeleteVe = bool.Parse(delete.Result);
            //DeleteVe = busHuyVe.DeleteVeChuyenBay(dtoVeChuyenbay);
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
