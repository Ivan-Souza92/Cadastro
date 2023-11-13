namespace CadastroDeDados
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbMasculino = new System.Windows.Forms.CheckBox();
            this.CbFeminino = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.BtnInclui = new System.Windows.Forms.Button();
            this.BtnAltera = new System.Windows.Forms.Button();
            this.BtnExclui = new System.Windows.Forms.Button();
            this.ContarContatosPorCidade = new System.Windows.Forms.Button();
            this.cadastroDataSet = new CadastroDeDados.cadastroDataSet();
            this.contatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contatoTableAdapter = new CadastroDeDados.cadastroDataSetTableAdapters.contatoTableAdapter();
            this.DgvContato = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContato)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(278, 40);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(199, 20);
            this.TxtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sexo";
            // 
            // CbMasculino
            // 
            this.CbMasculino.AutoSize = true;
            this.CbMasculino.Location = new System.Drawing.Point(278, 76);
            this.CbMasculino.Name = "CbMasculino";
            this.CbMasculino.Size = new System.Drawing.Size(74, 17);
            this.CbMasculino.TabIndex = 4;
            this.CbMasculino.Text = "Masculino";
            this.CbMasculino.UseVisualStyleBackColor = true;
            // 
            // CbFeminino
            // 
            this.CbFeminino.AutoSize = true;
            this.CbFeminino.Location = new System.Drawing.Point(358, 76);
            this.CbFeminino.Name = "CbFeminino";
            this.CbFeminino.Size = new System.Drawing.Size(68, 17);
            this.CbFeminino.TabIndex = 5;
            this.CbFeminino.Text = "Feminino";
            this.CbFeminino.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cidade";
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(278, 106);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(199, 20);
            this.TxtCidade.TabIndex = 7;
            // 
            // BtnInclui
            // 
            this.BtnInclui.Location = new System.Drawing.Point(240, 149);
            this.BtnInclui.Name = "BtnInclui";
            this.BtnInclui.Size = new System.Drawing.Size(75, 23);
            this.BtnInclui.TabIndex = 8;
            this.BtnInclui.Text = "Inclui";
            this.BtnInclui.UseVisualStyleBackColor = true;
            this.BtnInclui.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAltera
            // 
            this.BtnAltera.Location = new System.Drawing.Point(321, 149);
            this.BtnAltera.Name = "BtnAltera";
            this.BtnAltera.Size = new System.Drawing.Size(75, 23);
            this.BtnAltera.TabIndex = 9;
            this.BtnAltera.Text = "Altera";
            this.BtnAltera.UseVisualStyleBackColor = true;
            this.BtnAltera.Click += new System.EventHandler(this.BtnAltera_Click);
            // 
            // BtnExclui
            // 
            this.BtnExclui.Location = new System.Drawing.Point(402, 149);
            this.BtnExclui.Name = "BtnExclui";
            this.BtnExclui.Size = new System.Drawing.Size(75, 23);
            this.BtnExclui.TabIndex = 10;
            this.BtnExclui.Text = "Exclui";
            this.BtnExclui.UseVisualStyleBackColor = true;
            this.BtnExclui.Click += new System.EventHandler(this.BtnExclui_Click);
            // 
            // ContarContatosPorCidade
            // 
            this.ContarContatosPorCidade.Location = new System.Drawing.Point(12, 345);
            this.ContarContatosPorCidade.Name = "ContarContatosPorCidade";
            this.ContarContatosPorCidade.Size = new System.Drawing.Size(217, 23);
            this.ContarContatosPorCidade.TabIndex = 13;
            this.ContarContatosPorCidade.Text = "Contar n° de contatos por cidade";
            this.ContarContatosPorCidade.UseVisualStyleBackColor = true;
            this.ContarContatosPorCidade.Click += new System.EventHandler(this.ContarContatosPorCidade_Click);
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "cadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contatoBindingSource
            // 
            this.contatoBindingSource.DataMember = "contato";
            this.contatoBindingSource.DataSource = this.cadastroDataSet;
            // 
            // contatoTableAdapter
            // 
            this.contatoTableAdapter.ClearBeforeFill = true;
            // 
            // DgvContato
            // 
            this.DgvContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvContato.Location = new System.Drawing.Point(12, 26);
            this.DgvContato.Name = "DgvContato";
            this.DgvContato.Size = new System.Drawing.Size(217, 186);
            this.DgvContato.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 233);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(505, 106);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 396);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DgvContato);
            this.Controls.Add(this.ContarContatosPorCidade);
            this.Controls.Add(this.BtnExclui);
            this.Controls.Add(this.BtnAltera);
            this.Controls.Add(this.BtnInclui);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbFeminino);
            this.Controls.Add(this.CbMasculino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CbMasculino;
        private System.Windows.Forms.CheckBox CbFeminino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.Button BtnInclui;
        private System.Windows.Forms.Button BtnAltera;
        private System.Windows.Forms.Button BtnExclui;
        private System.Windows.Forms.Button ContarContatosPorCidade;
        private cadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource contatoBindingSource;
        private cadastroDataSetTableAdapters.contatoTableAdapter contatoTableAdapter;
        private System.Windows.Forms.DataGridView DgvContato;
        private System.Windows.Forms.TextBox textBox1;
    }
}

