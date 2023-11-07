namespace Livraria
{
    partial class frmMenu
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnEditora = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnFones = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.frmCliente1 = new Livraria.frmCliente();
            this.frmFuncionario1 = new Livraria.frmFuncionario();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlMenu.Controls.Add(this.lblUsuarioLogado);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.btnCaixa);
            this.pnlMenu.Controls.Add(this.btnPedido);
            this.pnlMenu.Controls.Add(this.btnAutores);
            this.pnlMenu.Controls.Add(this.btnEditora);
            this.pnlMenu.Controls.Add(this.btnCategoria);
            this.pnlMenu.Controls.Add(this.btnLivros);
            this.pnlMenu.Controls.Add(this.btnFones);
            this.pnlMenu.Controls.Add(this.btnCliente);
            this.pnlMenu.Controls.Add(this.btnFunc);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 541);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(95, 525);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioLogado.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(3, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Usuário Logado:";
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSair.Image = global::Livraria.Properties.Resources.sair1;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 420);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(200, 40);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = " Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCaixa.Image = global::Livraria.Properties.Resources.forma_de_pagamento;
            this.btnCaixa.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCaixa.Location = new System.Drawing.Point(0, 380);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCaixa.Size = new System.Drawing.Size(200, 40);
            this.btnCaixa.TabIndex = 10;
            this.btnCaixa.Text = " Caixa";
            this.btnCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaixa.UseVisualStyleBackColor = true;
            // 
            // btnPedido
            // 
            this.btnPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPedido.Image = global::Livraria.Properties.Resources.pagamento;
            this.btnPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.Location = new System.Drawing.Point(0, 340);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPedido.Size = new System.Drawing.Size(200, 40);
            this.btnPedido.TabIndex = 9;
            this.btnPedido.Text = " Pedido";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPedido.UseVisualStyleBackColor = true;
            // 
            // btnAutores
            // 
            this.btnAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutores.FlatAppearance.BorderSize = 0;
            this.btnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAutores.Image = global::Livraria.Properties.Resources.autor;
            this.btnAutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutores.Location = new System.Drawing.Point(0, 300);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAutores.Size = new System.Drawing.Size(200, 40);
            this.btnAutores.TabIndex = 8;
            this.btnAutores.Text = " Autores";
            this.btnAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutores.UseVisualStyleBackColor = true;
            // 
            // btnEditora
            // 
            this.btnEditora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditora.FlatAppearance.BorderSize = 0;
            this.btnEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditora.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEditora.Image = global::Livraria.Properties.Resources.editora;
            this.btnEditora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditora.Location = new System.Drawing.Point(0, 260);
            this.btnEditora.Name = "btnEditora";
            this.btnEditora.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEditora.Size = new System.Drawing.Size(200, 40);
            this.btnEditora.TabIndex = 7;
            this.btnEditora.Text = " Editora";
            this.btnEditora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditora.UseVisualStyleBackColor = true;
            // 
            // btnCategoria
            // 
            this.btnCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCategoria.Image = global::Livraria.Properties.Resources.lista;
            this.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.Location = new System.Drawing.Point(0, 220);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCategoria.Size = new System.Drawing.Size(200, 40);
            this.btnCategoria.TabIndex = 6;
            this.btnCategoria.Text = " Categoria";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategoria.UseVisualStyleBackColor = true;
            // 
            // btnLivros
            // 
            this.btnLivros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLivros.FlatAppearance.BorderSize = 0;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnLivros.Image = global::Livraria.Properties.Resources.livros;
            this.btnLivros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLivros.Location = new System.Drawing.Point(0, 180);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLivros.Size = new System.Drawing.Size(200, 40);
            this.btnLivros.TabIndex = 5;
            this.btnLivros.Text = " Livros";
            this.btnLivros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLivros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLivros.UseVisualStyleBackColor = true;
            // 
            // btnFones
            // 
            this.btnFones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFones.FlatAppearance.BorderSize = 0;
            this.btnFones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFones.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnFones.Image = global::Livraria.Properties.Resources.telefone;
            this.btnFones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFones.Location = new System.Drawing.Point(0, 140);
            this.btnFones.Name = "btnFones";
            this.btnFones.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFones.Size = new System.Drawing.Size(200, 40);
            this.btnFones.TabIndex = 4;
            this.btnFones.Text = " Telefones";
            this.btnFones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFones.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCliente.Image = global::Livraria.Properties.Resources.cliente;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 100);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCliente.Size = new System.Drawing.Size(200, 40);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = " Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFunc.FlatAppearance.BorderSize = 0;
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnFunc.Image = global::Livraria.Properties.Resources.funcionario;
            this.btnFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunc.Location = new System.Drawing.Point(0, 60);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFunc.Size = new System.Drawing.Size(200, 40);
            this.btnFunc.TabIndex = 2;
            this.btnFunc.Text = " Funcionário";
            this.btnFunc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFunc.UseVisualStyleBackColor = true;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Black;
            this.pnlLogo.Controls.Add(this.label1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 60);
            this.pnlLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "WS Livraria";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // frmCliente1
            // 
            this.frmCliente1.Location = new System.Drawing.Point(200, 0);
            this.frmCliente1.Name = "frmCliente1";
            this.frmCliente1.Size = new System.Drawing.Size(802, 540);
            this.frmCliente1.TabIndex = 14;
            // 
            // frmFuncionario1
            // 
            this.frmFuncionario1.Location = new System.Drawing.Point(200, 0);
            this.frmFuncionario1.Name = "frmFuncionario1";
            this.frmFuncionario1.Size = new System.Drawing.Size(802, 540);
            this.frmFuncionario1.TabIndex = 1;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 541);
            this.Controls.Add(this.frmCliente1);
            this.Controls.Add(this.frmFuncionario1);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnEditora;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnFones;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label label1;
        private frmFuncionario frmFuncionario1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Label label2;
        private frmCliente frmCliente1;
    }
}