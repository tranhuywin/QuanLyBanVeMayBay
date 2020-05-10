﻿using System;
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
    public partial class UCBanve : UserControl
    {
        public UCBanve()
        {
            InitializeComponent();
        }

        private void Step1Btn_Click(object sender, EventArgs e)
        {
            ContentBanVePanel.Controls.Clear();
            ContentBanVePanel.Controls.Add(step1);
        }

        private void Step2Btn_Click(object sender, EventArgs e)
        {
            ContentBanVePanel.Controls.Clear();
            ContentBanVePanel.Controls.Add(step2);
        }

        private void Step3Btn_Click(object sender, EventArgs e)
        {
            ContentBanVePanel.Controls.Clear();
            ContentBanVePanel.Controls.Add(step3);
        }

        private void UCBanve_Load(object sender, EventArgs e)
        {
            ContentBanVePanel.Controls.Clear();
            ContentBanVePanel.Controls.Add(step1);
        }
    }
}
