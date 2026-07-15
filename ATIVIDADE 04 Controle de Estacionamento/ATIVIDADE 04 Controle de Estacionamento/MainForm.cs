using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ATIVIDADE_04_Controle_de_Estacionamento
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void BtnRegistrarEntradaClick(object sender, EventArgs e)
{
    if (txtPlaca.Text == "" ||
        txtModelo.Text == "" ||
        cboTipoVeiculo.SelectedIndex == -1)
    {
        MessageBox.Show("Preencha todos os campos.");
        return;
    }

    dgvVeiculos.Rows.Add(
        txtPlaca.Text,
        txtModelo.Text,
        cboTipoVeiculo.Text,
        dtpEntrada.Value.ToString("dd/MM/yyyy HH:mm"),
        "",
        "R$ 0,00"
    );

    lblEstacionados.Text = dgvVeiculos.Rows.Count.ToString();

    MessageBox.Show("Entrada registrada.");
}
		void BtnRegistrarSaidaClick(object sender, EventArgs e)
{
    if (dgvVeiculos.CurrentRow == null)
    {
        MessageBox.Show("Selecione um veículo.");
        return;
    }

    DateTime entrada = Convert.ToDateTime(dgvVeiculos.CurrentRow.Cells[3].Value);
    DateTime saida = dtpSaida.Value;

    double horas = (saida - entrada).TotalHours;

    if (horas < 1)
        horas = 1;

    decimal valorHora = 0;

    switch (dgvVeiculos.CurrentRow.Cells[2].Value.ToString())
    {
        case "Carro":
            valorHora = 10;
            break;

        case "Moto":
            valorHora = 5;
            break;

        case "Caminhonete":
            valorHora = 15;
            break;
    }

    decimal valor = (decimal)horas * valorHora;

    dgvVeiculos.CurrentRow.Cells[4].Value = saida.ToString("dd/MM/yyyy HH:mm");
    dgvVeiculos.CurrentRow.Cells[5].Value = valor.ToString("C2");

    lblFinalizados.Text =
        (Convert.ToInt32(lblFinalizados.Text) + 1).ToString();

    decimal total =
        Convert.ToDecimal(lblTotalRecebido.Text.Replace("R$", ""));

    total += valor;

    lblTotalRecebido.Text = total.ToString("C2");

    MessageBox.Show("Saída registrada com sucesso.");
}
		void BtnPesquisarClick(object sender, EventArgs e)
{
    foreach (DataGridViewRow linha in dgvVeiculos.Rows)
    {
        if (linha.Cells[0].Value != null &&
            linha.Cells[0].Value.ToString() == txtPesquisarPlaca.Text)
        {
            linha.Selected = true;
            dgvVeiculos.CurrentCell = linha.Cells[0];
            return;
        }
    }

    MessageBox.Show("Placa não encontrada.");
}
		void BtnMostrarTodosClick(object sender, EventArgs e)
{
    foreach (DataGridViewRow linha in dgvVeiculos.Rows)
    {
        linha.Visible = true;
    }
}
		void BtnRemoverClick(object sender, EventArgs e)
{
    if (dgvVeiculos.CurrentRow == null)
    {
        MessageBox.Show("Selecione um registro.");
        return;
    }

    dgvVeiculos.Rows.Remove(dgvVeiculos.CurrentRow);

    lblEstacionados.Text = dgvVeiculos.Rows.Count.ToString();
}
		void BtnLimparClick(object sender, EventArgs e)
{
    txtPlaca.Clear();
    txtModelo.Clear();
    txtPesquisarPlaca.Clear();

    cboTipoVeiculo.SelectedIndex = -1;

    dtpEntrada.Value = DateTime.Now;
    dtpSaida.Value = DateTime.Now;

    txtPlaca.Focus();
}
		void BtnSairClick(object sender, EventArgs e)
		{
	       Close();
		}
	}
}