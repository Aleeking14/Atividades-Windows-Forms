/*
 * Created by SharpDevelop.
 * User: Alex Junio
 * Date: 13/07/2026
 * Time: 18:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade01
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox gboFichacliente;
		private System.Windows.Forms.ComboBox cboPerfil;
		private System.Windows.Forms.Label lblPerfil;
		private System.Windows.Forms.TextBox txtCliente;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.GroupBox gboComponentes;
		private System.Windows.Forms.ComboBox cboMemoria;
		private System.Windows.Forms.ComboBox cboGabinete;
		private System.Windows.Forms.ComboBox cboFonte;
		private System.Windows.Forms.ComboBox cboPlacaMae;
		private System.Windows.Forms.ComboBox cboSSD;
		private System.Windows.Forms.ComboBox cboPlacaVideo;
		private System.Windows.Forms.ComboBox cboProcessador;
		private System.Windows.Forms.Label lblGabinete;
		private System.Windows.Forms.Label lblFonte;
		private System.Windows.Forms.Label lblPlacaMae;
		private System.Windows.Forms.Label lblPlacadeVideo;
		private System.Windows.Forms.Label lblSSD;
		private System.Windows.Forms.Label lblMemoriaRAM;
		private System.Windows.Forms.Label lblProcessador;
		private System.Windows.Forms.GroupBox gboConfiguração;
		private System.Windows.Forms.GroupBox gboTaxa;
		private System.Windows.Forms.CheckBox chkMonitor;
		private System.Windows.Forms.NumericUpDown nudSSDGB;
		private System.Windows.Forms.NumericUpDown nudMemoriaGB;
		private System.Windows.Forms.Label lblSSDGB;
		private System.Windows.Forms.Label lblMemoriaGB;
		private System.Windows.Forms.Label lblValorDesconto;
		private System.Windows.Forms.Label lblValorMontagem;
		private System.Windows.Forms.GroupBox gboRecomendacao;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblSubtotal;
		private System.Windows.Forms.Label lblRecomendacao;
		private System.Windows.Forms.NumericUpDown nudDesconto;
		private System.Windows.Forms.NumericUpDown nudMontagem;
		private System.Windows.Forms.CheckBox chkHeadset;
		private System.Windows.Forms.CheckBox chkKit;
		
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
			this.gboFichacliente = new System.Windows.Forms.GroupBox();
			this.cboPerfil = new System.Windows.Forms.ComboBox();
			this.lblPerfil = new System.Windows.Forms.Label();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.lblCliente = new System.Windows.Forms.Label();
			this.gboComponentes = new System.Windows.Forms.GroupBox();
			this.cboMemoria = new System.Windows.Forms.ComboBox();
			this.cboGabinete = new System.Windows.Forms.ComboBox();
			this.cboFonte = new System.Windows.Forms.ComboBox();
			this.cboPlacaMae = new System.Windows.Forms.ComboBox();
			this.cboSSD = new System.Windows.Forms.ComboBox();
			this.cboPlacaVideo = new System.Windows.Forms.ComboBox();
			this.cboProcessador = new System.Windows.Forms.ComboBox();
			this.lblGabinete = new System.Windows.Forms.Label();
			this.lblFonte = new System.Windows.Forms.Label();
			this.lblPlacaMae = new System.Windows.Forms.Label();
			this.lblPlacadeVideo = new System.Windows.Forms.Label();
			this.lblSSD = new System.Windows.Forms.Label();
			this.lblMemoriaRAM = new System.Windows.Forms.Label();
			this.lblProcessador = new System.Windows.Forms.Label();
			this.gboConfiguração = new System.Windows.Forms.GroupBox();
			this.chkHeadset = new System.Windows.Forms.CheckBox();
			this.chkKit = new System.Windows.Forms.CheckBox();
			this.chkMonitor = new System.Windows.Forms.CheckBox();
			this.nudSSDGB = new System.Windows.Forms.NumericUpDown();
			this.nudMemoriaGB = new System.Windows.Forms.NumericUpDown();
			this.lblSSDGB = new System.Windows.Forms.Label();
			this.lblMemoriaGB = new System.Windows.Forms.Label();
			this.gboTaxa = new System.Windows.Forms.GroupBox();
			this.nudDesconto = new System.Windows.Forms.NumericUpDown();
			this.nudMontagem = new System.Windows.Forms.NumericUpDown();
			this.lblValorDesconto = new System.Windows.Forms.Label();
			this.lblValorMontagem = new System.Windows.Forms.Label();
			this.gboRecomendacao = new System.Windows.Forms.GroupBox();
			this.lblRecomendacao = new System.Windows.Forms.Label();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.gboFichacliente.SuspendLayout();
			this.gboComponentes.SuspendLayout();
			this.gboConfiguração.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudSSDGB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMemoriaGB)).BeginInit();
			this.gboTaxa.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDesconto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMontagem)).BeginInit();
			this.gboRecomendacao.SuspendLayout();
			this.SuspendLayout();
			// 
			// gboFichacliente
			// 
			this.gboFichacliente.Controls.Add(this.cboPerfil);
			this.gboFichacliente.Controls.Add(this.lblPerfil);
			this.gboFichacliente.Controls.Add(this.txtCliente);
			this.gboFichacliente.Controls.Add(this.lblCliente);
			this.gboFichacliente.Location = new System.Drawing.Point(14, 15);
			this.gboFichacliente.Margin = new System.Windows.Forms.Padding(4);
			this.gboFichacliente.Name = "gboFichacliente";
			this.gboFichacliente.Padding = new System.Windows.Forms.Padding(4);
			this.gboFichacliente.Size = new System.Drawing.Size(1157, 126);
			this.gboFichacliente.TabIndex = 0;
			this.gboFichacliente.TabStop = false;
			this.gboFichacliente.Text = "Ficha do cliente";
			// 
			// cboPerfil
			// 
			this.cboPerfil.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboPerfil.FormattingEnabled = true;
			this.cboPerfil.Items.AddRange(new object[] {
			"Administrativo",
			"Professor de Tecnologia",
			"Desenvolvedor de Software",
			"Desenvolvedor de Jogos"});
			this.cboPerfil.Location = new System.Drawing.Point(782, 84);
			this.cboPerfil.Name = "cboPerfil";
			this.cboPerfil.Size = new System.Drawing.Size(368, 30);
			this.cboPerfil.TabIndex = 3;
			// 
			// lblPerfil
			// 
			this.lblPerfil.AutoSize = true;
			this.lblPerfil.Location = new System.Drawing.Point(711, 87);
			this.lblPerfil.Name = "lblPerfil";
			this.lblPerfil.Size = new System.Drawing.Size(65, 30);
			this.lblPerfil.TabIndex = 2;
			this.lblPerfil.Text = "Perfil:";
			// 
			// txtCliente
			// 
			this.txtCliente.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCliente.Location = new System.Drawing.Point(95, 84);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.Size = new System.Drawing.Size(610, 27);
			this.txtCliente.TabIndex = 1;
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Location = new System.Drawing.Point(7, 80);
			this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(81, 30);
			this.lblCliente.TabIndex = 0;
			this.lblCliente.Text = "Cliente:";
			// 
			// gboComponentes
			// 
			this.gboComponentes.Controls.Add(this.cboMemoria);
			this.gboComponentes.Controls.Add(this.cboGabinete);
			this.gboComponentes.Controls.Add(this.cboFonte);
			this.gboComponentes.Controls.Add(this.cboPlacaMae);
			this.gboComponentes.Controls.Add(this.cboSSD);
			this.gboComponentes.Controls.Add(this.cboPlacaVideo);
			this.gboComponentes.Controls.Add(this.cboProcessador);
			this.gboComponentes.Controls.Add(this.lblGabinete);
			this.gboComponentes.Controls.Add(this.lblFonte);
			this.gboComponentes.Controls.Add(this.lblPlacaMae);
			this.gboComponentes.Controls.Add(this.lblPlacadeVideo);
			this.gboComponentes.Controls.Add(this.lblSSD);
			this.gboComponentes.Controls.Add(this.lblMemoriaRAM);
			this.gboComponentes.Controls.Add(this.lblProcessador);
			this.gboComponentes.Location = new System.Drawing.Point(14, 148);
			this.gboComponentes.Name = "gboComponentes";
			this.gboComponentes.Size = new System.Drawing.Size(547, 473);
			this.gboComponentes.TabIndex = 1;
			this.gboComponentes.TabStop = false;
			this.gboComponentes.Text = "Preços dos Componentes (R$)";
			// 
			// cboMemoria
			// 
			this.cboMemoria.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMemoria.FormattingEnabled = true;
			this.cboMemoria.Items.AddRange(new object[] {
			"Memória RAM 8 GB 8 GB R$ 180,00",
			"Memória RAM 16 GB 16 GB R$ 320,00",
			"Memória RAM 32 GB 32 GB R$ 620,00"});
			this.cboMemoria.Location = new System.Drawing.Point(156, 108);
			this.cboMemoria.Name = "cboMemoria";
			this.cboMemoria.Size = new System.Drawing.Size(375, 30);
			this.cboMemoria.TabIndex = 13;
			// 
			// cboGabinete
			// 
			this.cboGabinete.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboGabinete.FormattingEnabled = true;
			this.cboGabinete.Items.AddRange(new object[] {
			"Gabinete Gabinete básico Básico R$ 250,00",
			"Gabinete Gabinete intermediário Intermediário R$ 350,00",
			"Gabinete Gabinete gamer Gamer R$ 500,00"});
			this.cboGabinete.Location = new System.Drawing.Point(112, 409);
			this.cboGabinete.Name = "cboGabinete";
			this.cboGabinete.Size = new System.Drawing.Size(419, 30);
			this.cboGabinete.TabIndex = 12;
			// 
			// cboFonte
			// 
			this.cboFonte.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboFonte.FormattingEnabled = true;
			this.cboFonte.Items.AddRange(new object[] {
			"Fonte Fonte 500 W 500 W R$ 280,00",
			"Fonte Fonte 650 W 650 W R$ 420,00",
			"Fonte Fonte 750 W 750 W R$ 580,00"});
			this.cboFonte.Location = new System.Drawing.Point(138, 343);
			this.cboFonte.Name = "cboFonte";
			this.cboFonte.Size = new System.Drawing.Size(393, 30);
			this.cboFonte.TabIndex = 11;
			// 
			// cboPlacaMae
			// 
			this.cboPlacaMae.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboPlacaMae.FormattingEnabled = true;
			this.cboPlacaMae.Items.AddRange(new object[] {
			"Placa-mãe Placa-mãe básica Básica R$ 550,00",
			"Placa-mãe Placa-mãe intermediária Intermediária R$ 750,00",
			"Placa-mãe Placa-mãe avançada Avançada R$ 1.100,00"});
			this.cboPlacaMae.Location = new System.Drawing.Point(127, 283);
			this.cboPlacaMae.Name = "cboPlacaMae";
			this.cboPlacaMae.Size = new System.Drawing.Size(404, 30);
			this.cboPlacaMae.TabIndex = 10;
			// 
			// cboSSD
			// 
			this.cboSSD.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboSSD.FormattingEnabled = true;
			this.cboSSD.Items.AddRange(new object[] {
			"SSD 240 GB 240 GB R$ 180,00",
			"SSD 500 GB 500 GB R$ 280,00",
			"SSD 1 TB 1.000 GB R$ 480,00"});
			this.cboSSD.Location = new System.Drawing.Point(72, 160);
			this.cboSSD.Name = "cboSSD";
			this.cboSSD.Size = new System.Drawing.Size(459, 30);
			this.cboSSD.TabIndex = 9;
			// 
			// cboPlacaVideo
			// 
			this.cboPlacaVideo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboPlacaVideo.FormattingEnabled = true;
			this.cboPlacaVideo.Items.AddRange(new object[] {
			"Placa de vídeo Vídeo integrado Integrada R$ 0,00",
			"Placa de vídeo Dedicada básica Dedicada R$ 1.500,00",
			"Placa de vídeo Dedicada intermediária Dedicada R$ 2.300,00"});
			this.cboPlacaVideo.Location = new System.Drawing.Point(167, 223);
			this.cboPlacaVideo.Name = "cboPlacaVideo";
			this.cboPlacaVideo.Size = new System.Drawing.Size(364, 30);
			this.cboPlacaVideo.TabIndex = 8;
			// 
			// cboProcessador
			// 
			this.cboProcessador.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboProcessador.FormattingEnabled = true;
			this.cboProcessador.Items.AddRange(new object[] {
			"Processador Processador básico Básico R$ 650,00",
			"Processador Processador intermediário Intermediário R$ 1.000,00",
			"Processador Processador avançado Avançado R$ 1.450,00",
			"Processador Processador de alto desempenho Alto desempenho R$ 2.300,00"});
			this.cboProcessador.Location = new System.Drawing.Point(144, 52);
			this.cboProcessador.Name = "cboProcessador";
			this.cboProcessador.Size = new System.Drawing.Size(387, 30);
			this.cboProcessador.TabIndex = 7;
			// 
			// lblGabinete
			// 
			this.lblGabinete.AutoSize = true;
			this.lblGabinete.Location = new System.Drawing.Point(6, 409);
			this.lblGabinete.Name = "lblGabinete";
			this.lblGabinete.Size = new System.Drawing.Size(100, 30);
			this.lblGabinete.TabIndex = 6;
			this.lblGabinete.Text = "Gabinete:";
			// 
			// lblFonte
			// 
			this.lblFonte.AutoSize = true;
			this.lblFonte.Location = new System.Drawing.Point(6, 343);
			this.lblFonte.Name = "lblFonte";
			this.lblFonte.Size = new System.Drawing.Size(126, 30);
			this.lblFonte.TabIndex = 5;
			this.lblFonte.Text = "Fonte de Ali:";
			// 
			// lblPlacaMae
			// 
			this.lblPlacaMae.AutoSize = true;
			this.lblPlacaMae.Location = new System.Drawing.Point(6, 283);
			this.lblPlacaMae.Name = "lblPlacaMae";
			this.lblPlacaMae.Size = new System.Drawing.Size(115, 30);
			this.lblPlacaMae.TabIndex = 4;
			this.lblPlacaMae.Text = "Placa-Mãe:";
			// 
			// lblPlacadeVideo
			// 
			this.lblPlacadeVideo.AutoSize = true;
			this.lblPlacadeVideo.Location = new System.Drawing.Point(6, 223);
			this.lblPlacadeVideo.Name = "lblPlacadeVideo";
			this.lblPlacadeVideo.Size = new System.Drawing.Size(155, 30);
			this.lblPlacadeVideo.TabIndex = 3;
			this.lblPlacadeVideo.Text = "Placa de Vídeo:";
			// 
			// lblSSD
			// 
			this.lblSSD.AutoSize = true;
			this.lblSSD.Location = new System.Drawing.Point(6, 160);
			this.lblSSD.Name = "lblSSD";
			this.lblSSD.Size = new System.Drawing.Size(60, 30);
			this.lblSSD.TabIndex = 2;
			this.lblSSD.Text = "SSD:";
			// 
			// lblMemoriaRAM
			// 
			this.lblMemoriaRAM.AutoSize = true;
			this.lblMemoriaRAM.Location = new System.Drawing.Point(6, 108);
			this.lblMemoriaRAM.Name = "lblMemoriaRAM";
			this.lblMemoriaRAM.Size = new System.Drawing.Size(144, 30);
			this.lblMemoriaRAM.TabIndex = 1;
			this.lblMemoriaRAM.Text = "Memória Ram:";
			// 
			// lblProcessador
			// 
			this.lblProcessador.AutoSize = true;
			this.lblProcessador.Location = new System.Drawing.Point(6, 52);
			this.lblProcessador.Name = "lblProcessador";
			this.lblProcessador.Size = new System.Drawing.Size(132, 30);
			this.lblProcessador.TabIndex = 0;
			this.lblProcessador.Text = "Processador:";
			// 
			// gboConfiguração
			// 
			this.gboConfiguração.Controls.Add(this.chkHeadset);
			this.gboConfiguração.Controls.Add(this.chkKit);
			this.gboConfiguração.Controls.Add(this.chkMonitor);
			this.gboConfiguração.Controls.Add(this.nudSSDGB);
			this.gboConfiguração.Controls.Add(this.nudMemoriaGB);
			this.gboConfiguração.Controls.Add(this.lblSSDGB);
			this.gboConfiguração.Controls.Add(this.lblMemoriaGB);
			this.gboConfiguração.Location = new System.Drawing.Point(567, 148);
			this.gboConfiguração.Name = "gboConfiguração";
			this.gboConfiguração.Size = new System.Drawing.Size(605, 287);
			this.gboConfiguração.TabIndex = 2;
			this.gboConfiguração.TabStop = false;
			this.gboConfiguração.Text = "Configuração do Sistema";
			// 
			// chkHeadset
			// 
			this.chkHeadset.AutoSize = true;
			this.chkHeadset.Location = new System.Drawing.Point(234, 247);
			this.chkHeadset.Name = "chkHeadset";
			this.chkHeadset.Size = new System.Drawing.Size(110, 34);
			this.chkHeadset.TabIndex = 6;
			this.chkHeadset.Text = "Headset";
			this.chkHeadset.UseVisualStyleBackColor = true;
			// 
			// chkKit
			// 
			this.chkKit.AutoSize = true;
			this.chkKit.Location = new System.Drawing.Point(345, 185);
			this.chkKit.Name = "chkKit";
			this.chkKit.Size = new System.Drawing.Size(211, 34);
			this.chkKit.TabIndex = 5;
			this.chkKit.Text = "Kit teclado e mouse";
			this.chkKit.UseVisualStyleBackColor = true;
			// 
			// chkMonitor
			// 
			this.chkMonitor.AutoSize = true;
			this.chkMonitor.Location = new System.Drawing.Point(6, 185);
			this.chkMonitor.Name = "chkMonitor";
			this.chkMonitor.Size = new System.Drawing.Size(255, 34);
			this.chkMonitor.TabIndex = 4;
			this.chkMonitor.Text = "Monitor de 24 polegadas";
			this.chkMonitor.UseVisualStyleBackColor = true;
			// 
			// nudSSDGB
			// 
			this.nudSSDGB.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudSSDGB.Location = new System.Drawing.Point(122, 138);
			this.nudSSDGB.Name = "nudSSDGB";
			this.nudSSDGB.Size = new System.Drawing.Size(475, 27);
			this.nudSSDGB.TabIndex = 3;
			// 
			// nudMemoriaGB
			// 
			this.nudMemoriaGB.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudMemoriaGB.Location = new System.Drawing.Point(158, 62);
			this.nudMemoriaGB.Name = "nudMemoriaGB";
			this.nudMemoriaGB.Size = new System.Drawing.Size(439, 27);
			this.nudMemoriaGB.TabIndex = 2;
			// 
			// lblSSDGB
			// 
			this.lblSSDGB.AutoSize = true;
			this.lblSSDGB.Location = new System.Drawing.Point(6, 138);
			this.lblSSDGB.Name = "lblSSDGB";
			this.lblSSDGB.Size = new System.Drawing.Size(110, 30);
			this.lblSSDGB.TabIndex = 1;
			this.lblSSDGB.Text = "SSD (GB):";
			// 
			// lblMemoriaGB
			// 
			this.lblMemoriaGB.AutoSize = true;
			this.lblMemoriaGB.Location = new System.Drawing.Point(6, 59);
			this.lblMemoriaGB.Name = "lblMemoriaGB";
			this.lblMemoriaGB.Size = new System.Drawing.Size(146, 30);
			this.lblMemoriaGB.TabIndex = 0;
			this.lblMemoriaGB.Text = "Memória (GB):";
			// 
			// gboTaxa
			// 
			this.gboTaxa.Controls.Add(this.nudDesconto);
			this.gboTaxa.Controls.Add(this.nudMontagem);
			this.gboTaxa.Controls.Add(this.lblValorDesconto);
			this.gboTaxa.Controls.Add(this.lblValorMontagem);
			this.gboTaxa.Location = new System.Drawing.Point(566, 441);
			this.gboTaxa.Name = "gboTaxa";
			this.gboTaxa.Size = new System.Drawing.Size(605, 180);
			this.gboTaxa.TabIndex = 3;
			this.gboTaxa.TabStop = false;
			this.gboTaxa.Text = "Ajustes Financeiros";
			// 
			// nudDesconto
			// 
			this.nudDesconto.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudDesconto.Location = new System.Drawing.Point(156, 140);
			this.nudDesconto.Name = "nudDesconto";
			this.nudDesconto.Size = new System.Drawing.Size(442, 27);
			this.nudDesconto.TabIndex = 3;
			// 
			// nudMontagem
			// 
			this.nudMontagem.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudMontagem.Location = new System.Drawing.Point(215, 68);
			this.nudMontagem.Name = "nudMontagem";
			this.nudMontagem.Size = new System.Drawing.Size(383, 27);
			this.nudMontagem.TabIndex = 2;
			// 
			// lblValorDesconto
			// 
			this.lblValorDesconto.AutoSize = true;
			this.lblValorDesconto.Location = new System.Drawing.Point(7, 137);
			this.lblValorDesconto.Name = "lblValorDesconto";
			this.lblValorDesconto.Size = new System.Drawing.Size(143, 30);
			this.lblValorDesconto.TabIndex = 1;
			this.lblValorDesconto.Text = "Desconto (%):";
			// 
			// lblValorMontagem
			// 
			this.lblValorMontagem.AutoSize = true;
			this.lblValorMontagem.Location = new System.Drawing.Point(7, 65);
			this.lblValorMontagem.Name = "lblValorMontagem";
			this.lblValorMontagem.Size = new System.Drawing.Size(202, 30);
			this.lblValorMontagem.TabIndex = 0;
			this.lblValorMontagem.Text = "Taxa Montagem (%):";
			// 
			// gboRecomendacao
			// 
			this.gboRecomendacao.Controls.Add(this.lblRecomendacao);
			this.gboRecomendacao.Controls.Add(this.lblSubtotal);
			this.gboRecomendacao.Controls.Add(this.lblTotal);
			this.gboRecomendacao.Location = new System.Drawing.Point(14, 627);
			this.gboRecomendacao.Name = "gboRecomendacao";
			this.gboRecomendacao.Size = new System.Drawing.Size(897, 181);
			this.gboRecomendacao.TabIndex = 4;
			this.gboRecomendacao.TabStop = false;
			this.gboRecomendacao.Text = "Resumo do Orçamento";
			// 
			// lblRecomendacao
			// 
			this.lblRecomendacao.AutoSize = true;
			this.lblRecomendacao.Location = new System.Drawing.Point(315, 55);
			this.lblRecomendacao.Name = "lblRecomendacao";
			this.lblRecomendacao.Size = new System.Drawing.Size(158, 30);
			this.lblRecomendacao.TabIndex = 2;
			this.lblRecomendacao.Text = "Recomendação:";
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.Location = new System.Drawing.Point(7, 113);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(154, 30);
			this.lblSubtotal.TabIndex = 1;
			this.lblSubtotal.Text = "Subtotal Peças:";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(7, 55);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(118, 30);
			this.lblTotal.TabIndex = 0;
			this.lblTotal.Text = "Total Geral:";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(917, 644);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(254, 36);
			this.btnCalcular.TabIndex = 5;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(917, 710);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(255, 36);
			this.btnLimpar.TabIndex = 6;
			this.btnLimpar.Text = "Limpar:";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.BtnLimparClick);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(917, 775);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(252, 33);
			this.btnSair.TabIndex = 7;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 833);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.gboRecomendacao);
			this.Controls.Add(this.gboTaxa);
			this.Controls.Add(this.gboConfiguração);
			this.Controls.Add(this.gboComponentes);
			this.Controls.Add(this.gboFichacliente);
			this.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Atividade01";
			this.gboFichacliente.ResumeLayout(false);
			this.gboFichacliente.PerformLayout();
			this.gboComponentes.ResumeLayout(false);
			this.gboComponentes.PerformLayout();
			this.gboConfiguração.ResumeLayout(false);
			this.gboConfiguração.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudSSDGB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMemoriaGB)).EndInit();
			this.gboTaxa.ResumeLayout(false);
			this.gboTaxa.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDesconto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMontagem)).EndInit();
			this.gboRecomendacao.ResumeLayout(false);
			this.gboRecomendacao.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
