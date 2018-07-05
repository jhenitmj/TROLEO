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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
              
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtValorLitro.Focus();
            CarregarCli();
            CarregarOleo();
           

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDAO clienteDao = new ClienteDAO();

                if (clienteDao.ValidarEmail(txtEmailCliente.Text) == false)
                {
                    txtEmailCliente.Clear();
                    MessageBox.Show("EMAIL INVALIDO", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmailCliente.Focus();
                }
                else
                {
                    var obj = new ServicoTrocaOleo();
                    obj.Data = dtpData.Value;
                    obj.Cliente = cmbCliente.Text;
                    obj.Oleo = cmbOleo.Text;
                    obj.Categoria = cmbCategoria.Text;
                    obj.Tipo = cmbTipo.Text;
                    obj.Fabricante = cmbFabricante.Text;
                    obj.ValorTotal = Convert.ToInt32(txtValorTotal.Text);
                    obj.QtdeLitro = txtQtdeLitro.Text;
                    obj.Email = txtEmailCliente.Text;

                    new ServicoDAO().Inserir(obj);

                    MessageBox.Show("DADOS SALVOS COM SUCESSO");
                    this.Hide();
                    new Form1().Show();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("ERRO: " + er.Message);
            }
        

    }

    private void lblVTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblEmailCliente_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailCliente_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtQtdeLitro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQtdeLitro_Validating(object sender, CancelEventArgs e)
        { 

            decimal Valor1 = 0, Valor2 = 0, Resultado = 0;

            if (txtValorLitro.Text != "" && txtQtdeLitro.Text != "")
            {
                Valor1 = decimal.Parse(txtValorLitro.Text);
                Valor2 = decimal.Parse(txtQtdeLitro.Text);

                Resultado = Valor1 * Valor2;

            }
            txtValorTotal.Text = Resultado.ToString();

        }

        private void CarregarOleo()
        {
            var lst = new List<Oleo>();
            lst.AddRange(new OleoDAO().CarregarOleo());

            foreach (var item in lst)
            {
                cmbCategoria.Items.Add(item.Categoria);
                cmbOleo.Items.Add(item.Nome);
                cmbTipo.Items.Add(item.Tipo);
                cmbFabricante.Items.Add(item.Fabricante);
            }
      
        }

        private void CarregarCli()
        {
            ClienteDAO clienteDao = new ClienteDAO();
            List<Cliente> cliente = clienteDao.CarregarCliente();

            foreach (var cli in cliente)
            {
                cmbCliente.Items.Add(cli.Nome);
            }

        }

        
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
