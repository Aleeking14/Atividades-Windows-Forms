using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade02_Sistema_Vendas
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void BtnCalcularClick(object sender, EventArgs e)
{
    if (txtCliente.Text.Trim() == "" || txtProduto.Text.Trim() == "")
    {
        MessageBox.Show("Preencha o cliente e o produto.");
        return;
    }

    decimal valor;

    if (!decimal.TryParse(txtValorUnitario.Text, out valor))
    {
        MessageBox.Show("Valor unitário inválido.");
        return;
    }

    if (nudQuantidade.Value <= 0)
    {
        MessageBox.Show("Informe uma quantidade.");
        return;
    }

    decimal subtotal = valor * nudQuantidade.Value;

    decimal desconto = 0;
    decimal acrescimo = 0;

    // Forma de pagamento
    if (rdbDinheiro.Checked)
        desconto = subtotal * 0.10m;

    else if (rdbPix.Checked)
        desconto = subtotal * 0.08m;

    else if (rdbDebito.Checked)
        desconto = subtotal * 0.03m;

    else if (rdbCredito.Checked)
        desconto = 0;

    else
    {
        MessageBox.Show("Selecione uma forma de pagamento.");
        return;
    }

    // Desconto extra
    if (subtotal > 1000)
        desconto += subtotal * 0.02m;

    // Máximo de 15%
    if (desconto > subtotal * 0.15m)
        desconto = subtotal * 0.15m;

    // Serviços
    if (chkEntrega.Checked)
        acrescimo += 25;

    if (chkGarantia.Checked)
        acrescimo += subtotal * 0.05m;

    decimal total = subtotal - desconto + acrescimo;

    lblSubtotal.Text = subtotal.ToString("C2");
    lblDesconto.Text = desconto.ToString("C2");
    lblAcrescimos.Text = acrescimo.ToString("C2");
    lblTotal.Text = total.ToString("C2");

    txtResumo.Text =
        "Cliente: " + txtCliente.Text +
        "Produto: " + txtProduto.Text +
        "Quantidade: " + nudQuantidade.Value +
        "Valor Unitário: " + valor.ToString("C2") +
        "Subtotal: " + subtotal.ToString("C2") +
        "Desconto: " + desconto.ToString("C2") +
        "Acréscimos: " + acrescimo.ToString("C2") +
        "Total: " + total.ToString("C2");
}
		void BtnNovaVendaClick(object sender, EventArgs e)
{
    txtCliente.Clear();
    txtProduto.Clear();
    txtValorUnitario.Clear();
    txtResumo.Clear();

    nudQuantidade.Value = 1;

    rdbDinheiro.Checked = false;
    rdbPix.Checked = false;
    rdbDebito.Checked = false;
    rdbCredito.Checked = false;

    chkEntrega.Checked = false;
    chkGarantia.Checked = false;

    lblSubtotal.Text = "R$";
    lblDesconto.Text = "R$";
    lblAcrescimos.Text = "R$";
    lblTotal.Text = "R$";

    txtCliente.Focus();
}
		void BtnSairClick(object sender, EventArgs e)
		{
	        Close();
		}
			
	}
}