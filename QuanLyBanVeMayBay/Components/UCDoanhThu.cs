using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay.Components
{
    public partial class UCDoanhThu : UserControl
    {
        public UCDoanhThu()
        {
            InitializeComponent();
        }

        private void DoanhThuChart_Load(object sender, EventArgs e)
        {
            var r = new Random();

            var canvas = new Bunifu.DataViz.WinForms.Canvas();

            var datapoint = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);

            datapoint.addLabely("Jan", r.Next(10, 100).ToString());
            datapoint.addLabely("Feb", r.Next(10, 100).ToString());
            datapoint.addLabely("Mar", r.Next(10, 100).ToString());
            datapoint.addLabely("Apr", r.Next(10, 100).ToString());
            datapoint.addLabely("May", r.Next(10, 100).ToString());
            datapoint.addLabely("Jun", r.Next(10, 100).ToString());
            datapoint.addLabely("Jul", r.Next(10, 100).ToString());
            datapoint.addLabely("Aug", r.Next(10, 100).ToString());
            datapoint.addLabely("Sep", r.Next(10, 100).ToString());
            datapoint.addLabely("Oct", r.Next(10, 100).ToString());
            datapoint.addLabely("Nov", r.Next(10, 100).ToString());
            datapoint.addLabely("Dec", r.Next(10, 100).ToString());

            // Add data sets to canvas

            canvas.addData(datapoint);

            //render canvas

            DoanhThuChart.Render(canvas);
        }

        private void TimKiemBtn_Click(object sender, EventArgs e)
        {
            var r = new Random();

            var canvas = new Bunifu.DataViz.WinForms.Canvas();

            var datapoint = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);
            for (int i = 1; i < 31; i++)
            {
                datapoint.addLabely(i.ToString(), r.Next(10, 100).ToString());
            }

            // Add data sets to canvas

            canvas.addData(datapoint);

            //render canvas

            DoanhThuChart.Render(canvas);

        }

    }
}
