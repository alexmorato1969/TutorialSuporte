
namespace APP_PEDIDOS
{
    partial class frmEstados
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
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_coduf = new System.Windows.Forms.TextBox();
            this.cmb_regiaoUf = new System.Windows.Forms.ComboBox();
            this.txt_nomeuf = new System.Windows.Forms.TextBox();
            this.txt_sigla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_uf = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_uf)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(406, 366);
            this.btn_Limpar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(100, 28);
            this.btn_Limpar.TabIndex = 25;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(282, 366);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(100, 28);
            this.btn_excluir.TabIndex = 24;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 366);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 23;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_coduf
            // 
            this.txt_coduf.Location = new System.Drawing.Point(30, 60);
            this.txt_coduf.Margin = new System.Windows.Forms.Padding(4);
            this.txt_coduf.Name = "txt_coduf";
            this.txt_coduf.ReadOnly = true;
            this.txt_coduf.Size = new System.Drawing.Size(64, 22);
            this.txt_coduf.TabIndex = 21;
            // 
            // cmb_regiaoUf
            // 
            this.cmb_regiaoUf.FormattingEnabled = true;
            this.cmb_regiaoUf.Items.AddRange(new object[] {
            "NORTE",
            "NORDESTE",
            "SUL",
            "SUDESTE",
            "CENTRO OESTE"});
            this.cmb_regiaoUf.Location = new System.Drawing.Point(30, 300);
            this.cmb_regiaoUf.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_regiaoUf.Name = "cmb_regiaoUf";
            this.cmb_regiaoUf.Size = new System.Drawing.Size(275, 24);
            this.cmb_regiaoUf.TabIndex = 20;
            // 
            // txt_nomeuf
            // 
            this.txt_nomeuf.Location = new System.Drawing.Point(30, 220);
            this.txt_nomeuf.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nomeuf.MaxLength = 50;
            this.txt_nomeuf.Name = "txt_nomeuf";
            this.txt_nomeuf.Size = new System.Drawing.Size(275, 22);
            this.txt_nomeuf.TabIndex = 19;
            // 
            // txt_sigla
            // 
            this.txt_sigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_sigla.Location = new System.Drawing.Point(30, 140);
            this.txt_sigla.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sigla.MaxLength = 2;
            this.txt_sigla.Name = "txt_sigla";
            this.txt_sigla.Size = new System.Drawing.Size(72, 22);
            this.txt_sigla.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Região UF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nome UF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sigla UF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cód UF";
            // 
            // dgv_uf
            // 
            this.dgv_uf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_uf.Location = new System.Drawing.Point(536, 40);
            this.dgv_uf.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_uf.Name = "dgv_uf";
            this.dgv_uf.RowHeadersWidth = 51;
            this.dgv_uf.Size = new System.Drawing.Size(835, 354);
            this.dgv_uf.TabIndex = 13;
            this.dgv_uf.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_uf_RowHeaderMouseClick_1);
            // 
            // frmEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 418);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_coduf);
            this.Controls.Add(this.cmb_regiaoUf);
            this.Controls.Add(this.txt_nomeuf);
            this.Controls.Add(this.txt_sigla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_uf);
            this.Name = "frmEstados";
            this.Text = "Estados";
            this.Load += new System.EventHandler(this.frmEstados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_uf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_coduf;
        private System.Windows.Forms.ComboBox cmb_regiaoUf;
        private System.Windows.Forms.TextBox txt_nomeuf;
        private System.Windows.Forms.TextBox txt_sigla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_uf;
    }
}