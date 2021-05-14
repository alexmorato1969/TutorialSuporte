using System;
using System.Data;
using System.Windows.Forms;

namespace APP_PEDIDOS
{
    public partial class frm00 : Form
    {
        public frm00()
        {
            InitializeComponent();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstados frmUf = new frmEstados();
            frmUf.Show();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show( "Deseja sair do sistema ?", "Nome do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCidades frmCidade = new FrmCidades();
            frmCidade.Show();
        }
    }
}
