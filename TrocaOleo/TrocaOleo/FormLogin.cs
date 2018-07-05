using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaOleo
{
    public partial class FormLogin : Form
    {
        public Usuario usuario { get; set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {


        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FazerLogin();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void FazerLogin()
        {
            if (!ValidarCampos())
                return;

            var obj = new Usuario()
            {
                Email = txtEmail.Text,
                Senha = txtSenha.Text
            };

            var result = new UsuarioDAO().Logar(obj);
            if (result != null)
            {
                this.usuario = result;
                DialogResult = DialogResult.OK;
            }
            else
            {
                txtSenha.Text = string.Empty;
                txtEmail.Text = string.Empty;

                MessageBox.Show("Email ou senha inválido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
            }
        }

        private bool ValidarCampos()
        {
            txtSenha.Clear();
            txtEmail.Clear();
            var aux = true;
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                aux = false;
                MessageBox.Show("Campo obrigatório!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                aux = false;
                MessageBox.Show("Campo obrigatório!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return aux;
        }

        private void FormLogin_Load_1(object sender, EventArgs e)
        {
            Usuario obj = new Usuario();

            obj.Email = txtEmail.Text;
            obj.Senha = txtSenha.Text;

            try
            {
                var usuario = new UsuarioDAO().Logar(obj);

                if (!usuario.Senha.Equals(txtSenha.Text))
                {
                    txtSenha.Clear();
                    MessageBox.Show("Senha invállida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha.Focus();
                }
                else if (!usuario.Email.Equals(txtEmail.Text))
                {
                    new UsuarioDAO().Inserir(obj);
                    MessageBox.Show("Nova conta salva");
                    this.Hide();
                    new Form1().Show();
                }
                else
                {
                    MessageBox.Show("Logado com sucesso");
                    this.Hide();
           
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("ERRO: " + er.Message);
            }
        }
    }
}

