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
            this.Header = new System.Windows.Forms.Panel();
            this.MinisizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.ExitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DoanhThuBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TimKHBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TimVeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ChinhSuaVeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.KhachHangBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.HuyVeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BanVeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.HomeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.ucTimKiemKH1 = new QuanLyBanVeMayBay.Components.UCTimKiemKH();
            this.ucChinhSuaVe = new QuanLyBanVeMayBay.Components.ComponentsChinhSuaVe.UCChinhSuaVe();
            this.ucTimVe1 = new QuanLyBanVeMayBay.Components.UCTimVe();
            this.ucKhachHang = new QuanLyBanVeMayBay.Components.ComponentsKhachHang.UCKhachHang();
            this.ucHuyVe = new QuanLyBanVeMayBay.Components.UCHuyVe();
            this.ucBanve = new QuanLyBanVeMayBay.Components.UCBanve();
            this.ucDoanhThu = new QuanLyBanVeMayBay.Components.UCDoanhThu();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinisizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Header.Controls.Add(this.MinisizeBtn);
            this.Header.Controls.Add(this.ExitBtn);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1300, 46);
            this.Header.TabIndex = 0;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // MinisizeBtn
            // 
            this.MinisizeBtn.ErrorImage = null;
            this.MinisizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinisizeBtn.Image")));
            this.MinisizeBtn.ImageActive = null;
            this.MinisizeBtn.Location = new System.Drawing.Point(1215, 3);
            this.MinisizeBtn.Name = "MinisizeBtn";
            this.MinisizeBtn.Size = new System.Drawing.Size(30, 30);
            this.MinisizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinisizeBtn.TabIndex = 7;
            this.MinisizeBtn.TabStop = false;
            this.MinisizeBtn.Zoom = 10;
            this.MinisizeBtn.Click += new System.EventHandler(this.MinisizeBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.ErrorImage")));
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageActive = null;
            this.ExitBtn.Location = new System.Drawing.Point(1261, 6);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(30, 30);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Zoom = 10;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.DoanhThuBtn);
            this.panel2.Controls.Add(this.TimKHBtn);
            this.panel2.Controls.Add(this.TimVeBtn);
            this.panel2.Controls.Add(this.ChinhSuaVeBtn);
            this.panel2.Controls.Add(this.KhachHangBtn);
            this.panel2.Controls.Add(this.HuyVeBtn);
            this.panel2.Controls.Add(this.BanVeBtn);
            this.panel2.Controls.Add(this.HomeBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 604);
            this.panel2.TabIndex = 1;
            // 
            // DoanhThuBtn
            // 
            this.DoanhThuBtn.Active = false;
            this.DoanhThuBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.DoanhThuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DoanhThuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoanhThuBtn.BorderRadius = 0;
            this.DoanhThuBtn.ButtonText = "Doanh thu";
            this.DoanhThuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoanhThuBtn.DisabledColor = System.Drawing.Color.Gray;
            this.DoanhThuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DoanhThuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoanhThuBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DoanhThuBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("DoanhThuBtn.Iconimage")));
            this.DoanhThuBtn.Iconimage_right = null;
            this.DoanhThuBtn.Iconimage_right_Selected = null;
            this.DoanhThuBtn.Iconimage_Selected = null;
            this.DoanhThuBtn.IconMarginLeft = 10;
            this.DoanhThuBtn.IconMarginRight = 10;
            this.DoanhThuBtn.IconRightVisible = true;
            this.DoanhThuBtn.IconRightZoom = 90D;
            this.DoanhThuBtn.IconVisible = true;
            this.DoanhThuBtn.IconZoom = 80D;
            this.DoanhThuBtn.IsTab = false;
            this.DoanhThuBtn.Location = new System.Drawing.Point(0, 399);
            this.DoanhThuBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoanhThuBtn.Name = "DoanhThuBtn";
            this.DoanhThuBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DoanhThuBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.DoanhThuBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.DoanhThuBtn.selected = false;
            this.DoanhThuBtn.Size = new System.Drawing.Size(214, 57);
            this.DoanhThuBtn.TabIndex = 14;
            this.DoanhThuBtn.Text = "Doanh thu";
            this.DoanhThuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DoanhThuBtn.Textcolor = System.Drawing.Color.White;
            this.DoanhThuBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoanhThuBtn.Click += new System.EventHandler(this.DoanhThuBtn_Click);
            // 
            // TimKHBtn
            // 
            this.TimKHBtn.Active = false;
            this.TimKHBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.TimKHBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.TimKHBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TimKHBtn.BorderRadius = 0;
            this.TimKHBtn.ButtonText = "Tìm khách hàng";
            this.TimKHBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimKHBtn.DisabledColor = System.Drawing.Color.Gray;
            this.TimKHBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimKHBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKHBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.TimKHBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("TimKHBtn.Iconimage")));
            this.TimKHBtn.Iconimage_right = null;
            this.TimKHBtn.Iconimage_right_Selected = null;
            this.TimKHBtn.Iconimage_Selected = null;
            this.TimKHBtn.IconMarginLeft = 10;
            this.TimKHBtn.IconMarginRight = 10;
            this.TimKHBtn.IconRightVisible = true;
            this.TimKHBtn.IconRightZoom = 90D;
            this.TimKHBtn.IconVisible = true;
            this.TimKHBtn.IconZoom = 80D;
            this.TimKHBtn.IsTab = false;
            this.TimKHBtn.Location = new System.Drawing.Point(0, 342);
            this.TimKHBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimKHBtn.Name = "TimKHBtn";
            this.TimKHBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.TimKHBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.TimKHBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.TimKHBtn.selected = false;
            this.TimKHBtn.Size = new System.Drawing.Size(214, 57);
            this.TimKHBtn.TabIndex = 13;
            this.TimKHBtn.Text = "Tìm khách hàng";
            this.TimKHBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimKHBtn.Textcolor = System.Drawing.Color.White;
            this.TimKHBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKHBtn.Click += new System.EventHandler(this.TimKHBtn_Click);
            // 
            // TimVeBtn
            // 
            this.TimVeBtn.Active = false;
            this.TimVeBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.TimVeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.TimVeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TimVeBtn.BorderRadius = 0;
            this.TimVeBtn.ButtonText = "Tìm vé";
            this.TimVeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimVeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.TimVeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimVeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimVeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.TimVeBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("TimVeBtn.Iconimage")));
            this.TimVeBtn.Iconimage_right = null;
            this.TimVeBtn.Iconimage_right_Selected = null;
            this.TimVeBtn.Iconimage_Selected = null;
            this.TimVeBtn.IconMarginLeft = 10;
            this.TimVeBtn.IconMarginRight = 10;
            this.TimVeBtn.IconRightVisible = true;
            this.TimVeBtn.IconRightZoom = 90D;
            this.TimVeBtn.IconVisible = true;
            this.TimVeBtn.IconZoom = 80D;
            this.TimVeBtn.IsTab = false;
            this.TimVeBtn.Location = new System.Drawing.Point(0, 285);
            this.TimVeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimVeBtn.Name = "TimVeBtn";
            this.TimVeBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.TimVeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.TimVeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.TimVeBtn.selected = false;
            this.TimVeBtn.Size = new System.Drawing.Size(214, 57);
            this.TimVeBtn.TabIndex = 12;
            this.TimVeBtn.Text = "Tìm vé";
            this.TimVeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimVeBtn.Textcolor = System.Drawing.Color.White;
            this.TimVeBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimVeBtn.Click += new System.EventHandler(this.TimVeBtn_Click);
            // 
            // ChinhSuaVeBtn
            // 
            this.ChinhSuaVeBtn.Active = false;
            this.ChinhSuaVeBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.ChinhSuaVeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ChinhSuaVeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChinhSuaVeBtn.BorderRadius = 0;
            this.ChinhSuaVeBtn.ButtonText = "Chỉnh sửa vé";
            this.ChinhSuaVeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChinhSuaVeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ChinhSuaVeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChinhSuaVeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChinhSuaVeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ChinhSuaVeBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ChinhSuaVeBtn.Iconimage")));
            this.ChinhSuaVeBtn.Iconimage_right = null;
            this.ChinhSuaVeBtn.Iconimage_right_Selected = null;
            this.ChinhSuaVeBtn.Iconimage_Selected = null;
            this.ChinhSuaVeBtn.IconMarginLeft = 10;
            this.ChinhSuaVeBtn.IconMarginRight = 10;
            this.ChinhSuaVeBtn.IconRightVisible = true;
            this.ChinhSuaVeBtn.IconRightZoom = 90D;
            this.ChinhSuaVeBtn.IconVisible = true;
            this.ChinhSuaVeBtn.IconZoom = 80D;
            this.ChinhSuaVeBtn.IsTab = false;
            this.ChinhSuaVeBtn.Location = new System.Drawing.Point(0, 228);
            this.ChinhSuaVeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChinhSuaVeBtn.Name = "ChinhSuaVeBtn";
            this.ChinhSuaVeBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ChinhSuaVeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ChinhSuaVeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ChinhSuaVeBtn.selected = false;
            this.ChinhSuaVeBtn.Size = new System.Drawing.Size(214, 57);
            this.ChinhSuaVeBtn.TabIndex = 11;
            this.ChinhSuaVeBtn.Text = "Chỉnh sửa vé";
            this.ChinhSuaVeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChinhSuaVeBtn.Textcolor = System.Drawing.Color.White;
            this.ChinhSuaVeBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChinhSuaVeBtn.Click += new System.EventHandler(this.ChinhSuaVeBtn_Click);
            // 
            // KhachHangBtn
            // 
            this.KhachHangBtn.Active = false;
            this.KhachHangBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.KhachHangBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.KhachHangBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KhachHangBtn.BorderRadius = 0;
            this.KhachHangBtn.ButtonText = "Khách hàng";
            this.KhachHangBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KhachHangBtn.DisabledColor = System.Drawing.Color.Gray;
            this.KhachHangBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.KhachHangBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhachHangBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.KhachHangBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("KhachHangBtn.Iconimage")));
            this.KhachHangBtn.Iconimage_right = null;
            this.KhachHangBtn.Iconimage_right_Selected = null;
            this.KhachHangBtn.Iconimage_Selected = null;
            this.KhachHangBtn.IconMarginLeft = 10;
            this.KhachHangBtn.IconMarginRight = 10;
            this.KhachHangBtn.IconRightVisible = true;
            this.KhachHangBtn.IconRightZoom = 90D;
            this.KhachHangBtn.IconVisible = true;
            this.KhachHangBtn.IconZoom = 80D;
            this.KhachHangBtn.IsTab = false;
            this.KhachHangBtn.Location = new System.Drawing.Point(0, 171);
            this.KhachHangBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KhachHangBtn.Name = "KhachHangBtn";
            this.KhachHangBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.KhachHangBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.KhachHangBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.KhachHangBtn.selected = false;
            this.KhachHangBtn.Size = new System.Drawing.Size(214, 57);
            this.KhachHangBtn.TabIndex = 10;
            this.KhachHangBtn.Text = "Khách hàng";
            this.KhachHangBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KhachHangBtn.Textcolor = System.Drawing.Color.White;
            this.KhachHangBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhachHangBtn.Click += new System.EventHandler(this.KhachHangBtn_Click);
            // 
            // HuyVeBtn
            // 
            this.HuyVeBtn.Active = false;
            this.HuyVeBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.HuyVeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.HuyVeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HuyVeBtn.BorderRadius = 0;
            this.HuyVeBtn.ButtonText = "Hủy vé";
            this.HuyVeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HuyVeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.HuyVeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HuyVeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuyVeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.HuyVeBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("HuyVeBtn.Iconimage")));
            this.HuyVeBtn.Iconimage_right = null;
            this.HuyVeBtn.Iconimage_right_Selected = null;
            this.HuyVeBtn.Iconimage_Selected = null;
            this.HuyVeBtn.IconMarginLeft = 10;
            this.HuyVeBtn.IconMarginRight = 10;
            this.HuyVeBtn.IconRightVisible = true;
            this.HuyVeBtn.IconRightZoom = 90D;
            this.HuyVeBtn.IconVisible = true;
            this.HuyVeBtn.IconZoom = 80D;
            this.HuyVeBtn.IsTab = false;
            this.HuyVeBtn.Location = new System.Drawing.Point(0, 114);
            this.HuyVeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HuyVeBtn.Name = "HuyVeBtn";
            this.HuyVeBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.HuyVeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.HuyVeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.HuyVeBtn.selected = false;
            this.HuyVeBtn.Size = new System.Drawing.Size(214, 57);
            this.HuyVeBtn.TabIndex = 9;
            this.HuyVeBtn.Text = "Hủy vé";
            this.HuyVeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HuyVeBtn.Textcolor = System.Drawing.Color.White;
            this.HuyVeBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuyVeBtn.Click += new System.EventHandler(this.HuyVeBtn_Click);
            // 
            // BanVeBtn
            // 
            this.BanVeBtn.Active = false;
            this.BanVeBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.BanVeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BanVeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BanVeBtn.BorderRadius = 0;
            this.BanVeBtn.ButtonText = "Bán vé";
            this.BanVeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BanVeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.BanVeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BanVeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BanVeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.BanVeBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("BanVeBtn.Iconimage")));
            this.BanVeBtn.Iconimage_right = null;
            this.BanVeBtn.Iconimage_right_Selected = null;
            this.BanVeBtn.Iconimage_Selected = null;
            this.BanVeBtn.IconMarginLeft = 10;
            this.BanVeBtn.IconMarginRight = 10;
            this.BanVeBtn.IconRightVisible = true;
            this.BanVeBtn.IconRightZoom = 90D;
            this.BanVeBtn.IconVisible = true;
            this.BanVeBtn.IconZoom = 80D;
            this.BanVeBtn.IsTab = false;
            this.BanVeBtn.Location = new System.Drawing.Point(0, 57);
            this.BanVeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BanVeBtn.Name = "BanVeBtn";
            this.BanVeBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BanVeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BanVeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.BanVeBtn.selected = false;
            this.BanVeBtn.Size = new System.Drawing.Size(214, 57);
            this.BanVeBtn.TabIndex = 8;
            this.BanVeBtn.Text = "Bán vé";
            this.BanVeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BanVeBtn.Textcolor = System.Drawing.Color.White;
            this.BanVeBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BanVeBtn.Click += new System.EventHandler(this.BanVeBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Active = false;
            this.HomeBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeBtn.BorderRadius = 0;
            this.HomeBtn.ButtonText = "Trang chủ";
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.HomeBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Iconimage")));
            this.HomeBtn.Iconimage_right = null;
            this.HomeBtn.Iconimage_right_Selected = null;
            this.HomeBtn.Iconimage_Selected = null;
            this.HomeBtn.IconMarginLeft = 10;
            this.HomeBtn.IconMarginRight = 10;
            this.HomeBtn.IconRightVisible = true;
            this.HomeBtn.IconRightZoom = 90D;
            this.HomeBtn.IconVisible = true;
            this.HomeBtn.IconZoom = 80D;
            this.HomeBtn.IsTab = false;
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.HomeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.HomeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.HomeBtn.selected = false;
            this.HomeBtn.Size = new System.Drawing.Size(214, 57);
            this.HomeBtn.TabIndex = 7;
            this.HomeBtn.Text = "Trang chủ";
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.Textcolor = System.Drawing.Color.White;
            this.HomeBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ContentPanel.Controls.Add(this.ucDoanhThu);
            this.ContentPanel.Controls.Add(this.ucTimKiemKH1);
            this.ContentPanel.Controls.Add(this.ucChinhSuaVe);
            this.ContentPanel.Controls.Add(this.ucTimVe1);
            this.ContentPanel.Controls.Add(this.ucKhachHang);
            this.ContentPanel.Controls.Add(this.ucHuyVe);
            this.ContentPanel.Controls.Add(this.ucBanve);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(214, 46);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1086, 604);
            this.ContentPanel.TabIndex = 2;
            // 
            // ucTimKiemKH1
            // 
            this.ucTimKiemKH1.Location = new System.Drawing.Point(-2, 2);
            this.ucTimKiemKH1.Margin = new System.Windows.Forms.Padding(2);
            this.ucTimKiemKH1.Name = "ucTimKiemKH1";
            this.ucTimKiemKH1.Size = new System.Drawing.Size(1086, 602);
            this.ucTimKiemKH1.TabIndex = 10;
            // 
            // ucChinhSuaVe
            // 
            this.ucChinhSuaVe.Location = new System.Drawing.Point(-2, 0);
            this.ucChinhSuaVe.Margin = new System.Windows.Forms.Padding(2);
            this.ucChinhSuaVe.Name = "ucChinhSuaVe";
            this.ucChinhSuaVe.Size = new System.Drawing.Size(1086, 602);
            this.ucChinhSuaVe.TabIndex = 9;
            // 
            // ucTimVe1
            // 
            this.ucTimVe1.Location = new System.Drawing.Point(0, 0);
            this.ucTimVe1.Name = "ucTimVe1";
            this.ucTimVe1.Size = new System.Drawing.Size(1086, 602);
            this.ucTimVe1.TabIndex = 8;
            // 
            // ucKhachHang
            // 
            this.ucKhachHang.Location = new System.Drawing.Point(2, 0);
            this.ucKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.ucKhachHang.Name = "ucKhachHang";
            this.ucKhachHang.Size = new System.Drawing.Size(1086, 602);
            this.ucKhachHang.TabIndex = 7;
            // 
            // ucHuyVe
            // 
            this.ucHuyVe.Location = new System.Drawing.Point(2, 0);
            this.ucHuyVe.Margin = new System.Windows.Forms.Padding(2);
            this.ucHuyVe.Name = "ucHuyVe";
            this.ucHuyVe.Size = new System.Drawing.Size(1086, 602);
            this.ucHuyVe.TabIndex = 4;
            // 
            // ucBanve
            // 
            this.ucBanve.Location = new System.Drawing.Point(2, 2);
            this.ucBanve.Margin = new System.Windows.Forms.Padding(2);
            this.ucBanve.Name = "ucBanve";
            this.ucBanve.Size = new System.Drawing.Size(1082, 600);
            this.ucBanve.TabIndex = 2;
            // 
            // ucDoanhThu
            // 
            this.ucDoanhThu.Location = new System.Drawing.Point(-2, 2);
            this.ucDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.ucDoanhThu.Name = "ucDoanhThu";
            this.ucDoanhThu.Size = new System.Drawing.Size(1086, 602);
            this.ucDoanhThu.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
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
            ((System.ComponentModel.ISupportInitialize)(this.MinisizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ContentPanel;
        private Components.UCBanve ucBanve;
        private Components.UCHuyVe ucHuyVe;
        private Bunifu.Framework.UI.BunifuImageButton MinisizeBtn;
        private Bunifu.Framework.UI.BunifuImageButton ExitBtn;
        private Bunifu.Framework.UI.BunifuFlatButton HomeBtn;
        private Bunifu.Framework.UI.BunifuFlatButton DoanhThuBtn;
        private Bunifu.Framework.UI.BunifuFlatButton TimKHBtn;
        private Bunifu.Framework.UI.BunifuFlatButton TimVeBtn;
        private Bunifu.Framework.UI.BunifuFlatButton ChinhSuaVeBtn;
        private Bunifu.Framework.UI.BunifuFlatButton KhachHangBtn;
        private Bunifu.Framework.UI.BunifuFlatButton HuyVeBtn;
        private Bunifu.Framework.UI.BunifuFlatButton BanVeBtn;
        private Components.ComponentsKhachHang.UCKhachHang ucKhachHang;
        private Components.UCTimVe ucTimVe1;
        private Components.ComponentsChinhSuaVe.UCChinhSuaVe ucChinhSuaVe;
        private Components.UCTimKiemKH ucTimKiemKH1;
        private Components.UCDoanhThu ucDoanhThu;
    }
}