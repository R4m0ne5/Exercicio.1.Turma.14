using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DbContextGremio;

namespace Exercicio1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            BancoDoGremio();
        }

        private void BancoDoGremio()
        {
            using (var BancoDoGremio = new AppDbContextGremio())
            {
                BancoDoGremio.Database.Migrate();
            }
        }
        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            new FrmUsuarios().ShowDialog();
        }

        private void BtnChamados_Click(object sender, EventArgs e)
        {
            new FrmChamados().ShowDialog();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGremio_Click_1(object sender, EventArgs e)
        {
            new FrmGremio().ShowDialog();
        }
    }
}
