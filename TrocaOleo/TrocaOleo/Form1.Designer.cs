﻿namespace TrocaOleo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtValorLitro = new System.Windows.Forms.TextBox();
            this.txtQtdeLitro = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbOleo = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblOleo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblVLitro = new System.Windows.Forms.Label();
            this.lblQLItro = new System.Windows.Forms.Label();
            this.lblVTotal = new System.Windows.Forms.Label();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodOleo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValorLitro
            // 
            this.txtValorLitro.Location = new System.Drawing.Point(271, 200);
            this.txtValorLitro.Name = "txtValorLitro";
            this.txtValorLitro.Size = new System.Drawing.Size(121, 20);
            this.txtValorLitro.TabIndex = 0;
            this.txtValorLitro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtQtdeLitro
            // 
            this.txtQtdeLitro.Location = new System.Drawing.Point(271, 226);
            this.txtQtdeLitro.Name = "txtQtdeLitro";
            this.txtQtdeLitro.Size = new System.Drawing.Size(121, 20);
            this.txtQtdeLitro.TabIndex = 1;
            this.txtQtdeLitro.TextChanged += new System.EventHandler(this.txtQtdeLitro_TextChanged);
            this.txtQtdeLitro.Validating += new System.ComponentModel.CancelEventHandler(this.txtQtdeLitro_Validating);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(271, 252);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(121, 20);
            this.txtValorTotal.TabIndex = 2;
            this.txtValorTotal.TextChanged += new System.EventHandler(this.txtValorTotal_TextChanged);
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(271, 31);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 3;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(271, 119);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 4;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // cmbOleo
            // 
            this.cmbOleo.FormattingEnabled = true;
            this.cmbOleo.Location = new System.Drawing.Point(271, 92);
            this.cmbOleo.Name = "cmbOleo";
            this.cmbOleo.Size = new System.Drawing.Size(121, 21);
            this.cmbOleo.TabIndex = 5;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(271, 146);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 6;
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(271, 173);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(121, 21);
            this.cmbFabricante.TabIndex = 7;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Enabled = false;
            this.txtEmailCliente.Location = new System.Drawing.Point(271, 278);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(121, 20);
            this.txtEmailCliente.TabIndex = 8;
            this.txtEmailCliente.TextChanged += new System.EventHandler(this.txtEmailCliente_TextChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(174, 11);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(271, 5);
            this.dateTimePicker1.MaxDate = new System.DateTime(2018, 7, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2018, 7, 1, 0, 0, 0, 0);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(174, 39);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 11;
            this.lblCliente.Text = "Cliente";
            // 
            // lblOleo
            // 
            this.lblOleo.AutoSize = true;
            this.lblOleo.Location = new System.Drawing.Point(174, 100);
            this.lblOleo.Name = "lblOleo";
            this.lblOleo.Size = new System.Drawing.Size(29, 13);
            this.lblOleo.TabIndex = 12;
            this.lblOleo.Text = "Óleo";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(174, 127);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(174, 154);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "Tipo";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(174, 181);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(57, 13);
            this.lblFabricante.TabIndex = 15;
            this.lblFabricante.Text = "Fabricante";
            // 
            // lblVLitro
            // 
            this.lblVLitro.AutoSize = true;
            this.lblVLitro.Location = new System.Drawing.Point(174, 207);
            this.lblVLitro.Name = "lblVLitro";
            this.lblVLitro.Size = new System.Drawing.Size(54, 13);
            this.lblVLitro.TabIndex = 16;
            this.lblVLitro.Text = "Valor Litro";
            // 
            // lblQLItro
            // 
            this.lblQLItro.AutoSize = true;
            this.lblQLItro.Location = new System.Drawing.Point(174, 233);
            this.lblQLItro.Name = "lblQLItro";
            this.lblQLItro.Size = new System.Drawing.Size(53, 13);
            this.lblQLItro.TabIndex = 17;
            this.lblQLItro.Text = "Qtde Litro";
            // 
            // lblVTotal
            // 
            this.lblVTotal.AutoSize = true;
            this.lblVTotal.Location = new System.Drawing.Point(174, 259);
            this.lblVTotal.Name = "lblVTotal";
            this.lblVTotal.Size = new System.Drawing.Size(58, 13);
            this.lblVTotal.TabIndex = 18;
            this.lblVTotal.Text = "Valor Total";
            this.lblVTotal.Click += new System.EventHandler(this.lblVTotal_Click);
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(174, 285);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(67, 13);
            this.lblEmailCliente.TabIndex = 19;
            this.lblEmailCliente.Text = "Email Cliente";
            this.lblEmailCliente.Click += new System.EventHandler(this.lblEmailCliente_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(412, 307);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Codigo";
            // 
            // txtCodOleo
            // 
            this.txtCodOleo.Location = new System.Drawing.Point(271, 66);
            this.txtCodOleo.Name = "txtCodOleo";
            this.txtCodOleo.Size = new System.Drawing.Size(67, 20);
            this.txtCodOleo.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodOleo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.lblVTotal);
            this.Controls.Add(this.lblQLItro);
            this.Controls.Add(this.lblVLitro);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblOleo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.cmbFabricante);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbOleo);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtQtdeLitro);
            this.Controls.Add(this.txtValorLitro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtValorLitro;
        private System.Windows.Forms.TextBox txtQtdeLitro;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbOleo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblOleo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblVLitro;
        private System.Windows.Forms.Label lblQLItro;
        private System.Windows.Forms.Label lblVTotal;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodOleo;
    }
}

