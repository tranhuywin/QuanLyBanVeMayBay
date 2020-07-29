namespace QuanLyBanVeMayBay
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.LoginLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ExitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.AnHienMatKhauCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PasswordTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UserTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LoginBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginLabel.Location = new System.Drawing.Point(123, 24);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(78, 26);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Log In";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 446);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ExitBtn);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 41);
            this.panel3.TabIndex = 10;
            // 
            // ExitBtn
            // 
            this.ExitBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.ErrorImage")));
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageActive = null;
            this.ExitBtn.Location = new System.Drawing.Point(440, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(30, 30);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Zoom = 10;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.AnHienMatKhauCheckBox);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.PasswordTxt);
            this.panel2.Controls.Add(this.UserTxt);
            this.panel2.Controls.Add(this.LoginBtn);
            this.panel2.Controls.Add(this.LoginLabel);
            this.panel2.Location = new System.Drawing.Point(74, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 310);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.label5.Location = new System.Drawing.Point(74, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Ẩn, hiện mật khẩu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnHienMatKhauCheckBox
            // 
            this.AnHienMatKhauCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.AnHienMatKhauCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.AnHienMatKhauCheckBox.Checked = true;
            this.AnHienMatKhauCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.AnHienMatKhauCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnHienMatKhauCheckBox.ForeColor = System.Drawing.Color.White;
            this.AnHienMatKhauCheckBox.Location = new System.Drawing.Point(48, 190);
            this.AnHienMatKhauCheckBox.Name = "AnHienMatKhauCheckBox";
            this.AnHienMatKhauCheckBox.Size = new System.Drawing.Size(20, 20);
            this.AnHienMatKhauCheckBox.TabIndex = 43;
            this.AnHienMatKhauCheckBox.OnChange += new System.EventHandler(this.AnHienMatKhauCheckBox_OnChange);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(44, 131);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(52, 13);
            this.bunifuCustomLabel2.TabIndex = 12;
            this.bunifuCustomLabel2.Text = "Mật khẩu";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(44, 66);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(55, 13);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Tài khoản";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PasswordTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PasswordTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PasswordTxt.ForeColor = System.Drawing.Color.White;
            this.PasswordTxt.HintForeColor = System.Drawing.Color.White;
            this.PasswordTxt.HintText = "";
            this.PasswordTxt.isPassword = true;
            this.PasswordTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.PasswordTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.PasswordTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PasswordTxt.LineThickness = 3;
            this.PasswordTxt.Location = new System.Drawing.Point(47, 148);
            this.PasswordTxt.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTxt.MaxLength = 32767;
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(230, 32);
            this.PasswordTxt.TabIndex = 5;
            this.PasswordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UserTxt
            // 
            this.UserTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserTxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UserTxt.ForeColor = System.Drawing.Color.White;
            this.UserTxt.HintForeColor = System.Drawing.Color.White;
            this.UserTxt.HintText = "";
            this.UserTxt.isPassword = false;
            this.UserTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.UserTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.UserTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.UserTxt.LineThickness = 3;
            this.UserTxt.Location = new System.Drawing.Point(47, 83);
            this.UserTxt.Margin = new System.Windows.Forms.Padding(4);
            this.UserTxt.MaxLength = 32767;
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.Size = new System.Drawing.Size(230, 34);
            this.UserTxt.TabIndex = 4;
            this.UserTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LoginBtn
            // 
            this.LoginBtn.AllowToggling = false;
            this.LoginBtn.AnimationSpeed = 200;
            this.LoginBtn.AutoGenerateColors = false;
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.LoginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBtn.BackgroundImage")));
            this.LoginBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginBtn.ButtonText = "log in";
            this.LoginBtn.ButtonTextMarginLeft = 0;
            this.LoginBtn.ColorContrastOnClick = 45;
            this.LoginBtn.ColorContrastOnHover = 45;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.LoginBtn.CustomizableEdges = borderEdges1;
            this.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginBtn.DisabledBorderColor = System.Drawing.Color.Empty;
            this.LoginBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LoginBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LoginBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.IconMarginLeft = 11;
            this.LoginBtn.IconPadding = 10;
            this.LoginBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.LoginBtn.IdleBorderRadius = 3;
            this.LoginBtn.IdleBorderThickness = 1;
            this.LoginBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.LoginBtn.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("LoginBtn.IdleIconLeftImage")));
            this.LoginBtn.IdleIconRightImage = null;
            this.LoginBtn.IndicateFocus = false;
            this.LoginBtn.Location = new System.Drawing.Point(103, 261);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LoginBtn.Name = "LoginBtn";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.LoginBtn.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.LoginBtn.OnPressedState = stateProperties2;
            this.LoginBtn.Size = new System.Drawing.Size(112, 37);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginBtn.TextMarginLeft = 0;
            this.LoginBtn.UseDefaultRadiusAndThickness = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel3;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 446);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel LoginLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton LoginBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PasswordTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserTxt;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton ExitBtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCheckbox AnHienMatKhauCheckBox;
    }
}

