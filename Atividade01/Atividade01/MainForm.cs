using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade01
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		
		}
	void BtnCalcularClick(object sender, EventArgs e)
{
    if (txtCliente.Text.Trim() == "")
    {
        MessageBox.Show("Informe o nome do cliente.");
        return;
    }

    if (cboPerfil.SelectedIndex == -1)
    {
        MessageBox.Show("Selecione um perfil.");
        return;
    }

    if (cboProcessador.SelectedIndex == -1 ||
        cboMemoria.SelectedIndex == -1 ||
        cboSSD.SelectedIndex == -1 ||
        cboPlacaVideo.SelectedIndex == -1 ||
        cboPlacaMae.SelectedIndex == -1 ||
        cboFonte.SelectedIndex == -1 ||
        cboGabinete.SelectedIndex == -1)
    {
        MessageBox.Show("Selecione todos os componentes.");
        return;
    }

    decimal subtotal = 0;

    // Componentes
    subtotal += 1200m; // Processador
    subtotal += 450m;  // Memória
    subtotal += 380m;  // SSD
    subtotal += 1700m; // Placa de vídeo
    subtotal += 650m;  // Placa-mãe
    subtotal += 350m;  // Fonte
    subtotal += 280m;  // Gabinete

    // Acessórios
    if (chkMonitor.Checked)
        subtotal += 700m;

    if (chkMonitor.Checked)
        subtotal += 120m;

    if (chkHeadset.Checked)
        subtotal += 180m;

    decimal montagem = subtotal * nudMontagem.Value / 100;

    decimal desconto = subtotal * nudDesconto.Value / 100;

    decimal total = subtotal + montagem - desconto;

    lblSubtotal.Text = subtotal.ToString("C2");
    lblValorMontagem.Text = montagem.ToString("C2");
    lblValorDesconto.Text = desconto.ToString("C2");
    lblTotal.Text = total.ToString("C2");

    string recomendacao = "";

    if (cboPerfil.Text == "Administrativo")
    {
        if (nudMemoriaGB.Value >= 8 && nudSSDGB.Value >= 240)
            recomendacao = "Configuração recomendada.";
        else
            recomendacao = "Aumente para 8GB RAM e SSD 240GB.";
    }

    if (cboPerfil.Text == "Professor de Tecnologia")
    {
        if (nudMemoriaGB.Value >= 16 && nudSSDGB.Value >= 480)
            recomendacao = "Configuração recomendada.";
        else
            recomendacao = "Aumente para 16GB RAM e SSD 480GB.";
    }

    if (cboPerfil.Text == "Desenvolvedor de Software")
    {
        if (nudMemoriaGB.Value >= 16 && nudSSDGB.Value >= 480)
            recomendacao = "Configuração recomendada.";
        else
            recomendacao = "Aumente para 16GB RAM e SSD 480GB.";
    }

    if (cboPerfil.Text == "Desenvolvimento de Jogos")
    {
        if (nudMemoriaGB.Value >= 32 &&
            nudSSDGB.Value >= 1000 &&
            cboPlacaVideo.SelectedIndex != -1)
            recomendacao = "Configuração recomendada.";
        else
            recomendacao = "Use 32GB RAM, SSD 1TB e placa de vídeo dedicada.";
    }

    if (chkMonitor.Checked)
        recomendacao += "Monitor 24: R$ 700,00";

    if (chkMonitor.Checked)
        recomendacao += "Kit teclado e mouse: R$ 120,00";

    if (chkHeadset.Checked)
        recomendacao += "Headset: R$ 180,00";

    lblRecomendacao.Text = recomendacao;
}
		void BtnLimparClick(object sender, EventArgs e)
		{
	       txtCliente.Clear();
    cboProcessador.Text = "";
    cboMemoria.Text = "";
    cboSSD.Text = "";
    cboPlacaVideo.Text = "";
    cboPlacaMae.Text = "";
    cboFonte.Text = "";
    cboGabinete.Text = "";
    nudMontagem.Text = "";
    nudDesconto.Text = "";

    cboPerfil.SelectedIndex = -1;

    nudMemoriaGB.Value = 0;
    nudSSDGB.Value = 0;

    chkMonitor.Checked = false;

    lblSubtotal.Text = "";
    lblValorMontagem.Text = "";
    lblValorDesconto.Text = "";
    lblTotal.Text = "";
    gboRecomendacao.Text = "";

    txtCliente.Focus();
		}
		void BtnSairClick(object sender, EventArgs e)
		{
	       Close();
		}
	}
}	