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
    public partial class frmEstados : Form
    {
        public frmEstados()
        {
            InitializeComponent();
        }

        pedidosClasses.ufClass c = new pedidosClasses.ufClass();



        private void Btn_Limpar(object sender, EventArgs e)
        {
            LimpaControles();
        }

        private void frm00_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Recuperar os valores dos campos
            c.DS_sigla_UF = txt_sigla.Text;
            c.NM_UF = txt_nomeuf.Text;
            c.DS_regiao_UF = cmb_regiaoUf.Text;

            //inserir dados no banco

            bool sucesso = c.Insert(c);
            if (sucesso == true)
            {
                MessageBox.Show("UF inserida com sucesso");
                AtualizaGrid();
                LimpaControles();
            }
            else
            {
                MessageBox.Show("Erro ao inserir UF");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //recupera valores dos campos
            c.CD_uf = int.Parse(txt_coduf.Text);
            c.DS_sigla_UF = txt_sigla.Text;
            c.NM_UF = txt_nomeuf.Text;
            c.DS_regiao_UF = cmb_regiaoUf.Text;

            bool sucesso = c.Update(c);
            if (sucesso == true)
            {
                MessageBox.Show("UF atualizada com sucesso");
                AtualizaGrid();
                LimpaControles();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar UF");
            }

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Excluir Registro", "Deseja excluir o registro ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                c.CD_uf = Convert.ToInt32(txt_coduf.Text);
                bool sucesso = c.Delete(c);
                if (sucesso == true)
                {
                    MessageBox.Show("UF excluída com sucesso");
                    AtualizaGrid();
                    LimpaControles();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir UF");
                }

                //MessageBox.Show("Apagou o registro");
            }
            else
            {
                MessageBox.Show("Segue adiante");
            }
        }

        private void LimpaControles()
        {
            txt_coduf.Text = "";
            txt_nomeuf.Text = "";
            txt_sigla.Text = "";
            cmb_regiaoUf.Text = "";
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimpaControles();
        }

        private void frmEstados_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            DataTable dt = c.Select();
            dgv_uf.DataSource = dt;
        }

        private void dgv_uf_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Obter dados correspondente ao item selecionado no grid;
            // Identificar o item no click do mouse

            int rowindex = e.RowIndex;
            txt_coduf.Text = dgv_uf.Rows[rowindex].Cells[0].Value.ToString();
            txt_sigla.Text = dgv_uf.Rows[rowindex].Cells[1].Value.ToString();
            txt_nomeuf.Text = dgv_uf.Rows[rowindex].Cells[2].Value.ToString();
            cmb_regiaoUf.Text = dgv_uf.Rows[rowindex].Cells[3].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Recuperar os valores dos campos
            c.DS_sigla_UF = txt_sigla.Text;
            c.NM_UF = txt_nomeuf.Text;
            c.DS_regiao_UF = cmb_regiaoUf.Text;

            //inserir dados no banco

            bool sucesso = c.Insert(c);
            if (sucesso == true)
            {
                MessageBox.Show("UF inserida com sucesso");
                AtualizaGrid();
                LimpaControles();
            }
            else
            {
                MessageBox.Show("Erro ao inserir UF");
            }
        }
    }
    
}
