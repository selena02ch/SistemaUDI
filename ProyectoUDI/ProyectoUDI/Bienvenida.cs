﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoUDI
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void bien_MouseClick(object sender, MouseEventArgs e)
        {
            Login nlogin = new Login();
            nlogin.Show();
            this.Hide();
        }

        private void lbl_MouseClick(object sender, MouseEventArgs e)
        {
            Login nlogin = new Login();
            nlogin.Show();
            this.Hide();
        }

        private void img_MouseClick(object sender, MouseEventArgs e)
        {
            Login nlogin = new Login();
            nlogin.Show();
            this.Hide();
        }
    }
}
