/*
 * Created by SharpDevelop.
 * User: Alex Junio
 * Date: 15/07/2026
 * Time: 16:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade_05_Cadastro_de_clientes
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblCadastroGestao;
		private System.Windows.Forms.GroupBox gboFiltrosBusca;
		private System.Windows.Forms.Button btnMostrarTodos;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.TextBox txtPesquisar;
		private System.Windows.Forms.Label lblPesquisar;
		private System.Windows.Forms.GroupBox gboFicha;
		private System.Windows.Forms.TextBox txtCPF;
		private System.Windows.Forms.TextBox txtTelefone;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.CheckBox chkAtivo;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblTelefone;
		private System.Windows.Forms.Label lblCPF;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.GroupBox gboClientesCadastrados;
		private System.Windows.Forms.DataGridView dgvClientes;
		private System.Windows.Forms.DataGridViewTextBoxColumn colId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colAtivo;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnAtivarDesativar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label lblId;
		
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
			this.lblCadastroGestao = new System.Windows.Forms.Label();
			this.gboFiltrosBusca = new System.Windows.Forms.GroupBox();
			this.btnMostrarTodos = new System.Windows.Forms.Button();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.txtPesquisar = new System.Windows.Forms.TextBox();
			this.lblPesquisar = new System.Windows.Forms.Label();
			this.gboFicha = new System.Windows.Forms.GroupBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.lblId = new System.Windows.Forms.Label();
			this.txtCPF = new System.Windows.Forms.TextBox();
			this.txtTelefone = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.chkAtivo = new System.Windows.Forms.CheckBox();
			this.lblCidade = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblTelefone = new System.Windows.Forms.Label();
			this.lblCPF = new System.Windows.Forms.Label();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.gboClientesCadastrados = new System.Windows.Forms.GroupBox();
			this.dgvClientes = new System.Windows.Forms.DataGridView();
			this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnAtivarDesativar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.gboFiltrosBusca.SuspendLayout();
			this.gboFicha.SuspendLayout();
			this.gboClientesCadastrados.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCadastroGestao
			// 
			this.lblCadastroGestao.AutoSize = true;
			this.lblCadastroGestao.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCadastroGestao.Location = new System.Drawing.Point(361, 9);
			this.lblCadastroGestao.Name = "lblCadastroGestao";
			this.lblCadastroGestao.Size = new System.Drawing.Size(392, 40);
			this.lblCadastroGestao.TabIndex = 0;
			this.lblCadastroGestao.Text = "Cadastro e Gestão de Clientes";
			// 
			// gboFiltrosBusca
			// 
			this.gboFiltrosBusca.Controls.Add(this.btnMostrarTodos);
			this.gboFiltrosBusca.Controls.Add(this.btnPesquisar);
			this.gboFiltrosBusca.Controls.Add(this.txtPesquisar);
			this.gboFiltrosBusca.Controls.Add(this.lblPesquisar);
			this.gboFiltrosBusca.Location = new System.Drawing.Point(18, 76);
			this.gboFiltrosBusca.Name = "gboFiltrosBusca";
			this.gboFiltrosBusca.Size = new System.Drawing.Size(1129, 132);
			this.gboFiltrosBusca.TabIndex = 1;
			this.gboFiltrosBusca.TabStop = false;
			this.gboFiltrosBusca.Text = "Filtros e Busca";
			// 
			// btnMostrarTodos
			// 
			this.btnMostrarTodos.AutoSize = true;
			this.btnMostrarTodos.Location = new System.Drawing.Point(840, 75);
			this.btnMostrarTodos.Name = "btnMostrarTodos";
			this.btnMostrarTodos.Size = new System.Drawing.Size(185, 39);
			this.btnMostrarTodos.TabIndex = 3;
			this.btnMostrarTodos.Text = "Mostrar Todos";
			this.btnMostrarTodos.UseVisualStyleBackColor = true;
			this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.AutoSize = true;
			this.btnPesquisar.Location = new System.Drawing.Point(613, 75);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(136, 39);
			this.btnPesquisar.TabIndex = 2;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// txtPesquisar
			// 
			this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPesquisar.Location = new System.Drawing.Point(145, 89);
			this.txtPesquisar.Name = "txtPesquisar";
			this.txtPesquisar.Size = new System.Drawing.Size(365, 27);
			this.txtPesquisar.TabIndex = 1;
			// 
			// lblPesquisar
			// 
			this.lblPesquisar.AutoSize = true;
			this.lblPesquisar.Location = new System.Drawing.Point(6, 85);
			this.lblPesquisar.Name = "lblPesquisar";
			this.lblPesquisar.Size = new System.Drawing.Size(133, 29);
			this.lblPesquisar.TabIndex = 0;
			this.lblPesquisar.Text = "Pesquisar:";
			// 
			// gboFicha
			// 
			this.gboFicha.Controls.Add(this.txtId);
			this.gboFicha.Controls.Add(this.lblId);
			this.gboFicha.Controls.Add(this.txtCPF);
			this.gboFicha.Controls.Add(this.txtTelefone);
			this.gboFicha.Controls.Add(this.txtNome);
			this.gboFicha.Controls.Add(this.txtCidade);
			this.gboFicha.Controls.Add(this.txtEmail);
			this.gboFicha.Controls.Add(this.txtCodigo);
			this.gboFicha.Controls.Add(this.chkAtivo);
			this.gboFicha.Controls.Add(this.lblCidade);
			this.gboFicha.Controls.Add(this.lblEmail);
			this.gboFicha.Controls.Add(this.lblNome);
			this.gboFicha.Controls.Add(this.lblTelefone);
			this.gboFicha.Controls.Add(this.lblCPF);
			this.gboFicha.Controls.Add(this.lblCodigo);
			this.gboFicha.Location = new System.Drawing.Point(22, 224);
			this.gboFicha.Name = "gboFicha";
			this.gboFicha.Size = new System.Drawing.Size(1124, 242);
			this.gboFicha.TabIndex = 2;
			this.gboFicha.TabStop = false;
			this.gboFicha.Text = "Ficha Cadastral do Cliente";
			// 
			// txtId
			// 
			this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtId.Location = new System.Drawing.Point(695, 133);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(172, 24);
			this.txtId.TabIndex = 14;
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(645, 128);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(44, 29);
			this.lblId.TabIndex = 13;
			this.lblId.Text = "ID:";
			// 
			// txtCPF
			// 
			this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCPF.Location = new System.Drawing.Point(82, 128);
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(222, 24);
			this.txtCPF.TabIndex = 12;
			// 
			// txtTelefone
			// 
			this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefone.Location = new System.Drawing.Point(67, 202);
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(237, 24);
			this.txtTelefone.TabIndex = 11;
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(404, 60);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(215, 24);
			this.txtNome.TabIndex = 10;
			// 
			// txtCidade
			// 
			this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCidade.Location = new System.Drawing.Point(416, 201);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(203, 24);
			this.txtCidade.TabIndex = 9;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(401, 128);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(218, 24);
			this.txtEmail.TabIndex = 8;
			// 
			// txtCodigo
			// 
			this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(112, 60);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(192, 24);
			this.txtCodigo.TabIndex = 7;
			// 
			// chkAtivo
			// 
			this.chkAtivo.AutoSize = true;
			this.chkAtivo.Location = new System.Drawing.Point(1026, 119);
			this.chkAtivo.Name = "chkAtivo";
			this.chkAtivo.Size = new System.Drawing.Size(92, 33);
			this.chkAtivo.TabIndex = 6;
			this.chkAtivo.Text = "Ativo";
			this.chkAtivo.UseVisualStyleBackColor = true;
			// 
			// lblCidade
			// 
			this.lblCidade.AutoSize = true;
			this.lblCidade.Location = new System.Drawing.Point(310, 196);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(100, 29);
			this.lblCidade.TabIndex = 5;
			this.lblCidade.Text = "Cidade:";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(310, 123);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(85, 29);
			this.lblEmail.TabIndex = 4;
			this.lblEmail.Text = "Email:";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(310, 55);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(88, 29);
			this.lblNome.TabIndex = 3;
			this.lblNome.Text = "Nome:";
			// 
			// lblTelefone
			// 
			this.lblTelefone.AutoSize = true;
			this.lblTelefone.Location = new System.Drawing.Point(6, 196);
			this.lblTelefone.Name = "lblTelefone";
			this.lblTelefone.Size = new System.Drawing.Size(55, 29);
			this.lblTelefone.TabIndex = 2;
			this.lblTelefone.Text = "Tel:";
			// 
			// lblCPF
			// 
			this.lblCPF.AutoSize = true;
			this.lblCPF.Location = new System.Drawing.Point(6, 123);
			this.lblCPF.Name = "lblCPF";
			this.lblCPF.Size = new System.Drawing.Size(70, 29);
			this.lblCPF.TabIndex = 1;
			this.lblCPF.Text = "CPF:";
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Location = new System.Drawing.Point(6, 55);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(100, 29);
			this.lblCodigo.TabIndex = 0;
			this.lblCodigo.Text = "Código:";
			// 
			// gboClientesCadastrados
			// 
			this.gboClientesCadastrados.Controls.Add(this.dgvClientes);
			this.gboClientesCadastrados.Location = new System.Drawing.Point(27, 481);
			this.gboClientesCadastrados.Name = "gboClientesCadastrados";
			this.gboClientesCadastrados.Size = new System.Drawing.Size(1120, 180);
			this.gboClientesCadastrados.TabIndex = 3;
			this.gboClientesCadastrados.TabStop = false;
			this.gboClientesCadastrados.Text = "Clientes Cadastrados";
			// 
			// dgvClientes
			// 
			this.dgvClientes.AllowUserToAddRows = false;
			this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colId,
			this.colNome,
			this.colCPF,
			this.colEmail,
			this.colAtivo});
			this.dgvClientes.Location = new System.Drawing.Point(6, 45);
			this.dgvClientes.Name = "dgvClientes";
			this.dgvClientes.RowHeadersVisible = false;
			this.dgvClientes.RowTemplate.Height = 24;
			this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvClientes.Size = new System.Drawing.Size(1090, 109);
			this.dgvClientes.TabIndex = 0;
			// 
			// colId
			// 
			this.colId.DataPropertyName = "ID";
			this.colId.FillWeight = 62.56989F;
			this.colId.HeaderText = "ID";
			this.colId.Name = "colId";
			this.colId.ReadOnly = true;
			// 
			// colNome
			// 
			this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colNome.DataPropertyName = "Nome";
			this.colNome.FillWeight = 218.2461F;
			this.colNome.HeaderText = "Nome Completo";
			this.colNome.Name = "colNome";
			this.colNome.ReadOnly = true;
			// 
			// colCPF
			// 
			this.colCPF.DataPropertyName = "CPF";
			this.colCPF.FillWeight = 97.50835F;
			this.colCPF.HeaderText = "CPF";
			this.colCPF.Name = "colCPF";
			this.colCPF.ReadOnly = true;
			// 
			// colEmail
			// 
			this.colEmail.DataPropertyName = "Email";
			this.colEmail.FillWeight = 96.29494F;
			this.colEmail.HeaderText = "Email";
			this.colEmail.Name = "colEmail";
			this.colEmail.ReadOnly = true;
			// 
			// colAtivo
			// 
			this.colAtivo.DataPropertyName = "Ativo";
			this.colAtivo.FillWeight = 25.38071F;
			this.colAtivo.HeaderText = "Ativo";
			this.colAtivo.Name = "colAtivo";
			this.colAtivo.ReadOnly = true;
			this.colAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colAtivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// btnNovo
			// 
			this.btnNovo.AutoSize = true;
			this.btnNovo.Location = new System.Drawing.Point(24, 667);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(107, 39);
			this.btnNovo.TabIndex = 4;
			this.btnNovo.Text = "Novo";
			this.btnNovo.UseVisualStyleBackColor = true;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.AutoSize = true;
			this.btnSalvar.Location = new System.Drawing.Point(241, 667);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(107, 39);
			this.btnSalvar.TabIndex = 5;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.AutoSize = true;
			this.btnEditar.Location = new System.Drawing.Point(447, 670);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(107, 39);
			this.btnEditar.TabIndex = 6;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.AutoSize = true;
			this.btnExcluir.Location = new System.Drawing.Point(631, 670);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(107, 39);
			this.btnExcluir.TabIndex = 7;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnAtivarDesativar
			// 
			this.btnAtivarDesativar.AutoSize = true;
			this.btnAtivarDesativar.Location = new System.Drawing.Point(800, 670);
			this.btnAtivarDesativar.Name = "btnAtivarDesativar";
			this.btnAtivarDesativar.Size = new System.Drawing.Size(202, 39);
			this.btnAtivarDesativar.TabIndex = 8;
			this.btnAtivarDesativar.Text = "Ativar/Desativar";
			this.btnAtivarDesativar.UseVisualStyleBackColor = true;
			this.btnAtivarDesativar.Click += new System.EventHandler(this.btnAtivarDesativar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.AutoSize = true;
			this.btnCancelar.Location = new System.Drawing.Point(1023, 670);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(124, 39);
			this.btnCancelar.TabIndex = 9;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1255, 721);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAtivarDesativar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.gboClientesCadastrados);
			this.Controls.Add(this.gboFicha);
			this.Controls.Add(this.gboFiltrosBusca);
			this.Controls.Add(this.lblCadastroGestao);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Atividade 05 Cadastro de clientes";
			this.gboFiltrosBusca.ResumeLayout(false);
			this.gboFiltrosBusca.PerformLayout();
			this.gboFicha.ResumeLayout(false);
			this.gboFicha.PerformLayout();
			this.gboClientesCadastrados.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
