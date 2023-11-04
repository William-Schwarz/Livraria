namespace Livraria
{
    partial class frmFuncionario
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFunc = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.gbPesquisaFunc = new System.Windows.Forms.GroupBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.ckAtivo = new System.Windows.Forms.CheckBox();
            this.btnColar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.gbPesquisaFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunc.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFunc.Location = new System.Drawing.Point(35, 10);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(152, 29);
            this.lblFunc.TabIndex = 0;
            this.lblFunc.Text = "Funcionário";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblCodigo.Location = new System.Drawing.Point(35, 70);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(84, 22);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Red;
            this.lblID.Location = new System.Drawing.Point(125, 70);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 22);
            this.lblID.TabIndex = 2;
            this.lblID.Visible = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(49, 130);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(70, 22);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login:";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(125, 130);
            this.txtLogin.MaxLength = 20;
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(200, 25);
            this.txtLogin.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(49, 100);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(70, 22);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(125, 100);
            this.txtNome.MaxLength = 60;
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(400, 25);
            this.txtNome.TabIndex = 6;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(43, 160);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(76, 22);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(125, 160);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(200, 25);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // dgvFunc
            // 
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Location = new System.Drawing.Point(47, 370);
            this.dgvFunc.MultiSelect = false;
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFunc.Size = new System.Drawing.Size(511, 150);
            this.dgvFunc.TabIndex = 9;
            this.dgvFunc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvFunc_MouseDoubleClick);
            // 
            // gbPesquisaFunc
            // 
            this.gbPesquisaFunc.Controls.Add(this.txtBusca);
            this.gbPesquisaFunc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPesquisaFunc.Location = new System.Drawing.Point(47, 300);
            this.gbPesquisaFunc.Name = "gbPesquisaFunc";
            this.gbPesquisaFunc.Size = new System.Drawing.Size(511, 60);
            this.gbPesquisaFunc.TabIndex = 11;
            this.gbPesquisaFunc.TabStop = false;
            this.gbPesquisaFunc.Text = "Pesquisa por Funcionário";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(78, 30);
            this.txtBusca.MaxLength = 60;
            this.txtBusca.Multiline = true;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(400, 25);
            this.txtBusca.TabIndex = 7;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // ckAtivo
            // 
            this.ckAtivo.AutoSize = true;
            this.ckAtivo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckAtivo.Location = new System.Drawing.Point(57, 190);
            this.ckAtivo.Name = "ckAtivo";
            this.ckAtivo.Size = new System.Drawing.Size(62, 20);
            this.ckAtivo.TabIndex = 32;
            this.ckAtivo.Text = "Ativo";
            this.ckAtivo.UseVisualStyleBackColor = true;
            // 
            // btnColar
            // 
            this.btnColar.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColar.Image = global::Livraria.Properties.Resources.colar;
            this.btnColar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColar.Location = new System.Drawing.Point(383, 0);
            this.btnColar.Margin = new System.Windows.Forms.Padding(0);
            this.btnColar.Name = "btnColar";
            this.btnColar.Size = new System.Drawing.Size(80, 60);
            this.btnColar.TabIndex = 30;
            this.btnColar.Text = "Colar";
            this.btnColar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnColar.UseVisualStyleBackColor = true;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.Image = global::Livraria.Properties.Resources.copiar;
            this.btnCopiar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCopiar.Location = new System.Drawing.Point(303, 0);
            this.btnCopiar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(80, 60);
            this.btnCopiar.TabIndex = 29;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCopiar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Livraria.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.Location = new System.Drawing.Point(703, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 60);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::Livraria.Properties.Resources.excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.Location = new System.Drawing.Point(543, 0);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 60);
            this.btnExcluir.TabIndex = 27;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::Livraria.Properties.Resources.alterar;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.Location = new System.Drawing.Point(623, 0);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(80, 60);
            this.btnAlterar.TabIndex = 26;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::Livraria.Properties.Resources.salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.Location = new System.Drawing.Point(463, 0);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 60);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::Livraria.Properties.Resources.novo;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.Location = new System.Drawing.Point(223, 0);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(80, 60);
            this.btnNovo.TabIndex = 24;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckAtivo);
            this.Controls.Add(this.btnColar);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gbPesquisaFunc);
            this.Controls.Add(this.dgvFunc);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblFunc);
            this.Name = "frmFuncionario";
            this.Size = new System.Drawing.Size(802, 540);
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.gbPesquisaFunc.ResumeLayout(false);
            this.gbPesquisaFunc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.GroupBox gbPesquisaFunc;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnColar;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.CheckBox ckAtivo;
    }
}
