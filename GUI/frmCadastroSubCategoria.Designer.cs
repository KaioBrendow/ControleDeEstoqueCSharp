namespace GUI
{
    partial class frmCadastroSubCategoria
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
            pnBotoes = new Panel();
            btCancelar = new Button();
            btSalvar = new Button();
            btExcluir = new Button();
            btAlterar = new Button();
            btLocalizar = new Button();
            btInserir = new Button();
            pnDados = new Panel();
            txtNome = new TextBox();
            txtScatCod = new TextBox();
            label3 = new Label();
            cbCatCod = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            pnBotoes.SuspendLayout();
            pnDados.SuspendLayout();
            SuspendLayout();
            // 
            // pnBotoes
            // 
            pnBotoes.Controls.Add(btCancelar);
            pnBotoes.Controls.Add(btSalvar);
            pnBotoes.Controls.Add(btExcluir);
            pnBotoes.Controls.Add(btAlterar);
            pnBotoes.Controls.Add(btLocalizar);
            pnBotoes.Controls.Add(btInserir);
            pnBotoes.Location = new Point(8, 455);
            pnBotoes.Name = "pnBotoes";
            pnBotoes.Size = new Size(764, 94);
            pnBotoes.TabIndex = 3;
            // 
            // btCancelar
            // 
            btCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCancelar.Image = Properties.Resources.Cancelar;
            btCancelar.Location = new Point(661, 3);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(72, 86);
            btCancelar.TabIndex = 5;
            btCancelar.Text = "Cancelar";
            btCancelar.TextAlign = ContentAlignment.BottomCenter;
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btSalvar
            // 
            btSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btSalvar.Image = Properties.Resources.Salvar1_fw;
            btSalvar.Location = new Point(533, 3);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(72, 86);
            btSalvar.TabIndex = 4;
            btSalvar.Text = "Salvar";
            btSalvar.TextAlign = ContentAlignment.BottomCenter;
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btExcluir.Image = Properties.Resources.Excluir;
            btExcluir.Location = new Point(405, 3);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(72, 86);
            btExcluir.TabIndex = 3;
            btExcluir.Text = "Excluir";
            btExcluir.TextAlign = ContentAlignment.BottomCenter;
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // btAlterar
            // 
            btAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btAlterar.Image = Properties.Resources.Alterar;
            btAlterar.Location = new Point(277, 3);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(72, 86);
            btAlterar.TabIndex = 2;
            btAlterar.Text = "Alterar";
            btAlterar.TextAlign = ContentAlignment.BottomCenter;
            btAlterar.UseVisualStyleBackColor = true;
            btAlterar.Click += btAlterar_Click;
            // 
            // btLocalizar
            // 
            btLocalizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btLocalizar.Image = Properties.Resources.localizar_fw;
            btLocalizar.Location = new Point(149, 3);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(72, 86);
            btLocalizar.TabIndex = 1;
            btLocalizar.Text = "Localizar";
            btLocalizar.TextAlign = ContentAlignment.BottomCenter;
            btLocalizar.UseVisualStyleBackColor = true;
            btLocalizar.Click += btLocalizar_Click;
            // 
            // btInserir
            // 
            btInserir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btInserir.Image = Properties.Resources.Novo;
            btInserir.Location = new Point(21, 3);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(72, 86);
            btInserir.TabIndex = 0;
            btInserir.Text = "Inserir";
            btInserir.TextAlign = ContentAlignment.BottomCenter;
            btInserir.UseVisualStyleBackColor = true;
            btInserir.Click += btInserir_Click;
            // 
            // pnDados
            // 
            pnDados.Controls.Add(txtNome);
            pnDados.Controls.Add(txtScatCod);
            pnDados.Controls.Add(label3);
            pnDados.Controls.Add(cbCatCod);
            pnDados.Controls.Add(label2);
            pnDados.Controls.Add(label1);
            pnDados.Location = new Point(8, 9);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(764, 440);
            pnDados.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(21, 95);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(712, 23);
            txtNome.TabIndex = 5;
            // 
            // txtScatCod
            // 
            txtScatCod.Enabled = false;
            txtScatCod.Location = new Point(21, 36);
            txtScatCod.Name = "txtScatCod";
            txtScatCod.Size = new Size(98, 23);
            txtScatCod.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 149);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 3;
            label3.Text = "Nome da Categoria";
            // 
            // cbCatCod
            // 
            cbCatCod.FormattingEnabled = true;
            cbCatCod.Location = new Point(21, 167);
            cbCatCod.Name = "cbCatCod";
            cbCatCod.Size = new Size(360, 23);
            cbCatCod.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 77);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome da SubCategoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // frmCadastroSubCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(pnBotoes);
            Controls.Add(pnDados);
            Name = "frmCadastroSubCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de SubCategoria";
            Load += frmCadastroSubCategoria_Load;
            pnBotoes.ResumeLayout(false);
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        protected Panel pnBotoes;
        protected Button btCancelar;
        protected Button btSalvar;
        protected Button btExcluir;
        protected Button btAlterar;
        protected Button btLocalizar;
        protected Button btInserir;
        protected Panel pnDados;
        private Label label2;
        private Label label1;
        private ComboBox cbCatCod;
        private TextBox txtNome;
        private TextBox txtScatCod;
        private Label label3;

        public String operacao;

        public void alteraBotoes(int op)
        {
            pnDados.Enabled = false;
            btInserir.Enabled = false;
            btAlterar.Enabled = false;
            btLocalizar.Enabled = false;
            btExcluir.Enabled = false;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;
            if (op == 1)
            {
                btInserir.Enabled = true;
                btLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;
            }
        }
    }
}