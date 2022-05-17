﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucakotomasyon
{
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
            
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void guna2GradientPanel2_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            islemlerpanel.Controls.Clear();
            SeferEkleForm seferform = new SeferEkleForm();
            seferform.TopLevel = false;
            islemlerpanel.Controls.Add(seferform);
            seferform.Show();
            seferform.Dock = DockStyle.Fill;
            seferform.BringToFront();




        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            islemlerpanel.Controls.Clear();
            AdminUcusEkleForm ucakekleform = new AdminUcusEkleForm();
            ucakekleform.TopLevel = false;
            islemlerpanel.Controls.Add(ucakekleform);
            ucakekleform.Show();
            ucakekleform.Dock = DockStyle.Fill;
            ucakekleform.BringToFront();
        }
    }
}
