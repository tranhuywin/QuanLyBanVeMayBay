namespace QuanLyBanVeMayBay.Components
{
    partial class UCHuyVe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ContentDienTTPanel = new System.Windows.Forms.Panel();
            this.DienThongTinKH = new QuanLyBanVeMayBay.Components.ComponentsHuyVe.DienThongTinkH();
            this.panel1.SuspendLayout();
            this.ContentDienTTPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 47);
            this.panel1.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 10);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(281, 25);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Điền thông tin vé cần hủy";
            // 
            // ContentDienTTPanel
            // 
            this.ContentDienTTPanel.Controls.Add(this.DienThongTinKH);
            this.ContentDienTTPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentDienTTPanel.Location = new System.Drawing.Point(0, 47);
            this.ContentDienTTPanel.Name = "ContentDienTTPanel";
            this.ContentDienTTPanel.Size = new System.Drawing.Size(1086, 555);
            this.ContentDienTTPanel.TabIndex = 7;
            // 
            // DienThongTinKH
            // 
            this.DienThongTinKH.Location = new System.Drawing.Point(0, 0);
            this.DienThongTinKH.Name = "DienThongTinKH";
            this.DienThongTinKH.Size = new System.Drawing.Size(1086, 555);
            this.DienThongTinKH.TabIndex = 0;
            // 
            // UCHuyVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentDienTTPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCHuyVe";
            this.Size = new System.Drawing.Size(1086, 602);
            this.Load += new System.EventHandler(this.UCHuyVe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ContentDienTTPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel ContentDienTTPanel;
        private ComponentsHuyVe.DienThongTinkH DienThongTinKH;
    }
}
