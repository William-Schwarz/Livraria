using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void ManipularDados()
        {

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
            else if (!validaTelefone(mskTelefone))
            {
                MessageBox.Show("Número de telefone inválido. Por favor, insira um número válido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskTelefone.Focus();
                return;
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
            string telefone = new string(mskTelefone.Text.Where(char.IsDigit).ToArray());
            string pattern = @"^\(\d{2}\)\s\d{4,5}-\d{4}$";

            return System.Text.RegularExpressions.Regex.IsMatch(telefone, pattern);
        }
    }
}