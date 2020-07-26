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
            this.TimKiemVe = new QuanLyBanVeMayBay.Components.ComponentsTimKiemVe.TimKiemVe();
            this.pnl_TimVe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_TimVe
            // 
            this.pnl_TimVe.Controls.Add(this.TimKiemVe);
            this.pnl_TimVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_TimVe.Location = new System.Drawing.Point(0, 0);
            this.pnl_TimVe.Name = "pnl_TimVe";
            this.pnl_TimVe.Size = new System.Drawing.Size(1086, 602);
            this.pnl_TimVe.TabIndex = 1;
            // 
            // TimKiemVe
            // 
            this.TimKiemVe.Location = new System.Drawing.Point(0, 0);
            this.TimKiemVe.Name = "TimKiemVe";
            this.TimKiemVe.Size = new System.Drawing.Size(1083, 596);
            this.TimKiemVe.TabIndex = 0;
            // 
            // UCTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_TimVe);
            this.Name = "UCTaiKhoan";
            this.Size = new System.Drawing.Size(1086, 602);
            this.pnl_TimVe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_TimVe;
        private ComponentsTimKiemVe.TimKiemVe TimKiemVe;
    }
}
