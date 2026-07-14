/*
 * Created by SharpDevelop.
 * User: Alex Junio
 * Date: 14/07/2026
 * Time: 17:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade02_Sistema_Vendas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblSistemaVendas;
		private System.Windows.Forms.GroupBox gboDadosVendas;
		private System.Windows.Forms.TextBox txtCliente;
		private System.Windows.Forms.Label lblValorUnitario;
		private System.Windows.Forms.Label lblProduto;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.TextBox txtValorUnitario;
		private System.Windows.Forms.TextBox txtProduto;
		private System.Windows.Forms.NumericUpDown nudQuantidade;
		private System.Windows.Forms.Label lblQuantidade;
		private System.Windows.Forms.GroupBox gboFormaPagamento;
		private System.Windows.Forms.RadioButton rdbDebito;
		private System.Windows.Forms.RadioButton rdbPix;
		private System.Windows.Forms.Label lblCrédito;
		private System.Windows.Forms.Label lblDébito;
		private System.Windows.Forms.Label lblPix;
		private System.Windows.Forms.RadioButton rdbDinheiro;
		private System.Windows.Forms.Label lblDinheiro;
		private System.Windows.Forms.GroupBox gboServicos;
		private System.Windows.Forms.CheckBox chkGarantia;
		private System.Windows.Forms.CheckBox chkEntrega;
		private System.Windows.Forms.Label lblGarantiaEstendida;
		private System.Windows.Forms.Label lblEntrega;
		private System.Windows.Forms.GroupBox gboResumoTotais;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnNovaVenda;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtResumo;
		private System.Windows.Forms.Label lblResumoVenda;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblAcrescimos;
		private System.Windows.Forms.Label lblDesconto;
		private System.Windows.Forms.Label lblSubtotal;
		private System.Windows.Forms.RadioButton rdbCredito;
		
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
			this.lblSistemaVendas = new System.Windows.Forms.Label();
			this.gboDadosVendas = new System.Windows.Forms.GroupBox();
			this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
			this.lblQuantidade = new System.Windows.Forms.Label();
			this.txtValorUnitario = new System.Windows.Forms.TextBox();
			this.txtProduto = new System.Windows.Forms.TextBox();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.lblValorUnitario = new System.Windows.Forms.Label();
			this.lblProduto = new System.Windows.Forms.Label();
			this.lblCliente = new System.Windows.Forms.Label();
			this.gboFormaPagamento = new System.Windows.Forms.GroupBox();
			this.rdbCredito = new System.Windows.Forms.RadioButton();
			this.rdbDebito = new System.Windows.Forms.RadioButton();
			this.rdbPix = new System.Windows.Forms.RadioButton();
			this.lblCrédito = new System.Windows.Forms.Label();
			this.lblDébito = new System.Windows.Forms.Label();
			this.lblPix = new System.Windows.Forms.Label();
			this.rdbDinheiro = new System.Windows.Forms.RadioButton();
			this.lblDinheiro = new System.Windows.Forms.Label();
			this.gboServicos = new System.Windows.Forms.GroupBox();
			this.chkGarantia = new System.Windows.Forms.CheckBox();
			this.chkEntrega = new System.Windows.Forms.CheckBox();
			this.lblGarantiaEstendida = new System.Windows.Forms.Label();
			this.lblEntrega = new System.Windows.Forms.Label();
			this.gboResumoTotais = new System.Windows.Forms.GroupBox();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnNovaVenda = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.txtResumo = new System.Windows.Forms.TextBox();
			this.lblResumoVenda = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblAcrescimos = new System.Windows.Forms.Label();
			this.lblDesconto = new System.Windows.Forms.Label();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.gboDadosVendas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
			this.gboFormaPagamento.SuspendLayout();
			this.gboServicos.SuspendLayout();
			this.gboResumoTotais.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblSistemaVendas
			// 
			this.lblSistemaVendas.AutoSize = true;
			this.lblSistemaVendas.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSistemaVendas.Location = new System.Drawing.Point(364, 9);
			this.lblSistemaVendas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblSistemaVendas.Name = "lblSistemaVendas";
			this.lblSistemaVendas.Size = new System.Drawing.Size(411, 40);
			this.lblSistemaVendas.TabIndex = 0;
			this.lblSistemaVendas.Text = "SISTEMAS DE VENDAS E PDV";
			// 
			// gboDadosVendas
			// 
			this.gboDadosVendas.Controls.Add(this.nudQuantidade);
			this.gboDadosVendas.Controls.Add(this.lblQuantidade);
			this.gboDadosVendas.Controls.Add(this.txtValorUnitario);
			this.gboDadosVendas.Controls.Add(this.txtProduto);
			this.gboDadosVendas.Controls.Add(this.txtCliente);
			this.gboDadosVendas.Controls.Add(this.lblValorUnitario);
			this.gboDadosVendas.Controls.Add(this.lblProduto);
			this.gboDadosVendas.Controls.Add(this.lblCliente);
			this.gboDadosVendas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gboDadosVendas.Location = new System.Drawing.Point(14, 63);
			this.gboDadosVendas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.gboDadosVendas.Name = "gboDadosVendas";
			this.gboDadosVendas.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.gboDadosVendas.Size = new System.Drawing.Size(1074, 209);
			this.gboDadosVendas.TabIndex = 1;
			this.gboDadosVendas.TabStop = false;
			this.gboDadosVendas.Text = "Dados da Venda";
			// 
			// nudQuantidade
			// 
			this.nudQuantidade.Location = new System.Drawing.Point(728, 152);
			this.nudQuantidade.Name = "nudQuantidade";
			this.nudQuantidade.Size = new System.Drawing.Size(337, 30);
			this.nudQuantidade.TabIndex = 7;
			// 
			// lblQuantidade
			// 
			this.lblQuantidade.AutoSize = true;
			this.lblQuantidade.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuantidade.Location = new System.Drawing.Point(600, 152);
			this.lblQuantidade.Name = "lblQuantidade";
			this.lblQuantidade.Size = new System.Drawing.Size(122, 30);
			this.lblQuantidade.TabIndex = 6;
			this.lblQuantidade.Text = "Quantidade:";
			// 
			// txtValorUnitario
			// 
			this.txtValorUnitario.Location = new System.Drawing.Point(188, 152);
			this.txtValorUnitario.Name = "txtValorUnitario";
			this.txtValorUnitario.Size = new System.Drawing.Size(357, 30);
			this.txtValorUnitario.TabIndex = 5;
			// 
			// txtProduto
			// 
			this.txtProduto.Location = new System.Drawing.Point(108, 100);
			this.txtProduto.Name = "txtProduto";
			this.txtProduto.Size = new System.Drawing.Size(958, 30);
			this.txtProduto.TabIndex = 4;
			// 
			// txtCliente
			// 
			this.txtCliente.Location = new System.Drawing.Point(99, 48);
			this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.Size = new System.Drawing.Size(966, 30);
			this.txtCliente.TabIndex = 3;
			// 
			// lblValorUnitario
			// 
			this.lblValorUnitario.AutoSize = true;
			this.lblValorUnitario.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorUnitario.Location = new System.Drawing.Point(10, 152);
			this.lblValorUnitario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblValorUnitario.Name = "lblValorUnitario";
			this.lblValorUnitario.Size = new System.Drawing.Size(170, 30);
			this.lblValorUnitario.TabIndex = 2;
			this.lblValorUnitario.Text = "VL. Unitário (R$):";
			// 
			// lblProduto
			// 
			this.lblProduto.AutoSize = true;
			this.lblProduto.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProduto.Location = new System.Drawing.Point(10, 100);
			this.lblProduto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblProduto.Name = "lblProduto";
			this.lblProduto.Size = new System.Drawing.Size(90, 30);
			this.lblProduto.TabIndex = 1;
			this.lblProduto.Text = "Produto:";
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCliente.Location = new System.Drawing.Point(10, 48);
			this.lblCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(81, 30);
			this.lblCliente.TabIndex = 0;
			this.lblCliente.Text = "Cliente:";
			// 
			// gboFormaPagamento
			// 
			this.gboFormaPagamento.Controls.Add(this.rdbCredito);
			this.gboFormaPagamento.Controls.Add(this.rdbDebito);
			this.gboFormaPagamento.Controls.Add(this.rdbPix);
			this.gboFormaPagamento.Controls.Add(this.lblCrédito);
			this.gboFormaPagamento.Controls.Add(this.lblDébito);
			this.gboFormaPagamento.Controls.Add(this.lblPix);
			this.gboFormaPagamento.Controls.Add(this.rdbDinheiro);
			this.gboFormaPagamento.Controls.Add(this.lblDinheiro);
			this.gboFormaPagamento.Location = new System.Drawing.Point(14, 279);
			this.gboFormaPagamento.Name = "gboFormaPagamento";
			this.gboFormaPagamento.Size = new System.Drawing.Size(522, 301);
			this.gboFormaPagamento.TabIndex = 2;
			this.gboFormaPagamento.TabStop = false;
			this.gboFormaPagamento.Text = "Forma de Pagamento";
			// 
			// rdbCredito
			// 
			this.rdbCredito.AutoSize = true;
			this.rdbCredito.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbCredito.Location = new System.Drawing.Point(163, 246);
			this.rdbCredito.Name = "rdbCredito";
			this.rdbCredito.Size = new System.Drawing.Size(76, 26);
			this.rdbCredito.TabIndex = 7;
			this.rdbCredito.TabStop = true;
			this.rdbCredito.Text = "Crédito";
			this.rdbCredito.UseVisualStyleBackColor = true;
			// 
			// rdbDebito
			// 
			this.rdbDebito.AutoSize = true;
			this.rdbDebito.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbDebito.Location = new System.Drawing.Point(156, 182);
			this.rdbDebito.Name = "rdbDebito";
			this.rdbDebito.Size = new System.Drawing.Size(71, 26);
			this.rdbDebito.TabIndex = 6;
			this.rdbDebito.TabStop = true;
			this.rdbDebito.Text = "Débito";
			this.rdbDebito.UseVisualStyleBackColor = true;
			// 
			// rdbPix
			// 
			this.rdbPix.AutoSize = true;
			this.rdbPix.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbPix.Location = new System.Drawing.Point(59, 115);
			this.rdbPix.Name = "rdbPix";
			this.rdbPix.Size = new System.Drawing.Size(50, 26);
			this.rdbPix.TabIndex = 5;
			this.rdbPix.TabStop = true;
			this.rdbPix.Text = "Pix";
			this.rdbPix.UseVisualStyleBackColor = true;
			// 
			// lblCrédito
			// 
			this.lblCrédito.AutoSize = true;
			this.lblCrédito.Location = new System.Drawing.Point(6, 242);
			this.lblCrédito.Name = "lblCrédito";
			this.lblCrédito.Size = new System.Drawing.Size(151, 30);
			this.lblCrédito.TabIndex = 4;
			this.lblCrédito.Text = "Cartão Crédito:";
			// 
			// lblDébito
			// 
			this.lblDébito.AutoSize = true;
			this.lblDébito.Location = new System.Drawing.Point(6, 178);
			this.lblDébito.Name = "lblDébito";
			this.lblDébito.Size = new System.Drawing.Size(144, 30);
			this.lblDébito.TabIndex = 3;
			this.lblDébito.Text = "Cartão Débito:";
			// 
			// lblPix
			// 
			this.lblPix.AutoSize = true;
			this.lblPix.Location = new System.Drawing.Point(6, 111);
			this.lblPix.Name = "lblPix";
			this.lblPix.Size = new System.Drawing.Size(47, 30);
			this.lblPix.TabIndex = 2;
			this.lblPix.Text = "Pix:";
			// 
			// rdbDinheiro
			// 
			this.rdbDinheiro.AutoSize = true;
			this.rdbDinheiro.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbDinheiro.Location = new System.Drawing.Point(105, 55);
			this.rdbDinheiro.Name = "rdbDinheiro";
			this.rdbDinheiro.Size = new System.Drawing.Size(84, 26);
			this.rdbDinheiro.TabIndex = 1;
			this.rdbDinheiro.TabStop = true;
			this.rdbDinheiro.Text = "Dinheiro";
			this.rdbDinheiro.UseVisualStyleBackColor = true;
			// 
			// lblDinheiro
			// 
			this.lblDinheiro.AutoSize = true;
			this.lblDinheiro.Location = new System.Drawing.Point(6, 51);
			this.lblDinheiro.Name = "lblDinheiro";
			this.lblDinheiro.Size = new System.Drawing.Size(93, 30);
			this.lblDinheiro.TabIndex = 0;
			this.lblDinheiro.Text = "Dinheiro:";
			// 
			// gboServicos
			// 
			this.gboServicos.Controls.Add(this.chkGarantia);
			this.gboServicos.Controls.Add(this.chkEntrega);
			this.gboServicos.Controls.Add(this.lblGarantiaEstendida);
			this.gboServicos.Controls.Add(this.lblEntrega);
			this.gboServicos.Location = new System.Drawing.Point(564, 281);
			this.gboServicos.Name = "gboServicos";
			this.gboServicos.Size = new System.Drawing.Size(524, 299);
			this.gboServicos.TabIndex = 3;
			this.gboServicos.TabStop = false;
			this.gboServicos.Text = "Serviços Adicionais";
			// 
			// chkGarantia
			// 
			this.chkGarantia.AutoSize = true;
			this.chkGarantia.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkGarantia.Location = new System.Drawing.Point(203, 199);
			this.chkGarantia.Name = "chkGarantia";
			this.chkGarantia.Size = new System.Drawing.Size(86, 26);
			this.chkGarantia.TabIndex = 3;
			this.chkGarantia.Text = "Garantia";
			this.chkGarantia.UseVisualStyleBackColor = true;
			// 
			// chkEntrega
			// 
			this.chkEntrega.AutoSize = true;
			this.chkEntrega.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkEntrega.Location = new System.Drawing.Point(102, 101);
			this.chkEntrega.Name = "chkEntrega";
			this.chkEntrega.Size = new System.Drawing.Size(81, 26);
			this.chkEntrega.TabIndex = 2;
			this.chkEntrega.Text = "Entrega";
			this.chkEntrega.UseVisualStyleBackColor = true;
			// 
			// lblGarantiaEstendida
			// 
			this.lblGarantiaEstendida.AutoSize = true;
			this.lblGarantiaEstendida.Location = new System.Drawing.Point(6, 195);
			this.lblGarantiaEstendida.Name = "lblGarantiaEstendida";
			this.lblGarantiaEstendida.Size = new System.Drawing.Size(191, 30);
			this.lblGarantiaEstendida.TabIndex = 1;
			this.lblGarantiaEstendida.Text = "Garantia Estendida:";
			// 
			// lblEntrega
			// 
			this.lblEntrega.AutoSize = true;
			this.lblEntrega.Location = new System.Drawing.Point(6, 97);
			this.lblEntrega.Name = "lblEntrega";
			this.lblEntrega.Size = new System.Drawing.Size(90, 30);
			this.lblEntrega.TabIndex = 0;
			this.lblEntrega.Text = "Entrega:";
			// 
			// gboResumoTotais
			// 
			this.gboResumoTotais.Controls.Add(this.btnSair);
			this.gboResumoTotais.Controls.Add(this.btnNovaVenda);
			this.gboResumoTotais.Controls.Add(this.btnCalcular);
			this.gboResumoTotais.Controls.Add(this.txtResumo);
			this.gboResumoTotais.Controls.Add(this.lblResumoVenda);
			this.gboResumoTotais.Controls.Add(this.lblTotal);
			this.gboResumoTotais.Controls.Add(this.lblAcrescimos);
			this.gboResumoTotais.Controls.Add(this.lblDesconto);
			this.gboResumoTotais.Controls.Add(this.lblSubtotal);
			this.gboResumoTotais.Location = new System.Drawing.Point(21, 587);
			this.gboResumoTotais.Name = "gboResumoTotais";
			this.gboResumoTotais.Size = new System.Drawing.Size(1067, 273);
			this.gboResumoTotais.TabIndex = 4;
			this.gboResumoTotais.TabStop = false;
			this.gboResumoTotais.Text = "Resumo e Totais";
			// 
			// btnSair
			// 
			this.btnSair.AutoSize = true;
			this.btnSair.Location = new System.Drawing.Point(839, 199);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(204, 40);
			this.btnSair.TabIndex = 8;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// btnNovaVenda
			// 
			this.btnNovaVenda.AutoSize = true;
			this.btnNovaVenda.Location = new System.Drawing.Point(838, 141);
			this.btnNovaVenda.Name = "btnNovaVenda";
			this.btnNovaVenda.Size = new System.Drawing.Size(205, 40);
			this.btnNovaVenda.TabIndex = 7;
			this.btnNovaVenda.Text = "Nova Venda";
			this.btnNovaVenda.UseVisualStyleBackColor = true;
			this.btnNovaVenda.Click += new System.EventHandler(this.BtnNovaVendaClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.AutoSize = true;
			this.btnCalcular.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(838, 74);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(204, 40);
			this.btnCalcular.TabIndex = 6;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// txtResumo
			// 
			this.txtResumo.Location = new System.Drawing.Point(428, 65);
			this.txtResumo.Multiline = true;
			this.txtResumo.Name = "txtResumo";
			this.txtResumo.Size = new System.Drawing.Size(404, 174);
			this.txtResumo.TabIndex = 5;
			// 
			// lblResumoVenda
			// 
			this.lblResumoVenda.AutoSize = true;
			this.lblResumoVenda.Location = new System.Drawing.Point(531, 32);
			this.lblResumoVenda.Name = "lblResumoVenda";
			this.lblResumoVenda.Size = new System.Drawing.Size(184, 30);
			this.lblResumoVenda.TabIndex = 4;
			this.lblResumoVenda.Text = "Resumo de Venda:";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(218, 98);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(125, 30);
			this.lblTotal.TabIndex = 3;
			this.lblTotal.Text = "Total:      R$";
			// 
			// lblAcrescimos
			// 
			this.lblAcrescimos.AutoSize = true;
			this.lblAcrescimos.Location = new System.Drawing.Point(6, 146);
			this.lblAcrescimos.Name = "lblAcrescimos";
			this.lblAcrescimos.Size = new System.Drawing.Size(171, 30);
			this.lblAcrescimos.TabIndex = 2;
			this.lblAcrescimos.Text = "Acrescimos:    R$";
			// 
			// lblDesconto
			// 
			this.lblDesconto.AutoSize = true;
			this.lblDesconto.Location = new System.Drawing.Point(6, 98);
			this.lblDesconto.Name = "lblDesconto";
			this.lblDesconto.Size = new System.Drawing.Size(148, 30);
			this.lblDesconto.TabIndex = 1;
			this.lblDesconto.Text = "Desconto:   R$";
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.Location = new System.Drawing.Point(6, 44);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(136, 30);
			this.lblSubtotal.TabIndex = 0;
			this.lblSubtotal.Text = "Subtotal:   R$";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1112, 876);
			this.Controls.Add(this.gboResumoTotais);
			this.Controls.Add(this.gboServicos);
			this.Controls.Add(this.gboFormaPagamento);
			this.Controls.Add(this.gboDadosVendas);
			this.Controls.Add(this.lblSistemaVendas);
			this.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Atividade02 Sistema Vendas";
			this.gboDadosVendas.ResumeLayout(false);
			this.gboDadosVendas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
			this.gboFormaPagamento.ResumeLayout(false);
			this.gboFormaPagamento.PerformLayout();
			this.gboServicos.ResumeLayout(false);
			this.gboServicos.PerformLayout();
			this.gboResumoTotais.ResumeLayout(false);
			this.gboResumoTotais.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
