﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_WF.Views
{
    public partial class FrmGioiThieu : Form
    {
        public FrmGioiThieu()
        {
            InitializeComponent();
        }

        private void FrmGioiThieu_Load(object sender, EventArgs e)
        {
            rtbGioiThieu.SelectAll();
            rtbGioiThieu.SelectedRtf = Properties.Resources.GioiThieu;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
