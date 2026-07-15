/*
 * Created by SharpDevelop.
 * User: Alex Junio
 * Date: 14/07/2026
 * Time: 22:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ATIVIDADE_04_Controle_de_Estacionamento
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox gboRegistroVeiculos;
		private System.Windows.Forms.ComboBox cboTipoVeiculo;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.TextBox txtPlaca;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.Label lblModelo;
		private System.Windows.Forms.Label lblPlaca;
		private System.Windows.Forms.GroupBox gboHorarios;
		private System.Windows.Forms.DateTimePicker dtpSaida;
		private System.Windows.Forms.DateTimePicker dtpEntrada;
		private System.Windows.Forms.Label lblSaida;
		private System.Windows.Forms.Label lblEntrada;
		private System.Windows.Forms.GroupBox gboFiltrosBuscas;
		private System.Windows.Forms.Button btnMostrarTodos;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.TextBox txtPesquisarPlaca;
		private System.Windows.Forms.Label lblPesquisarPlaca;
		private System.Windows.Forms.GroupBox gboPatioMovimentacoes;
		private System.Windows.Forms.GroupBox gboIndicadores;
		private System.Windows.Forms.Label lblFinalizados;
		private System.Windows.Forms.Label lblTotalRecebido;
		private System.Windows.Forms.Label lblEstacionados;
		private System.Windows.Forms.Button btnRegistrarEntrada;
		private System.Windows.Forms.Button btnRegistrarSaida;
		private System.Windows.Forms.Button btnRemover;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.DataGridView dgvVeiculos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.gboRegistroVeiculos = new System.Windows.Forms.GroupBox();
			this.cboTipoVeiculo = new System.Windows.Forms.ComboBox();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.txtPlaca = new System.Windows.Forms.TextBox();
			this.lblTipo = new System.Windows.Forms.Label();
			this.lblModelo = new System.Windows.Forms.Label();
			this.lblPlaca = new System.Windows.Forms.Label();
			this.gboHorarios = new System.Windows.Forms.GroupBox();
			this.dtpSaida = new System.Windows.Forms.DateTimePicker();
			this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
			this.lblSaida = new System.Windows.Forms.Label();
			this.lblEntrada = new System.Windows.Forms.Label();
			this.gboFiltrosBuscas = new System.Windows.Forms.GroupBox();
			this.btnMostrarTodos = new System.Windows.Forms.Button();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.txtPesquisarPlaca = new System.Windows.Forms.TextBox();
			this.lblPesquisarPlaca = new System.Windows.Forms.Label();
			this.gboPatioMovimentacoes = new System.Windows.Forms.GroupBox();
			this.dgvVeiculos = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gboIndicadores = new System.Windows.Forms.GroupBox();
			this.lblFinalizados = new System.Windows.Forms.Label();
			this.lblTotalRecebido = new System.Windows.Forms.Label();
			this.lblEstacionados = new System.Windows.Forms.Label();
			this.btnRegistrarEntrada = new System.Windows.Forms.Button();
			this.btnRegistrarSaida = new System.Windows.Forms.Button();
			this.btnRemover = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.gboRegistroVeiculos.SuspendLayout();
			this.gboHorarios.SuspendLayout();
			this.gboFiltrosBuscas.SuspendLayout();
			this.gboPatioMovimentacoes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
			this.gboIndicadores.SuspendLayout();
			this.SuspendLayout();
			// 
			// gboRegistroVeiculos
			// 
			this.gboRegistroVeiculos.Controls.Add(this.cboTipoVeiculo);
			this.gboRegistroVeiculos.Controls.Add(this.txtModelo);
			this.gboRegistroVeiculos.Controls.Add(this.txtPlaca);
			this.gboRegistroVeiculos.Controls.Add(this.lblTipo);
			this.gboRegistroVeiculos.Controls.Add(this.lblModelo);
			this.gboRegistroVeiculos.Controls.Add(this.lblPlaca);
			this.gboRegistroVeiculos.Location = new System.Drawing.Point(17, 11);
			this.gboRegistroVeiculos.Name = "gboRegistroVeiculos";
			this.gboRegistroVeiculos.Size = new System.Drawing.Size(662, 263);
			this.gboRegistroVeiculos.TabIndex = 0;
			this.gboRegistroVeiculos.TabStop = false;
			this.gboRegistroVeiculos.Text = "Registro de Veículos";
			// 
			// cboTipoVeiculo
			// 
			this.cboTipoVeiculo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboTipoVeiculo.FormattingEnabled = true;
			this.cboTipoVeiculo.Items.AddRange(new object[] {
			"Moto ",
			"Carro ",
			"Utilitário"});
			this.cboTipoVeiculo.Location = new System.Drawing.Point(69, 211);
			this.cboTipoVeiculo.Name = "cboTipoVeiculo";
			this.cboTipoVeiculo.Size = new System.Drawing.Size(235, 30);
			this.cboTipoVeiculo.TabIndex = 5;
			// 
			// txtModelo
			// 
			this.txtModelo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtModelo.Location = new System.Drawing.Point(96, 134);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(208, 30);
			this.txtModelo.TabIndex = 4;
			// 
			// txtPlaca
			// 
			this.txtPlaca.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPlaca.Location = new System.Drawing.Point(81, 61);
			this.txtPlaca.Name = "txtPlaca";
			this.txtPlaca.Size = new System.Drawing.Size(208, 30);
			this.txtPlaca.TabIndex = 3;
			// 
			// lblTipo
			// 
			this.lblTipo.AutoSize = true;
			this.lblTipo.Location = new System.Drawing.Point(6, 211);
			this.lblTipo.Name = "lblTipo";
			this.lblTipo.Size = new System.Drawing.Size(57, 30);
			this.lblTipo.TabIndex = 2;
			this.lblTipo.Text = "Tipo:";
			// 
			// lblModelo
			// 
			this.lblModelo.AutoSize = true;
			this.lblModelo.Location = new System.Drawing.Point(6, 134);
			this.lblModelo.Name = "lblModelo";
			this.lblModelo.Size = new System.Drawing.Size(84, 30);
			this.lblModelo.TabIndex = 1;
			this.lblModelo.Text = "Modelo:";
			// 
			// lblPlaca
			// 
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Location = new System.Drawing.Point(6, 61);
			this.lblPlaca.Name = "lblPlaca";
			this.lblPlaca.Size = new System.Drawing.Size(69, 30);
			this.lblPlaca.TabIndex = 0;
			this.lblPlaca.Text = "Placa:";
			// 
			// gboHorarios
			// 
			this.gboHorarios.Controls.Add(this.dtpSaida);
			this.gboHorarios.Controls.Add(this.dtpEntrada);
			this.gboHorarios.Controls.Add(this.lblSaida);
			this.gboHorarios.Controls.Add(this.lblEntrada);
			this.gboHorarios.Location = new System.Drawing.Point(696, 13);
			this.gboHorarios.Name = "gboHorarios";
			this.gboHorarios.Size = new System.Drawing.Size(479, 176);
			this.gboHorarios.TabIndex = 1;
			this.gboHorarios.TabStop = false;
			this.gboHorarios.Text = "Horários";
			// 
			// dtpSaida
			// 
			this.dtpSaida.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpSaida.Location = new System.Drawing.Point(83, 115);
			this.dtpSaida.Name = "dtpSaida";
			this.dtpSaida.Size = new System.Drawing.Size(200, 28);
			this.dtpSaida.TabIndex = 3;
			// 
			// dtpEntrada
			// 
			this.dtpEntrada.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEntrada.Location = new System.Drawing.Point(102, 54);
			this.dtpEntrada.Name = "dtpEntrada";
			this.dtpEntrada.Size = new System.Drawing.Size(200, 28);
			this.dtpEntrada.TabIndex = 2;
			// 
			// lblSaida
			// 
			this.lblSaida.AutoSize = true;
			this.lblSaida.Location = new System.Drawing.Point(6, 115);
			this.lblSaida.Name = "lblSaida";
			this.lblSaida.Size = new System.Drawing.Size(71, 30);
			this.lblSaida.TabIndex = 1;
			this.lblSaida.Text = "Saída:";
			// 
			// lblEntrada
			// 
			this.lblEntrada.AutoSize = true;
			this.lblEntrada.Location = new System.Drawing.Point(6, 52);
			this.lblEntrada.Name = "lblEntrada";
			this.lblEntrada.Size = new System.Drawing.Size(90, 30);
			this.lblEntrada.TabIndex = 0;
			this.lblEntrada.Text = "Entrada:";
			// 
			// gboFiltrosBuscas
			// 
			this.gboFiltrosBuscas.Controls.Add(this.btnMostrarTodos);
			this.gboFiltrosBuscas.Controls.Add(this.btnPesquisar);
			this.gboFiltrosBuscas.Controls.Add(this.txtPesquisarPlaca);
			this.gboFiltrosBuscas.Controls.Add(this.lblPesquisarPlaca);
			this.gboFiltrosBuscas.Location = new System.Drawing.Point(15, 290);
			this.gboFiltrosBuscas.Name = "gboFiltrosBuscas";
			this.gboFiltrosBuscas.Size = new System.Drawing.Size(1159, 88);
			this.gboFiltrosBuscas.TabIndex = 2;
			this.gboFiltrosBuscas.TabStop = false;
			this.gboFiltrosBuscas.Text = "Filtros e Buscas";
			// 
			// btnMostrarTodos
			// 
			this.btnMostrarTodos.AutoSize = true;
			this.btnMostrarTodos.Location = new System.Drawing.Point(855, 48);
			this.btnMostrarTodos.Name = "btnMostrarTodos";
			this.btnMostrarTodos.Size = new System.Drawing.Size(153, 40);
			this.btnMostrarTodos.TabIndex = 3;
			this.btnMostrarTodos.Text = "Mostrar Todos";
			this.btnMostrarTodos.UseVisualStyleBackColor = true;
			this.btnMostrarTodos.Click += new System.EventHandler(this.BtnMostrarTodosClick);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.AutoSize = true;
			this.btnPesquisar.Location = new System.Drawing.Point(681, 49);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(112, 40);
			this.btnPesquisar.TabIndex = 2;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisarClick);
			// 
			// txtPesquisarPlaca
			// 
			this.txtPesquisarPlaca.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPesquisarPlaca.Location = new System.Drawing.Point(176, 49);
			this.txtPesquisarPlaca.Name = "txtPesquisarPlaca";
			this.txtPesquisarPlaca.Size = new System.Drawing.Size(339, 30);
			this.txtPesquisarPlaca.TabIndex = 1;
			// 
			// lblPesquisarPlaca
			// 
			this.lblPesquisarPlaca.AutoSize = true;
			this.lblPesquisarPlaca.Location = new System.Drawing.Point(6, 49);
			this.lblPesquisarPlaca.Name = "lblPesquisarPlaca";
			this.lblPesquisarPlaca.Size = new System.Drawing.Size(164, 30);
			this.lblPesquisarPlaca.TabIndex = 0;
			this.lblPesquisarPlaca.Text = "Pesquisar Placa:";
			// 
			// gboPatioMovimentacoes
			// 
			this.gboPatioMovimentacoes.Controls.Add(this.dgvVeiculos);
			this.gboPatioMovimentacoes.Location = new System.Drawing.Point(16, 387);
			this.gboPatioMovimentacoes.Name = "gboPatioMovimentacoes";
			this.gboPatioMovimentacoes.Size = new System.Drawing.Size(1158, 179);
			this.gboPatioMovimentacoes.TabIndex = 3;
			this.gboPatioMovimentacoes.TabStop = false;
			this.gboPatioMovimentacoes.Text = "Pátio e Movimentações";
			// 
			// dgvVeiculos
			// 
			this.dgvVeiculos.AllowUserToAddRows = false;
			this.dgvVeiculos.AllowUserToDeleteRows = false;
			this.dgvVeiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Column1,
			this.Column2,
			this.Column3,
			this.Column4,
			this.Column5,
			this.Column6});
			this.dgvVeiculos.Location = new System.Drawing.Point(7, 35);
			this.dgvVeiculos.MultiSelect = false;
			this.dgvVeiculos.Name = "dgvVeiculos";
			this.dgvVeiculos.ReadOnly = true;
			this.dgvVeiculos.RowTemplate.Height = 24;
			this.dgvVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvVeiculos.Size = new System.Drawing.Size(1145, 126);
			this.dgvVeiculos.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Placa";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Modelo";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Tipo";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Entrada";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Saída";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Valor Cobrado";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// gboIndicadores
			// 
			this.gboIndicadores.Controls.Add(this.lblFinalizados);
			this.gboIndicadores.Controls.Add(this.lblTotalRecebido);
			this.gboIndicadores.Controls.Add(this.lblEstacionados);
			this.gboIndicadores.Location = new System.Drawing.Point(16, 573);
			this.gboIndicadores.Name = "gboIndicadores";
			this.gboIndicadores.Size = new System.Drawing.Size(1157, 99);
			this.gboIndicadores.TabIndex = 4;
			this.gboIndicadores.TabStop = false;
			this.gboIndicadores.Text = "Indicadores do Dia";
			// 
			// lblFinalizados
			// 
			this.lblFinalizados.AutoSize = true;
			this.lblFinalizados.Location = new System.Drawing.Point(554, 32);
			this.lblFinalizados.Name = "lblFinalizados";
			this.lblFinalizados.Size = new System.Drawing.Size(119, 30);
			this.lblFinalizados.TabIndex = 2;
			this.lblFinalizados.Text = "Finalizados:";
			// 
			// lblTotalRecebido
			// 
			this.lblTotalRecebido.AutoSize = true;
			this.lblTotalRecebido.Location = new System.Drawing.Point(554, 62);
			this.lblTotalRecebido.Name = "lblTotalRecebido";
			this.lblTotalRecebido.Size = new System.Drawing.Size(153, 30);
			this.lblTotalRecebido.TabIndex = 1;
			this.lblTotalRecebido.Text = "Total Recebido:";
			// 
			// lblEstacionados
			// 
			this.lblEstacionados.AutoSize = true;
			this.lblEstacionados.Location = new System.Drawing.Point(7, 52);
			this.lblEstacionados.Name = "lblEstacionados";
			this.lblEstacionados.Size = new System.Drawing.Size(139, 30);
			this.lblEstacionados.TabIndex = 0;
			this.lblEstacionados.Text = "Estacionados:";
			// 
			// btnRegistrarEntrada
			// 
			this.btnRegistrarEntrada.AutoSize = true;
			this.btnRegistrarEntrada.Location = new System.Drawing.Point(38, 681);
			this.btnRegistrarEntrada.Name = "btnRegistrarEntrada";
			this.btnRegistrarEntrada.Size = new System.Drawing.Size(182, 44);
			this.btnRegistrarEntrada.TabIndex = 5;
			this.btnRegistrarEntrada.Text = "Registrar Entrada";
			this.btnRegistrarEntrada.UseVisualStyleBackColor = true;
			this.btnRegistrarEntrada.Click += new System.EventHandler(this.BtnRegistrarEntradaClick);
			// 
			// btnRegistrarSaida
			// 
			this.btnRegistrarSaida.AutoSize = true;
			this.btnRegistrarSaida.Location = new System.Drawing.Point(337, 681);
			this.btnRegistrarSaida.Name = "btnRegistrarSaida";
			this.btnRegistrarSaida.Size = new System.Drawing.Size(163, 44);
			this.btnRegistrarSaida.TabIndex = 6;
			this.btnRegistrarSaida.Text = "Registrar Saída";
			this.btnRegistrarSaida.UseVisualStyleBackColor = true;
			this.btnRegistrarSaida.Click += new System.EventHandler(this.BtnRegistrarSaidaClick);
			// 
			// btnRemover
			// 
			this.btnRemover.AutoSize = true;
			this.btnRemover.Location = new System.Drawing.Point(618, 681);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(124, 44);
			this.btnRemover.TabIndex = 7;
			this.btnRemover.Text = "Remover";
			this.btnRemover.UseVisualStyleBackColor = true;
			this.btnRemover.Click += new System.EventHandler(this.BtnRemoverClick);
			// 
			// btnLimpar
			// 
			this.btnLimpar.AutoSize = true;
			this.btnLimpar.Location = new System.Drawing.Point(855, 681);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(124, 44);
			this.btnLimpar.TabIndex = 8;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.BtnLimparClick);
			// 
			// btnSair
			// 
			this.btnSair.AutoSize = true;
			this.btnSair.Location = new System.Drawing.Point(1051, 681);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(124, 44);
			this.btnSair.TabIndex = 9;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1193, 737);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnRemover);
			this.Controls.Add(this.btnRegistrarSaida);
			this.Controls.Add(this.btnRegistrarEntrada);
			this.Controls.Add(this.gboIndicadores);
			this.Controls.Add(this.gboPatioMovimentacoes);
			this.Controls.Add(this.gboFiltrosBuscas);
			this.Controls.Add(this.gboHorarios);
			this.Controls.Add(this.gboRegistroVeiculos);
			this.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ATIVIDADE 04 Controle de Estacionamento";
			this.gboRegistroVeiculos.ResumeLayout(false);
			this.gboRegistroVeiculos.PerformLayout();
			this.gboHorarios.ResumeLayout(false);
			this.gboHorarios.PerformLayout();
			this.gboFiltrosBuscas.ResumeLayout(false);
			this.gboFiltrosBuscas.PerformLayout();
			this.gboPatioMovimentacoes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
			this.gboIndicadores.ResumeLayout(false);
			this.gboIndicadores.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
