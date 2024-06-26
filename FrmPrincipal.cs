namespace Exercicio1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void BtnSair_Click(object sender, EventArgs e)
        {
            new FrmUsuarios().ShowDialog();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            new FrmUsuarios().ShowDialog();
        }

        private void BtnChamados_Click(object sender, EventArgs e)
        {
            new FrmChamados().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmUsuarios().ShowDialog();
        }
    }
}
