﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class FrmChamados : Form
    {
        public FrmChamados()
        {
            InitializeComponent();
        }

        private void BtnSairChamados_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
