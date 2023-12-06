using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class frmCliente : UserControl
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        // Estabelecendo conexão com banco de dados sql server
        SqlConnection conn = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; integrated security = SSPI; initial Catalog = db_Livraria");

        SqlCommand cmd = new SqlCommand();

        SqlDataReader dt;
        private void desabilitaCampos()
        {
            btnCopiar.Enabled = false;
            btnColar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            lblCodigo.Visible = false;
            lblID.Visible = false;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            cboPessoa.Enabled = false;
            txtLogradouro.Enabled = false;
            txtComplemento.Enabled = false;
            txtCidade.Enabled = false;
            cboUF.Enabled = false;
            mskTelefone.Enabled = false;
            mskCPF.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            mskCEP.Enabled = false;
            ckAtivo.Enabled = false;
        }

        private void habilitaCampos()
        {
            btnCopiar.Enabled = true;
            btnColar.Enabled = true;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;
            lblCodigo.Visible = true;
            lblID.Visible = true;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            cboPessoa.Enabled = true;
            txtLogradouro.Enabled = true;
            txtComplemento.Enabled = true;
            txtCidade.Enabled = true;
            cboUF.Enabled = true;
            mskTelefone.Enabled = true;
            mskCPF.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            mskCEP.Enabled = true;
            ckAtivo.Enabled = false;
        }

        private void limparCampos()
        {
            lblCodigo.Visible = false;
            lblID.Visible = false;
            txtNome.Clear();
            txtEmail.Clear();
            cboPessoa.SelectedIndex = -1;
            txtLogradouro.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            cboUF.SelectedIndex = -1;
            mskTelefone.Clear();
            mskCPF.Clear();
            txtNumero.Clear();
            mskCEP.Clear();
            ckAtivo.Checked = false;
            txtBusca.Clear();
            dgvCliente.DataSource = null;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampos();
            limparCampos();
        }

        private void cboPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPessoa.SelectedIndex == -1 || cboPessoa.SelectedIndex == 0)
            {
                lblCNPJ.Visible = false;
                mskCNPJ.Visible = false;
            }
            else 
            {
                lblCNPJ.Visible = true;
                mskCNPJ.Visible = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string telefone = mskTelefone.Text;
            string cep = mskCEP.Text;

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Obrigatório informar o campo Nome.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            else if (!validaEmail(email))
            {
                MessageBox.Show("E-mail inválido. Por favor, insira um e-mail válido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            else if (mskTelefone.Text.Length < 11) 
            {
                {
                    MessageBox.Show("Número inválido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mskTelefone.Focus();
                }
            }
            /*
            else if (!validaTelefone(mskTelefone))
            {
                MessageBox.Show("Número de telefone inválido. Por favor, insira um número válido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskTelefone.Focus();
                return;
            }
            */
            else if (cboPessoa.SelectedIndex == -1)
            {
                MessageBox.Show("Obrigatório informar o tipo de pessoa", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if(cboPessoa.SelectedIndex == 0 && mskCPF.Text.Length < 11)
            {
                {
                    MessageBox.Show("CPF inválido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mskCPF.Focus();
                }
            }

            else if (cboPessoa.SelectedIndex == 1 && mskCNPJ.Text.Length < 14)
            {
                {
                    MessageBox.Show("CNPJ inválido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mskCNPJ.Focus();
                }
            }
            else if (txtLogradouro.Text == "")
            {
                MessageBox.Show("Obrigatório informar o logradouro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogradouro.Focus();
            }
            else if (txtNumero.Text == "")
            {
                MessageBox.Show("Obrigatório informar o número.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumero.Focus();
            }
            else if (txtCidade.Text == "")
            {
                MessageBox.Show("Obrigatório informar a cidade.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCidade.Focus();
            }
            else if (txtBairro.Text == "")
            {
                MessageBox.Show("Obrigatório informar o bairro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBairro.Focus();
            }
            else if (cboUF.Text == "")
            {
                MessageBox.Show("Obrigatório selecionar um UF.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboUF.Focus();
            }
            else if (!validaCEP(cep))
            {
                MessageBox.Show("CEP inválido. Por favor, insira um CEP válido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskCEP.Focus();
                return;
            }
            else
            {
                //inserir dados no banco
                try
                {
                    int id = Convert.ToInt32(lblID.Text);
                    string nome = txtNome.Text;
                    string _email = txtEmail.Text;
                    int cpf = Convert.ToInt32(mskCPF.Text);
                    int cnpj = Convert.ToInt32(mskCNPJ.Text);
                    string logradouro = txtLogradouro.Text;
                    int numero = Convert.ToInt32(txtNumero.Text);
                    string complemento = txtComplemento.Text;
                    string bairro = txtBairro.Text;
                    string cidade = txtCidade.Text;
                    string uf = cboUF.Text;
                    int _cep = Convert.ToInt32(mskCEP.Text);
                    bool ativo = ckAtivo.Checked;
                }
            }

        }

        // Function para validar email
        private bool validaEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email && email.Contains(".") && email.IndexOf(".", StringComparison.Ordinal) > email.IndexOf("@", StringComparison.Ordinal);
            }
            catch
            {
                return false;
            }
        }

        //Function para validar telefone
        private bool validaTelefone(MaskedTextBox mskTelefone)
        {
            // Obtém apenas os dígitos do número do telefone
            string telefone = new string(mskTelefone.Text.Where(char.IsDigit).ToArray());

            // Verifica se o número possui o formato adequado
            string pattern = @"^\(\d{2}\)\s\d{4,5}-\d{4}$";
            bool isValid = System.Text.RegularExpressions.Regex.IsMatch(telefone, pattern);

            return isValid;
        }

        //Function para validar CEP
        private bool validaCEP(string cep)
        {
            // Expressão regular para validar o formato do CEP
            Regex regex = new Regex(@"^\d{5}-?\d{3}$");

            // Verifica se o CEP possui o formato adequado
            return regex.IsMatch(cep);
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string telefone = mskTelefone.Text;

            MessageBox.Show(telefone, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}