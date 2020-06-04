namespace QuanLyBanVeMayBay.Main
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.Header = new System.Windows.Forms.Panel();
            this.ExitBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DoanhThuPanel = new System.Windows.Forms.Panel();
            this.DoanhThuLabel = new System.Windows.Forms.Label();
            this.TTKhachHangPanel = new System.Windows.Forms.Panel();
            this.TTKhachHangLabel = new System.Windows.Forms.Label();
            this.HuyVePanel = new System.Windows.Forms.Panel();
            this.HuyVeLabel = new System.Windows.Forms.Label();
            this.BanVePanel = new System.Windows.Forms.Panel();
            this.BanVeLabel = new System.Windows.Forms.Label();
            this.ThongTinPanel = new System.Windows.Forms.Panel();
            this.ThongTinLabel = new System.Windows.Forms.Label();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.ucttKhachHang = new QuanLyBanVeMayBay.Components.UCTTKhachHang();
            this.ucThongTin = new QuanLyBanVeMayBay.Components.UCThongTincs();
            this.ucHuyVe = new QuanLyBanVeMayBay.Components.UCHuyVe();
            this.ucDoanhThu = new QuanLyBanVeMayBay.Components.UCDoanhThu();
            this.ucBanve = new QuanLyBanVeMayBay.Components.UCBanve();
            this.home1 = new QuanLyBanVeMayBay.Components.Home1();
            this.TimkiemPanel = new System.Windows.Forms.Panel();
            this.TimkiemLabel = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.panel2.SuspendLayout();
            this.DoanhThuPanel.SuspendLayout();
            this.TTKhachHangPanel.SuspendLayout();
            this.HuyVePanel.SuspendLayout();
            this.BanVePanel.SuspendLayout();
            this.ThongTinPanel.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.TimkiemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.Header.Controls.Add(this.ExitBtn);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(898, 37);
            this.Header.TabIndex = 0;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // ExitBtn
            // 
            this.ExitBtn.AllowToggling = false;
            this.ExitBtn.AnimationSpeed = 200;
            this.ExitBtn.AutoGenerateColors = false;
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ExitBtn.ButtonText = "Exit";
            this.ExitBtn.ButtonTextMarginLeft = 0;
            this.ExitBtn.ColorContrastOnClick = 45;
            this.ExitBtn.ColorContrastOnHover = 45;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ExitBtn.CustomizableEdges = borderEdges1;
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExitBtn.DisabledBorderColor = System.Drawing.Color.Empty;
            this.ExitBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ExitBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ExitBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.IconMarginLeft = 11;
            this.ExitBtn.IconPadding = 10;
            this.ExitBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.ExitBtn.IdleBorderRadius = 3;
            this.ExitBtn.IdleBorderThickness = 1;
            this.ExitBtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.ExitBtn.IdleIconLeftImage = null;
            this.ExitBtn.IdleIconRightImage = null;
            this.ExitBtn.IndicateFocus = false;
            this.ExitBtn.Location = new System.Drawing.Point(842, 6);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExitBtn.Name = "ExitBtn";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.ExitBtn.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.ExitBtn.OnPressedState = stateProperties2;
            this.ExitBtn.Size = new System.Drawing.Size(47, 24);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitBtn.TextMarginLeft = 0;
            this.ExitBtn.UseDefaultRadiusAndThickness = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.TimkiemPanel);
            this.panel2.Controls.Add(this.DoanhThuPanel);
            this.panel2.Controls.Add(this.TTKhachHangPanel);
            this.panel2.Controls.Add(this.HuyVePanel);
            this.panel2.Controls.Add(this.BanVePanel);
            this.panel2.Controls.Add(this.ThongTinPanel);
            this.panel2.Controls.Add(this.HomePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 467);
            this.panel2.TabIndex = 1;
            // 
            // DoanhThuPanel
            // 
            this.DoanhThuPanel.Controls.Add(this.DoanhThuLabel);
            this.DoanhThuPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoanhThuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DoanhThuPanel.Location = new System.Drawing.Point(0, 265);
            this.DoanhThuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.DoanhThuPanel.Name = "DoanhThuPanel";
            this.DoanhThuPanel.Size = new System.Drawing.Size(140, 53);
            this.DoanhThuPanel.TabIndex = 5;
            this.DoanhThuPanel.Click += new System.EventHandler(this.DoanhThuPanel_Click);
            // 
            // DoanhThuLabel
            // 
            this.DoanhThuLabel.AutoSize = true;
            this.DoanhThuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoanhThuLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DoanhThuLabel.Location = new System.Drawing.Point(23, 12);
            this.DoanhThuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DoanhThuLabel.Name = "DoanhThuLabel";
            this.DoanhThuLabel.Size = new System.Drawing.Size(97, 24);
            this.DoanhThuLabel.TabIndex = 1;
            this.DoanhThuLabel.Text = "Doanh thu";
            this.DoanhThuLabel.Click += new System.EventHandler(this.DoanhThuPanel_Click);
            // 
            // TTKhachHangPanel
            // 
            this.TTKhachHangPanel.Controls.Add(this.TTKhachHangLabel);
            this.TTKhachHangPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TTKhachHangPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TTKhachHangPanel.Location = new System.Drawing.Point(0, 212);
            this.TTKhachHangPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TTKhachHangPanel.Name = "TTKhachHangPanel";
            this.TTKhachHangPanel.Size = new System.Drawing.Size(140, 53);
            this.TTKhachHangPanel.TabIndex = 4;
            this.TTKhachHangPanel.Click += new System.EventHandler(this.TTKhachHangPanel_Click);
            // 
            // TTKhachHangLabel
            // 
            this.TTKhachHangLabel.AutoSize = true;
            this.TTKhachHangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTKhachHangLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TTKhachHangLabel.Location = new System.Drawing.Point(3, 15);
            this.TTKhachHangLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TTKhachHangLabel.Name = "TTKhachHangLabel";
            this.TTKhachHangLabel.Size = new System.Drawing.Size(138, 24);
            this.TTKhachHangLabel.TabIndex = 1;
            this.TTKhachHangLabel.Text = "TT khách hàng";
            this.TTKhachHangLabel.Click += new System.EventHandler(this.TTKhachHangPanel_Click);
            // 
            // HuyVePanel
            // 
            this.HuyVePanel.Controls.Add(this.HuyVeLabel);
            this.HuyVePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HuyVePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HuyVePanel.Location = new System.Drawing.Point(0, 159);
            this.HuyVePanel.Margin = new System.Windows.Forms.Padding(2);
            this.HuyVePanel.Name = "HuyVePanel";
            this.HuyVePanel.Size = new System.Drawing.Size(140, 53);
            this.HuyVePanel.TabIndex = 3;
            this.HuyVePanel.Click += new System.EventHandler(this.HuyVePanel_Click);
            // 
            // HuyVeLabel
            // 
            this.HuyVeLabel.AutoSize = true;
            this.HuyVeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuyVeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.HuyVeLabel.Location = new System.Drawing.Point(38, 15);
            this.HuyVeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HuyVeLabel.Name = "HuyVeLabel";
            this.HuyVeLabel.Size = new System.Drawing.Size(69, 24);
            this.HuyVeLabel.TabIndex = 1;
            this.HuyVeLabel.Text = "Hủy vé";
            this.HuyVeLabel.Click += new System.EventHandler(this.HuyVePanel_Click);
            // 
            // BanVePanel
            // 
            this.BanVePanel.Controls.Add(this.BanVeLabel);
            this.BanVePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BanVePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BanVePanel.Location = new System.Drawing.Point(0, 106);
            this.BanVePanel.Margin = new System.Windows.Forms.Padding(2);
            this.BanVePanel.Name = "BanVePanel";
            this.BanVePanel.Size = new System.Drawing.Size(140, 53);
            this.BanVePanel.TabIndex = 2;
            this.BanVePanel.Click += new System.EventHandler(this.BanVePanel_Click);
            // 
            // BanVeLabel
            // 
            this.BanVeLabel.AutoSize = true;
            this.BanVeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BanVeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.BanVeLabel.Location = new System.Drawing.Point(37, 15);
            this.BanVeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BanVeLabel.Name = "BanVeLabel";
            this.BanVeLabel.Size = new System.Drawing.Size(68, 24);
            this.BanVeLabel.TabIndex = 1;
            this.BanVeLabel.Text = "Bán vé";
            this.BanVeLabel.Click += new System.EventHandler(this.BanVePanel_Click);
            // 
            // ThongTinPanel
            // 
            this.ThongTinPanel.Controls.Add(this.ThongTinLabel);
            this.ThongTinPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThongTinPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThongTinPanel.Location = new System.Drawing.Point(0, 53);
            this.ThongTinPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ThongTinPanel.Name = "ThongTinPanel";
            this.ThongTinPanel.Size = new System.Drawing.Size(140, 53);
            this.ThongTinPanel.TabIndex = 1;
            this.ThongTinPanel.Click += new System.EventHandler(this.ThongTinPanel_Click);
            // 
            // ThongTinLabel
            // 
            this.ThongTinLabel.AutoSize = true;
            this.ThongTinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThongTinLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ThongTinLabel.Location = new System.Drawing.Point(28, 14);
            this.ThongTinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ThongTinLabel.Name = "ThongTinLabel";
            this.ThongTinLabel.Size = new System.Drawing.Size(90, 24);
            this.ThongTinLabel.TabIndex = 1;
            this.ThongTinLabel.Text = "Thông tin";
            this.ThongTinLabel.Click += new System.EventHandler(this.ThongTinPanel_Click);
            // 
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.HomeLabel);
            this.HomePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Margin = new System.Windows.Forms.Padding(2);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(140, 53);
            this.HomePanel.TabIndex = 0;
            this.HomePanel.Click += new System.EventHandler(this.HomePanel_Click);
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.HomeLabel.Location = new System.Drawing.Point(25, 15);
            this.HomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(97, 24);
            this.HomeLabel.TabIndex = 0;
            this.HomeLabel.Text = "Trang chủ";
            this.HomeLabel.Click += new System.EventHandler(this.HomePanel_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.ucttKhachHang);
            this.ContentPanel.Controls.Add(this.ucThongTin);
            this.ContentPanel.Controls.Add(this.ucHuyVe);
            this.ContentPanel.Controls.Add(this.ucDoanhThu);
            this.ContentPanel.Controls.Add(this.ucBanve);
            this.ContentPanel.Controls.Add(this.home1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(140, 37);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(758, 467);
            this.ContentPanel.TabIndex = 2;
            // 
            // ucttKhachHang
            // 
            this.ucttKhachHang.Location = new System.Drawing.Point(0, 0);
            this.ucttKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucttKhachHang.Name = "ucttKhachHang";
            this.ucttKhachHang.Size = new System.Drawing.Size(766, 467);
            this.ucttKhachHang.TabIndex = 6;
            // 
            // ucThongTin
            // 
            this.ucThongTin.Location = new System.Drawing.Point(0, 0);
            this.ucThongTin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucThongTin.Name = "ucThongTin";
            this.ucThongTin.Size = new System.Drawing.Size(766, 467);
            this.ucThongTin.TabIndex = 5;
            // 
            // ucHuyVe
            // 
            this.ucHuyVe.Location = new System.Drawing.Point(0, 0);
            this.ucHuyVe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucHuyVe.Name = "ucHuyVe";
            this.ucHuyVe.Size = new System.Drawing.Size(766, 467);
            this.ucHuyVe.TabIndex = 4;
            // 
            // ucDoanhThu
            // 
            this.ucDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.ucDoanhThu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucDoanhThu.Name = "ucDoanhThu";
            this.ucDoanhThu.Size = new System.Drawing.Size(766, 467);
            this.ucDoanhThu.TabIndex = 3;
            // 
            // ucBanve
            // 
            this.ucBanve.Location = new System.Drawing.Point(0, 0);
            this.ucBanve.Margin = new System.Windows.Forms.Padding(2);
            this.ucBanve.Name = "ucBanve";
            this.ucBanve.Size = new System.Drawing.Size(766, 467);
            this.ucBanve.TabIndex = 2;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.White;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(766, 467);
            this.home1.TabIndex = 1;
            // 
            // TimkiemPanel
            // 
            this.TimkiemPanel.Controls.Add(this.TimkiemLabel);
            this.TimkiemPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimkiemPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimkiemPanel.Location = new System.Drawing.Point(0, 318);
            this.TimkiemPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TimkiemPanel.Name = "TimkiemPanel";
            this.TimkiemPanel.Size = new System.Drawing.Size(140, 53);
            this.TimkiemPanel.TabIndex = 6;
            // 
            // TimkiemLabel
            // 
            this.TimkiemLabel.AutoSize = true;
            this.TimkiemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimkiemLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TimkiemLabel.Location = new System.Drawing.Point(23, 12);
            this.TimkiemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimkiemLabel.Name = "TimkiemLabel";
            this.TimkiemLabel.Size = new System.Drawing.Size(87, 24);
            this.TimkiemLabel.TabIndex = 1;
            this.TimkiemLabel.Text = "Tìm kiếm";
            this.TimkiemLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 504);
            this.ControlBox = false;
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Main";
            this.Header.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.DoanhThuPanel.ResumeLayout(false);
            this.DoanhThuPanel.PerformLayout();
            this.TTKhachHangPanel.ResumeLayout(false);
            this.TTKhachHangPanel.PerformLayout();
            this.HuyVePanel.ResumeLayout(false);
            this.HuyVePanel.PerformLayout();
            this.BanVePanel.ResumeLayout(false);
            this.BanVePanel.PerformLayout();
            this.ThongTinPanel.ResumeLayout(false);
            this.ThongTinPanel.PerformLayout();
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.TimkiemPanel.ResumeLayout(false);
            this.TimkiemPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel DoanhThuPanel;
        private System.Windows.Forms.Panel TTKhachHangPanel;
        private System.Windows.Forms.Panel HuyVePanel;
        private System.Windows.Forms.Panel BanVePanel;
        private System.Windows.Forms.Panel ThongTinPanel;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.Label DoanhThuLabel;
        private System.Windows.Forms.Label TTKhachHangLabel;
        private System.Windows.Forms.Label HuyVeLabel;
        private System.Windows.Forms.Label BanVeLabel;
        private System.Windows.Forms.Label ThongTinLabel;
        private Components.Home1 home1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ExitBtn;
        private Components.UCBanve ucBanve;
        private Components.UCTTKhachHang ucttKhachHang;
        private Components.UCThongTincs ucThongTin;
        private Components.UCHuyVe ucHuyVe;
        private Components.UCDoanhThu ucDoanhThu;
        private System.Windows.Forms.Panel TimkiemPanel;
        private System.Windows.Forms.Label TimkiemLabel;
    }
}