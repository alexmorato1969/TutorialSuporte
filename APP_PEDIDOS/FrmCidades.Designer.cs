
namespace APP_PEDIDOS
{
    partial class FrmCidades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CodCidade = new System.Windows.Forms.TextBox();
            this.txt_NomeCidade = new System.Windows.Forms.TextBox();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.dgv_Cidades = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(37, 466);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(139, 33);
            this.btn_inserir.TabIndex = 0;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(182, 466);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(139, 33);
            this.btn_Alterar.TabIndex = 1;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(327, 466);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(139, 33);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(472, 466);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(139, 33);
            this.btn_Limpar.TabIndex = 3;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cód Cidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado";
            // 
            // txt_CodCidade
            // 
            this.txt_CodCidade.Enabled = false;
            this.txt_CodCidade.Location = new System.Drawing.Point(37, 80);
            this.txt_CodCidade.Name = "txt_CodCidade";
            this.txt_CodCidade.Size = new System.Drawing.Size(78, 22);
            this.txt_CodCidade.TabIndex = 7;
            // 
            // txt_NomeCidade
            // 
            this.txt_NomeCidade.Location = new System.Drawing.Point(121, 80);
            this.txt_NomeCidade.Name = "txt_NomeCidade";
            this.txt_NomeCidade.Size = new System.Drawing.Size(410, 22);
            this.txt_NomeCidade.TabIndex = 8;
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(537, 78);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(292, 24);
            this.cboEstados.TabIndex = 9;
            // 
            // dgv_Cidades
            // 
            this.dgv_Cidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cidades.Location = new System.Drawing.Point(37, 127);
            this.dgv_Cidades.Name = "dgv_Cidades";
            this.dgv_Cidades.RowHeadersWidth = 51;
            this.dgv_Cidades.RowTemplate.Height = 24;
            this.dgv_Cidades.Size = new System.Drawing.Size(792, 277);
            this.dgv_Cidades.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Atualiza Combo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_Cidades);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.txt_NomeCidade);
            this.Controls.Add(this.txt_CodCidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_inserir);
            this.Name = "FrmCidades";
            this.Text = "Cidades";
            this.Load += new System.EventHandler(this.FrmCidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CodCidade;
        private System.Windows.Forms.TextBox txt_NomeCidade;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.DataGridView dgv_Cidades;
        private System.Windows.Forms.Button button1;
    }
}