using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade03_Boletim_Escolar
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		
		}
		void BtnCalcularClick(object sender, EventArgs e)
{
    double nota1, nota2, nota3, nota4, media;

    if (!double.TryParse(txtNota1.Text, out nota1) ||
        !double.TryParse(txtNota2.Text, out nota2) ||
        !double.TryParse(txtNota3.Text, out nota3) ||
        !double.TryParse(txtNota4.Text, out nota4))
    {
        MessageBox.Show("Digite notas válidas.");
        return;
    }

    media = (nota1 + nota2 + nota3 + nota4) / 4;

    lblMedia.Text = media.ToString("F1");

    if (nudFrequencia.Value < 75)
    {
        lblSituacao.Text = "Reprovado por Frequência";
    }
    else if (media >= 7)
    {
        lblSituacao.Text = "Aprovado";
    }
    else if (media >= 5)
    {
        lblSituacao.Text = "Recuperação";
    }
    else
    {
        lblSituacao.Text = "Reprovado";
    }
}
		void BtnAdicionarClick(object sender, EventArgs e)
{
    if (txtAluno.Text == "")
    {
        MessageBox.Show("Informe o nome do aluno.");
        return;
    }

    lstResultados.Items.Add(
        txtAluno.Text + " - Média: " +
        lblMedia.Text + " - " +
        lblSituacao.Text);

    lblQuantidade.Text = lstResultados.Items.Count.ToString();
}
		void BtnRemoverClick(object sender, EventArgs e)
{
    if (lstResultados.SelectedIndex != -1)
    {
        lstResultados.Items.RemoveAt(lstResultados.SelectedIndex);
        lblQuantidade.Text = lstResultados.Items.Count.ToString();
    }
}
		void BtnGerarResumoClick(object sender, EventArgs e)
{
    int aprovados = 0;
    int recuperacao = 0;
    int reprovados = 0;

    foreach (string item in lstResultados.Items)
    {
        if (item.Contains("Aprovado"))
            aprovados++;
        else if (item.Contains("Recuperação"))
            recuperacao++;
        else
            reprovados++;
    }

    txtResumoTurma.Text =
        "Total de alunos: " + lstResultados.Items.Count +
        "Aprovados: " + aprovados +
        "Recuperação: " + recuperacao +
        "Reprovados: " + reprovados;
}
		void BtnLimparCamposClick(object sender, EventArgs e)
{
    txtAluno.Clear();
    txtTurma.Clear();
    txtNota1.Clear();
    txtNota2.Clear();
    txtNota3.Clear();
    txtNota4.Clear();

    nudFrequencia.Value = 0;

    lblMedia.Text = "";
    lblSituacao.Text = "";

    txtAluno.Focus();
}
		void BtnLimparListaClick(object sender, EventArgs e)
{
    lstResultados.Items.Clear();
    txtResumoTurma.Clear();
    lblQuantidade.Text = "0";
}
	}
}
