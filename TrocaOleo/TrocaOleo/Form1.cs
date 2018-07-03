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
            if (txtValorTotal.Text != null)
            {
                txtEmailCliente.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarCategorias();

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //ServicoDAO servicoDAO = new ServicoDAO();
            //servicoDAO.Inserir(ServicoTrocaOleo);
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

        private void CarregarCategorias()
        {
            var lst = new List<Oleo>();
            lst.AddRange(new OleoDAO().CarregarCategoria());
            cmbCategoria.DataSource = lst;
            cmbCategoria.DisplayMember = "NOME";
            cmbCategoria.ValueMember = "CATEGORIA";
            cmbCategoria.SelectedIndex = 0;
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
