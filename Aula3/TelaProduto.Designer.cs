namespace Aula3
{
    partial class TelaProduto
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
            this.txtCodigo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.Label();
            this.cbxCodigo = new System.Windows.Forms.TextBox();
            this.cbxNome = new System.Windows.Forms.TextBox();
            this.cbxValor = new System.Windows.Forms.TextBox();
            this.cbxDescricao = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(198, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 24);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "Código:";
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(198, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(67, 24);
            this.txtNome.TabIndex = 2;
            this.txtNome.Text = "Nome:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.AutoSize = true;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(198, 88);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(99, 24);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.Text = "Descrição:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.AutoSize = true;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(198, 123);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(95, 24);
            this.txtCategoria.TabIndex = 4;
            this.txtCategoria.Text = "Categoria:";
            // 
            // txtValor
            // 
            this.txtValor.AutoSize = true;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(198, 159);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(59, 24);
            this.txtValor.TabIndex = 5;
            this.txtValor.Text = "Valor:";
            // 
            // cbxCodigo
            // 
            this.cbxCodigo.Location = new System.Drawing.Point(307, 19);
            this.cbxCodigo.Name = "cbxCodigo";
            this.cbxCodigo.Size = new System.Drawing.Size(119, 20);
            this.cbxCodigo.TabIndex = 6;
            // 
            // cbxNome
            // 
            this.cbxNome.Location = new System.Drawing.Point(307, 54);
            this.cbxNome.Name = "cbxNome";
            this.cbxNome.Size = new System.Drawing.Size(421, 20);
            this.cbxNome.TabIndex = 7;
            // 
            // cbxValor
            // 
            this.cbxValor.Location = new System.Drawing.Point(307, 164);
            this.cbxValor.Name = "cbxValor";
            this.cbxValor.Size = new System.Drawing.Size(220, 20);
            this.cbxValor.TabIndex = 8;
            // 
            // cbxDescricao
            // 
            this.cbxDescricao.Location = new System.Drawing.Point(307, 93);
            this.cbxDescricao.Name = "cbxDescricao";
            this.cbxDescricao.Size = new System.Drawing.Size(421, 20);
            this.cbxDescricao.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(199, 202);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(131, 44);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(396, 202);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(131, 44);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(597, 202);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(131, 44);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(199, 266);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(529, 172);
            this.dgvDados.TabIndex = 14;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(307, 128);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(421, 21);
            this.cbxCategoria.TabIndex = 15;
            // 
            // TelaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbxDescricao);
            this.Controls.Add(this.cbxValor);
            this.Controls.Add(this.cbxNome);
            this.Controls.Add(this.cbxCodigo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Name = "TelaProduto";
            this.Text = "TelaProduto";
            this.Load += new System.EventHandler(this.TelaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCodigo;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label txtDescricao;
        private System.Windows.Forms.Label txtCategoria;
        private System.Windows.Forms.Label txtValor;
        private System.Windows.Forms.TextBox cbxCodigo;
        private System.Windows.Forms.TextBox cbxNome;
        private System.Windows.Forms.TextBox cbxValor;
        private System.Windows.Forms.TextBox cbxDescricao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.ComboBox cbxCategoria;
    }
}