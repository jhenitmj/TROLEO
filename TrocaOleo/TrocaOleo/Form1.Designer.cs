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
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbOleo = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
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
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValorLitro
            // 
            this.txtValorLitro.Location = new System.Drawing.Point(380, 353);
            this.txtValorLitro.Name = "txtValorLitro";
            this.txtValorLitro.Size = new System.Drawing.Size(121, 20);
            this.txtValorLitro.TabIndex = 21;
            this.txtValorLitro.UseWaitCursor = true;
            this.txtValorLitro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtQtdeLitro
            // 
            this.txtQtdeLitro.Location = new System.Drawing.Point(380, 397);
            this.txtQtdeLitro.Name = "txtQtdeLitro";
            this.txtQtdeLitro.Size = new System.Drawing.Size(121, 20);
            this.txtQtdeLitro.TabIndex = 1;
            this.txtQtdeLitro.TextChanged += new System.EventHandler(this.txtQtdeLitro_TextChanged);
            this.txtQtdeLitro.Validating += new System.ComponentModel.CancelEventHandler(this.txtQtdeLitro_Validating);
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(380, 153);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 3;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(380, 237);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 4;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // cmbOleo
            // 
            this.cmbOleo.FormattingEnabled = true;
            this.cmbOleo.Location = new System.Drawing.Point(380, 192);
            this.cmbOleo.Name = "cmbOleo";
            this.cmbOleo.Size = new System.Drawing.Size(121, 21);
            this.cmbOleo.TabIndex = 5;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(380, 278);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 6;
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(380, 314);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(121, 21);
            this.cmbFabricante.TabIndex = 7;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblData.Location = new System.Drawing.Point(263, 118);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(73, 29);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "Data";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCliente.Location = new System.Drawing.Point(263, 153);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(101, 29);
            this.lblCliente.TabIndex = 11;
            this.lblCliente.Text = "Cliente";
            // 
            // lblOleo
            // 
            this.lblOleo.AutoSize = true;
            this.lblOleo.BackColor = System.Drawing.Color.Transparent;
            this.lblOleo.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOleo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblOleo.Location = new System.Drawing.Point(289, 192);
            this.lblOleo.Name = "lblOleo";
            this.lblOleo.Size = new System.Drawing.Size(71, 29);
            this.lblOleo.TabIndex = 12;
            this.lblOleo.Text = "Óleo";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCategoria.Location = new System.Drawing.Point(224, 237);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(136, 29);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTipo.Location = new System.Drawing.Point(289, 278);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(68, 29);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "Tipo";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.BackColor = System.Drawing.Color.Transparent;
            this.lblFabricante.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabricante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFabricante.Location = new System.Drawing.Point(217, 314);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(147, 29);
            this.lblFabricante.TabIndex = 15;
            this.lblFabricante.Text = "Fabricante";
            // 
            // lblVLitro
            // 
            this.lblVLitro.AutoSize = true;
            this.lblVLitro.BackColor = System.Drawing.Color.Transparent;
            this.lblVLitro.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVLitro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblVLitro.Location = new System.Drawing.Point(218, 353);
            this.lblVLitro.Name = "lblVLitro";
            this.lblVLitro.Size = new System.Drawing.Size(146, 29);
            this.lblVLitro.TabIndex = 16;
            this.lblVLitro.Text = "Valor Litro";
            // 
            // lblQLItro
            // 
            this.lblQLItro.AutoSize = true;
            this.lblQLItro.BackColor = System.Drawing.Color.Transparent;
            this.lblQLItro.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLItro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblQLItro.Location = new System.Drawing.Point(223, 397);
            this.lblQLItro.Name = "lblQLItro";
            this.lblQLItro.Size = new System.Drawing.Size(141, 29);
            this.lblQLItro.TabIndex = 17;
            this.lblQLItro.Text = "Qtde Litro";
            // 
            // lblVTotal
            // 
            this.lblVTotal.AutoSize = true;
            this.lblVTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblVTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblVTotal.Location = new System.Drawing.Point(212, 436);
            this.lblVTotal.Name = "lblVTotal";
            this.lblVTotal.Size = new System.Drawing.Size(152, 29);
            this.lblVTotal.TabIndex = 18;
            this.lblVTotal.Text = "Valor Total";
            this.lblVTotal.Click += new System.EventHandler(this.lblVTotal_Click);
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEmailCliente.Location = new System.Drawing.Point(181, 477);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(179, 29);
            this.lblEmailCliente.TabIndex = 19;
            this.lblEmailCliente.Text = "Email Cliente";
            this.lblEmailCliente.Click += new System.EventHandler(this.lblEmailCliente_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(522, 507);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 31);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(380, 115);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(183, 32);
            this.dtpData.TabIndex = 21;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(380, 440);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(121, 20);
            this.txtValorTotal.TabIndex = 22;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(380, 486);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(121, 20);
            this.txtEmailCliente.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(307, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 44);
            this.label1.TabIndex = 24;
            this.label1.Text = "TROCA DE  ÓLEO CA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::TrocaOleo.Properties.Resources.download;
            this.ClientSize = new System.Drawing.Size(842, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.dtpData);
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
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cmbFabricante);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbOleo);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbCliente);
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
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbOleo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.Label lblData;
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
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label label1;
    }
}

