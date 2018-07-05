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

            CarregarCli();
            CarregarOleo();
           

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
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
            decimal qtde_litro, valor_litro, valor_total;

            qtde_litro = Convert.ToDecimal(txtQtdeLitro.Text);
            valor_litro = Convert.ToDecimal(txtValorLitro.Text);

            valor_total = qtde_litro * valor_litro;

            txtValorTotal.Text = valor_total.ToString();

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

        public void Salvar()
        {
            try
            {
                ClienteDAO clienteDao = new ClienteDAO();

                if (clienteDao.ValidarEmail(txtEmailCliente.Text) == false)
                {
                    txtEmailCliente.Clear();
                    MessageBox.Show("Email invállida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmailCliente.Focus();
                }
                else
                {
                    var obj = new ServicoTrocaOleo();
                    obj.Data = dtpData.Value;
                    obj.Cliente.Nome = cmbCliente.Text;
                    obj.Oleo.Nome = cmbOleo.Text;
                    obj.Categoria = cmbCategoria.Text;
                    obj.Tipo = cmbTipo.Text;
                    obj.Fabricante = cmbFabricante.Text;
                    obj.ValorTotal = txtValorTotal.Text;
                    obj.QtdeLitro = txtQtdeLitro.Text;
                    obj.Email = txtEmailCliente.Text;

                    new ServicoDAO().Inserir(obj);

                    MessageBox.Show("Dados salvos com sucesso");
                    this.Hide();
                    new Form1().Show();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("ERRO: " + er.Message);
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
