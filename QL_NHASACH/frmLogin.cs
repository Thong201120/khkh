﻿using QL_NHASACH.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NHASACH
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        XLNHANVIEN tblNhanVien;

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tblNhanVien = new XLNHANVIEN();
            var r = tblNhanVien.Select("Username= '" + txtUserName.Text + "'Password = '" + txtPassword.Text + "'");
            if(r.Count()>0)
            {
                frmMain f = (frmMain)this.MdiParent;
                f.Text = "Quản Lý Nhà Sách - Chào " + r[0]["TenNV"].ToString();
                f.maNV = r[0]["MaNV"].ToString();
                f.enableControl((int)r[0]["MaLTK"]);

                this.Close();
            }

            else
            {
                MessageBox.Show("Sai tên tài khoản và mật khẩu!!!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (int)Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}
