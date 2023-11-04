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

namespace Livraria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string LoginFuncionario;
        public static string IdFuncionario;

        // Estabelecendo conexão com banco de dados sql server
        SqlConnection conn = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; integrated security = SSPI; initial Catalog = db_Livraria");

        SqlCommand cmd = new SqlCommand();

        //SqlDataReader dt;

        private void Login_Load(object sender, EventArgs e)
        {
        
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Obrigatório preencher os campos Login e Senha", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                try
                {
                    conn.Open();
                    cmd.CommandText = "select * from Funcionario where Login = ('"+txtLogin.Text+"') and Senha = ('"+txtPassword.Text+"') and Ativo = 1";
                    cmd.Connection = conn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        IdFuncionario = dt.Rows[0]["Id"].ToString();
                        LoginFuncionario = dt.Rows[0]["Login"].ToString();
                        frmMenu menu = new frmMenu();
                        menu .Show();
                        this.Hide();
                    }
                    else {
                        MessageBox.Show("Usuário ou Senha inválidos", "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLogin.Clear();
                        txtPassword.Clear();
                        txtLogin.Focus();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    conn.Close();
                }
                finally {
                    conn.Close();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
