using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class FrmGremio : Form
    {
        public FrmGremio()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGremio_Load(object sender, EventArgs e)
        {
            playSimpleSound();
        }
        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Aluno\Downloads\hino.wav");
            simpleSound.Play();
        }
    }
}
