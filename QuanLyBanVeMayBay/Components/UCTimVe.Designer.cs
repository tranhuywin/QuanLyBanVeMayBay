namespace QuanLyBanVeMayBay.Components
{
    partial class UCTimVe
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_TimVe = new System.Windows.Forms.Panel();
            this.TimKiemVe = new Components.ComponentsTimKiemVe.TimKiemVe();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm thông tin vé";
            // 
            // pnl_TimVe
            // 
            this.pnl_TimVe.Location = new System.Drawing.Point(0, 23);
            this.pnl_TimVe.Name = "pnl_TimVe";
            this.pnl_TimVe.Size = new System.Drawing.Size(800, 450);
            this.pnl_TimVe.TabIndex = 1;
            this.pnl_TimVe.Controls.Add(this.TimKiemVe);
            // 
            // UCTimVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_TimVe);
            this.Controls.Add(this.label1);
            this.Name = "UCTimVe";
            this.Size = new System.Drawing.Size(801, 474);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_TimVe;
        private ComponentsTimKiemVe.TimKiemVe TimKiemVe;
    }
}
