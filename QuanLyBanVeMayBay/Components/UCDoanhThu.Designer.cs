namespace QuanLyBanVeMayBay.Components
{
    partial class UCDoanhThu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDoanhThu));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DoanhThuChart = new Bunifu.DataViz.WinForms.BunifuDataViz();
            this.TimKiemBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuDatePicker2 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 33);
            this.panel2.TabIndex = 5;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(217, 25);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Báo cáo  doanh thu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.DoanhThuChart);
            this.panel1.Controls.Add(this.TimKiemBtn);
            this.panel1.Controls.Add(this.bunifuDatePicker2);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuDatePicker1);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 569);
            this.panel1.TabIndex = 6;
            // 
            // DoanhThuChart
            // 
            this.DoanhThuChart.animationEnabled = false;
            this.DoanhThuChart.AxisLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.DoanhThuChart.AxisXFontColor = System.Drawing.Color.Gray;
            this.DoanhThuChart.AxisXGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.DoanhThuChart.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DoanhThuChart.AxisYFontColor = System.Drawing.Color.Gray;
            this.DoanhThuChart.AxisYGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.DoanhThuChart.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DoanhThuChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.DoanhThuChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DoanhThuChart.Location = new System.Drawing.Point(3, 62);
            this.DoanhThuChart.Name = "DoanhThuChart";
            this.DoanhThuChart.Size = new System.Drawing.Size(1080, 504);
            this.DoanhThuChart.TabIndex = 37;
            this.DoanhThuChart.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme2;
            this.DoanhThuChart.Title = "";
            this.DoanhThuChart.Load += new System.EventHandler(this.DoanhThuChart_Load);
            // 
            // TimKiemBtn
            // 
            this.TimKiemBtn.AllowToggling = false;
            this.TimKiemBtn.AnimationSpeed = 200;
            this.TimKiemBtn.AutoGenerateColors = false;
            this.TimKiemBtn.BackColor = System.Drawing.Color.Transparent;
            this.TimKiemBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.TimKiemBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TimKiemBtn.BackgroundImage")));
            this.TimKiemBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TimKiemBtn.ButtonText = "Tìm";
            this.TimKiemBtn.ButtonTextMarginLeft = 0;
            this.TimKiemBtn.ColorContrastOnClick = 45;
            this.TimKiemBtn.ColorContrastOnHover = 45;
            this.TimKiemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.TimKiemBtn.CustomizableEdges = borderEdges1;
            this.TimKiemBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.TimKiemBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.TimKiemBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TimKiemBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.TimKiemBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.TimKiemBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.TimKiemBtn.ForeColor = System.Drawing.Color.White;
            this.TimKiemBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.TimKiemBtn.IconMarginLeft = 11;
            this.TimKiemBtn.IconPadding = 10;
            this.TimKiemBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.TimKiemBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.TimKiemBtn.IdleBorderRadius = 3;
            this.TimKiemBtn.IdleBorderThickness = 1;
            this.TimKiemBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.TimKiemBtn.IdleIconLeftImage = null;
            this.TimKiemBtn.IdleIconRightImage = null;
            this.TimKiemBtn.IndicateFocus = false;
            this.TimKiemBtn.Location = new System.Drawing.Point(911, 12);
            this.TimKiemBtn.Name = "TimKiemBtn";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(51)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(51)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.TimKiemBtn.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.TimKiemBtn.OnPressedState = stateProperties2;
            this.TimKiemBtn.Size = new System.Drawing.Size(93, 32);
            this.TimKiemBtn.TabIndex = 36;
            this.TimKiemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimKiemBtn.TextMarginLeft = 0;
            this.TimKiemBtn.UseDefaultRadiusAndThickness = true;
            this.TimKiemBtn.Click += new System.EventHandler(this.TimKiemBtn_Click);
            // 
            // bunifuDatePicker2
            // 
            this.bunifuDatePicker2.BorderRadius = 1;
            this.bunifuDatePicker2.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.bunifuDatePicker2.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker2.DisplayWeekNumbers = false;
            this.bunifuDatePicker2.DPHeight = 0;
            this.bunifuDatePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePicker2.FillDatePicker = false;
            this.bunifuDatePicker2.ForeColor = System.Drawing.Color.Purple;
            this.bunifuDatePicker2.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker2.Icon")));
            this.bunifuDatePicker2.IconColor = System.Drawing.Color.Purple;
            this.bunifuDatePicker2.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker2.Location = new System.Drawing.Point(636, 12);
            this.bunifuDatePicker2.MinimumSize = new System.Drawing.Size(217, 32);
            this.bunifuDatePicker2.Name = "bunifuDatePicker2";
            this.bunifuDatePicker2.Size = new System.Drawing.Size(217, 32);
            this.bunifuDatePicker2.TabIndex = 34;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(473, 16);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(159, 24);
            this.bunifuCustomLabel2.TabIndex = 33;
            this.bunifuCustomLabel2.Text = "Thời gian kết thúc";
            // 
            // bunifuDatePicker1
            // 
            this.bunifuDatePicker1.BorderRadius = 1;
            this.bunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.bunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.DisplayWeekNumbers = false;
            this.bunifuDatePicker1.DPHeight = 0;
            this.bunifuDatePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePicker1.FillDatePicker = false;
            this.bunifuDatePicker1.ForeColor = System.Drawing.Color.Purple;
            this.bunifuDatePicker1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker1.Icon")));
            this.bunifuDatePicker1.IconColor = System.Drawing.Color.Purple;
            this.bunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker1.Location = new System.Drawing.Point(181, 12);
            this.bunifuDatePicker1.MinimumSize = new System.Drawing.Size(217, 32);
            this.bunifuDatePicker1.Name = "bunifuDatePicker1";
            this.bunifuDatePicker1.Size = new System.Drawing.Size(217, 32);
            this.bunifuDatePicker1.TabIndex = 32;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(18, 16);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(157, 24);
            this.bunifuCustomLabel7.TabIndex = 31;
            this.bunifuCustomLabel7.Text = "Thời gian bắt đầu";
            // 
            // UCDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCDoanhThu";
            this.Size = new System.Drawing.Size(1086, 602);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton TimKiemBtn;
        private Bunifu.DataViz.WinForms.BunifuDataViz DoanhThuChart;
    }
}
