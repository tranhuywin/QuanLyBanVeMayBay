namespace QuanLyBanVeMayBay.Components
{
    partial class UCTaiKhoan
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
            this.pnl_TimVe = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TimKiemVe = new QuanLyBanVeMayBay.Components.ComponentsTimKiemVe.TimKiemVe();
            this.pnl_TimVe.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_TimVe
            // 
            this.pnl_TimVe.Controls.Add(this.TimKiemVe);
            this.pnl_TimVe.Location = new System.Drawing.Point(0, 33);
            this.pnl_TimVe.Name = "pnl_TimVe";
            this.pnl_TimVe.Size = new System.Drawing.Size(1086, 569);
            this.pnl_TimVe.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 33);
            this.panel2.TabIndex = 6;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(215, 25);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Thông tin tài khoản";
            // 
            // TimKiemVe
            // 
            this.TimKiemVe.Location = new System.Drawing.Point(3, 0);
            this.TimKiemVe.Name = "TimKiemVe";
            this.TimKiemVe.Size = new System.Drawing.Size(1083, 566);
            this.TimKiemVe.TabIndex = 0;
            // 
            // UCTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_TimVe);
            this.Name = "UCTaiKhoan";
            this.Size = new System.Drawing.Size(1086, 602);
            this.pnl_TimVe.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_TimVe;
        private ComponentsTimKiemVe.TimKiemVe TimKiemVe;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
