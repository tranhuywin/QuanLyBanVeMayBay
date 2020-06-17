namespace QuanLyBanVeMayBay.Components
{
    partial class UCTimKiemKH
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_TimKiemKH = new System.Windows.Forms.Panel();
            this.TimKiemKH = new QuanLyBanVeMayBay.Components.ComponentsTimKiemKH.TimKiemKH();
            this.pnl_TimKiemKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm thông tin KH";
            // 
            // pnl_TimKiemKH
            // 
            this.pnl_TimKiemKH.Controls.Add(this.TimKiemKH);
            this.pnl_TimKiemKH.Location = new System.Drawing.Point(-1, 33);
            this.pnl_TimKiemKH.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_TimKiemKH.Name = "pnl_TimKiemKH";
            this.pnl_TimKiemKH.Size = new System.Drawing.Size(1087, 567);
            this.pnl_TimKiemKH.TabIndex = 1;
            // 
            // TimKiemKH
            // 
            this.TimKiemKH.Location = new System.Drawing.Point(1, 2);
            this.TimKiemKH.Margin = new System.Windows.Forms.Padding(2);
            this.TimKiemKH.Name = "TimKiemKH";
            this.TimKiemKH.Size = new System.Drawing.Size(1084, 563);
            this.TimKiemKH.TabIndex = 2;
            // 
            // UCTimKiemKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_TimKiemKH);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCTimKiemKH";
            this.Size = new System.Drawing.Size(1086, 602);
            this.pnl_TimKiemKH.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_TimKiemKH;
        private ComponentsTimKiemKH.TimKiemKH TimKiemKH;
    }
}