using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_PEDIDOS
{
    public partial class FrmCidades : Form
    {
        pedidosClasses.cidadeClass d = new pedidosClasses.cidadeClass();
        
        public FrmCidades()
        {
            InitializeComponent();
        }

        private void FrmCidades_Load(object sender, EventArgs e)
        {
            carregaCboCidade();
            AtualizaGrid();
        }

        private void carregaCboCidade()
        {
            cboEstados.ValueMember = "cd_uf";
            cboEstados.DisplayMember = "nm_uf";
            cboEstados.DataSource = d.SelectCbo();
        }

        private void AtualizaGrid()
        {
            DataTable dt = d.Select();
            dgv_Cidades.DataSource = dt;
        }


        private void btn_inserir_Click(object sender, EventArgs e)
        {
            //Recuperar os valores dos campos
            d.NM_cidade = txt_NomeCidade.Text;
            d.cd_uf = Convert.ToInt32(cboEstados.SelectedValue);

            //inserir dados no banco

            bool sucesso = d.Insert(d);
            if (sucesso == true)
            {
                MessageBox.Show("UF inserida com sucesso");
                AtualizaGrid();
            }
            else
            {
                MessageBox.Show("Erro ao inserir UF");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carregaCboCidade();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            pedidosClasses.Tools.LimpaControlesGenerico(this);
        }

        private void dgv_Cidades_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int linhaAtual = e.RowIndex;
            txt_CodCidade.Text = dgv_Cidades.Rows[linhaAtual].Cells[0].Value.ToString();
            txt_NomeCidade.Text = dgv_Cidades.Rows[linhaAtual].Cells[1].Value.ToString();
            cboEstados.Text = dgv_Cidades.Rows[linhaAtual].Cells[2].Value.ToString();
        }
    }
}
