using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Data;

namespace Livraria
{
    public partial class frmFuncionario : UserControl
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        // Estabelecendo conexão com banco de dados sql server
        SqlConnection conn = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; integrated security = SSPI; initial Catalog = db_Livraria");

        SqlCommand cmd = new SqlCommand();

        SqlDataReader dt;

        private void desabilitaCampos()
        {
            lblCodigo.Visible = false;
            lblID.Visible = false;
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            btnNovo.Enabled = true;
            btnCopiar.Enabled = true;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnColar.Enabled = false;
        }

        private void habilitaCampos()
        {
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            txtNome.Focus();
            txtBusca.Text = "";
            dgvFunc.DataSource = null;
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtLogin.Clear();
            txtSenha.Clear();
            txtNome.Focus();
            txtBusca.Clear();
            lblCodigo.Visible = false;
            lblID.Visible = false;
            dgvFunc.DataSource = null;
        }

        private void ManipularDados()
        {
            lblCodigo.Visible = true;
            lblID.Visible = true;
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled= true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            habilitaCampos();
            btnCopiar.Enabled = false;
            ckAtivo.Enabled = false;
            txtBusca.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampos();
            limparCampos();
            btnCancelar.Enabled = false;
            ckAtivo.Enabled = true;
            txtBusca.Enabled = true;
            txtBusca.Focus();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Nome.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return;
            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Login.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
                return;
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Senha.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return;
            }
            else if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show("O campo Senha deve conter no mínimo 8 dígitos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return;
            }
            else
            {
                try
                {
                    string nome = txtNome.Text;
                    string login = txtLogin.Text;
                    string senha = txtSenha.Text;

                    string strSql = "insert into dbo.Funcionario(Nome, Login, Senha) values(@nome, @login, @senha)";

                    cmd.CommandText = strSql;
                    cmd.Connection = conn;

                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cmd.Parameters.Add("@senha", SqlDbType.Char).Value = senha;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    MessageBox.Show("Os dados foram gravados com sucesso.", "Inserção de Dados Concluída!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    desabilitaCampos();
                    ckAtivo.Enabled = true;
                    txtBusca.Enabled = true;
                    txtBusca.Focus();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                try
                {
                    conn.Open();
                    cmd.CommandText = "select * from dbo.Funcionario where Nome like ('" + txtBusca.Text + "%') ";
                    cmd.Connection = conn;

                    //Receber os dados de uma tabela após a execução de um select 
                    SqlDataAdapter da = new SqlDataAdapter();

                    //pode representar uma ou mais tabelas de dados, as quais permanecem alocadas em memória
                    DataTable dt = new DataTable();

                    //recebendo os dados da instrução select
                    da.SelectCommand = cmd;
                    da.Fill(dt); //preenchendo o DataTable
                    dgvFunc.DataSource = dt;
                    conn.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            { 
                dgvFunc.DataSource = null;
            }

            btnCancelar.Enabled = true;
        }

        private void CarregaFuncionario()
        { 
            lblID.Text = dgvFunc.SelectedRows[0].Cells[0].Value.ToString();
            txtNome.Text = dgvFunc.SelectedRows[0].Cells[1].Value.ToString();
            txtLogin.Text = dgvFunc.SelectedRows[0].Cells[2].Value.ToString();
            txtSenha.Text = dgvFunc.SelectedRows[0].Cells[3].Value.ToString();
            string Ativo = dgvFunc.SelectedRows[0].Cells[4].Value.ToString();

            if (Ativo == "True")
            {
                ckAtivo.Checked = true;
            }
            else
            {
                ckAtivo.Checked = false;
            }

            ManipularDados();
        }

        private void dgvFunc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregaFuncionario();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Nome.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return;
            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Login.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
                return;
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Senha.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return;
            }
            else if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show("O campo Senha deve conter no mínimo 8 dígitos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return;
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(lblID.Text);
                    string nome = txtNome.Text;
                    string login = txtLogin.Text;
                    string senha = txtSenha.Text;
                    bool ativo = ckAtivo.Checked;

                    string strSql = "update dbo.Funcionario set Nome = @nome ,Login = @login ,Senha = @senha, Ativo = @ativo where id = @id";

                    cmd.CommandText = strSql;
                    cmd.Connection = conn;

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cmd.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                    cmd.Parameters.Add("@ativo", SqlDbType.Bit).Value = ativo;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    MessageBox.Show("Os dados foram alterados com sucesso.", "Alteração de Dados Concluída!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //limparCampos();
                    txtBusca.Focus();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ckAtivo.Checked)
            {
                MessageBox.Show("Usuário ativo não pode ser excluído", "Erro ao tentar excluir!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult exclusao = MessageBox.Show("Você tem certeza que deseja excluir o registro?", "Exclusão de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (exclusao == DialogResult.No)
                {
                    return;
                }
                try
                {
                    int id = Convert.ToInt32(lblID.Text);

                    string strSql = "delete dbo.Funcionario where id = @id";

                    cmd.CommandText = strSql;
                    cmd.Connection = conn;

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    MessageBox.Show("O registro foi excluído.", "Exclusão Concluída!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    txtBusca.Focus();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}