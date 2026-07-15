/*
 * Created by SharpDevelop.
 * User: Alex Junio
 * Date: 14/07/2026
 * Time: 19:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade03_Boletim_Escolar
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblLançamentoNotas;
		private System.Windows.Forms.GroupBox gboDadosAluno;
		private System.Windows.Forms.TextBox txtTurma;
		private System.Windows.Forms.TextBox txtAluno;
		private System.Windows.Forms.Label lblTurma;
		private System.Windows.Forms.Label lblAluno;
		private System.Windows.Forms.GroupBox gboNotas;
		private System.Windows.Forms.Label lblNota1;
		private System.Windows.Forms.TextBox txtNota4;
		private System.Windows.Forms.TextBox txtNota3;
		private System.Windows.Forms.TextBox txtNota2;
		private System.Windows.Forms.TextBox txtNota1;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblNota4;
		private System.Windows.Forms.Label lblNota3;
		private System.Windows.Forms.Label lblNota2;
		private System.Windows.Forms.GroupBox gboAssiduidade;
		private System.Windows.Forms.NumericUpDown nudFrequencia;
		private System.Windows.Forms.Label lblFrequencia;
		private System.Windows.Forms.GroupBox gboResultadosDiretos;
		private System.Windows.Forms.Label lblSituacao;
		private System.Windows.Forms.Label lblMedia;
		private System.Windows.Forms.GroupBox gboListagemHistorico;
		private System.Windows.Forms.Button btnGerarResumo;
		private System.Windows.Forms.TextBox txtResumoTurma;
		private System.Windows.Forms.Label lblResumoTurma;
		private System.Windows.Forms.Label lblQuantidade;
		private System.Windows.Forms.Button btnRemover;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.ListBox lstResultados;
		private System.Windows.Forms.Button btnLimparCampos;
		private System.Windows.Forms.Button btnLimparLista;
		
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
			this.lblLançamentoNotas = new System.Windows.Forms.Label();
			this.gboDadosAluno = new System.Windows.Forms.GroupBox();
			this.txtTurma = new System.Windows.Forms.TextBox();
			this.txtAluno = new System.Windows.Forms.TextBox();
			this.lblTurma = new System.Windows.Forms.Label();
			this.lblAluno = new System.Windows.Forms.Label();
			this.gboNotas = new System.Windows.Forms.GroupBox();
			this.txtNota4 = new System.Windows.Forms.TextBox();
			this.txtNota3 = new System.Windows.Forms.TextBox();
			this.txtNota2 = new System.Windows.Forms.TextBox();
			this.txtNota1 = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblNota4 = new System.Windows.Forms.Label();
			this.lblNota3 = new System.Windows.Forms.Label();
			this.lblNota2 = new System.Windows.Forms.Label();
			this.lblNota1 = new System.Windows.Forms.Label();
			this.gboAssiduidade = new System.Windows.Forms.GroupBox();
			this.nudFrequencia = new System.Windows.Forms.NumericUpDown();
			this.lblFrequencia = new System.Windows.Forms.Label();
			this.gboResultadosDiretos = new System.Windows.Forms.GroupBox();
			this.lblSituacao = new System.Windows.Forms.Label();
			this.lblMedia = new System.Windows.Forms.Label();
			this.gboListagemHistorico = new System.Windows.Forms.GroupBox();
			this.btnGerarResumo = new System.Windows.Forms.Button();
			this.txtResumoTurma = new System.Windows.Forms.TextBox();
			this.lblResumoTurma = new System.Windows.Forms.Label();
			this.lblQuantidade = new System.Windows.Forms.Label();
			this.btnRemover = new System.Windows.Forms.Button();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.lstResultados = new System.Windows.Forms.ListBox();
			this.btnLimparCampos = new System.Windows.Forms.Button();
			this.btnLimparLista = new System.Windows.Forms.Button();
			this.gboDadosAluno.SuspendLayout();
			this.gboNotas.SuspendLayout();
			this.gboAssiduidade.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudFrequencia)).BeginInit();
			this.gboResultadosDiretos.SuspendLayout();
			this.gboListagemHistorico.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblLançamentoNotas
			// 
			this.lblLançamentoNotas.AutoSize = true;
			this.lblLançamentoNotas.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLançamentoNotas.Location = new System.Drawing.Point(263, 9);
			this.lblLançamentoNotas.Name = "lblLançamentoNotas";
			this.lblLançamentoNotas.Size = new System.Drawing.Size(607, 40);
			this.lblLançamentoNotas.TabIndex = 0;
			this.lblLançamentoNotas.Text = "Sistema De Lançamento De Notas e Frequência";
			// 
			// gboDadosAluno
			// 
			this.gboDadosAluno.Controls.Add(this.txtTurma);
			this.gboDadosAluno.Controls.Add(this.txtAluno);
			this.gboDadosAluno.Controls.Add(this.lblTurma);
			this.gboDadosAluno.Controls.Add(this.lblAluno);
			this.gboDadosAluno.Location = new System.Drawing.Point(12, 69);
			this.gboDadosAluno.Name = "gboDadosAluno";
			this.gboDadosAluno.Size = new System.Drawing.Size(1157, 100);
			this.gboDadosAluno.TabIndex = 1;
			this.gboDadosAluno.TabStop = false;
			this.gboDadosAluno.Text = "Dados do Aluno";
			// 
			// txtTurma
			// 
			this.txtTurma.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTurma.Location = new System.Drawing.Point(900, 59);
			this.txtTurma.Name = "txtTurma";
			this.txtTurma.Size = new System.Drawing.Size(251, 30);
			this.txtTurma.TabIndex = 3;
			// 
			// txtAluno
			// 
			this.txtAluno.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAluno.Location = new System.Drawing.Point(168, 61);
			this.txtAluno.Name = "txtAluno";
			this.txtAluno.Size = new System.Drawing.Size(630, 30);
			this.txtAluno.TabIndex = 2;
			// 
			// lblTurma
			// 
			this.lblTurma.AutoSize = true;
			this.lblTurma.Location = new System.Drawing.Point(818, 59);
			this.lblTurma.Name = "lblTurma";
			this.lblTurma.Size = new System.Drawing.Size(76, 30);
			this.lblTurma.TabIndex = 1;
			this.lblTurma.Text = "Turma:";
			// 
			// lblAluno
			// 
			this.lblAluno.AutoSize = true;
			this.lblAluno.Location = new System.Drawing.Point(6, 61);
			this.lblAluno.Name = "lblAluno";
			this.lblAluno.Size = new System.Drawing.Size(156, 30);
			this.lblAluno.TabIndex = 0;
			this.lblAluno.Text = "Nome do Aluno:";
			// 
			// gboNotas
			// 
			this.gboNotas.Controls.Add(this.txtNota4);
			this.gboNotas.Controls.Add(this.txtNota3);
			this.gboNotas.Controls.Add(this.txtNota2);
			this.gboNotas.Controls.Add(this.txtNota1);
			this.gboNotas.Controls.Add(this.btnCalcular);
			this.gboNotas.Controls.Add(this.lblNota4);
			this.gboNotas.Controls.Add(this.lblNota3);
			this.gboNotas.Controls.Add(this.lblNota2);
			this.gboNotas.Controls.Add(this.lblNota1);
			this.gboNotas.Location = new System.Drawing.Point(16, 176);
			this.gboNotas.Name = "gboNotas";
			this.gboNotas.Size = new System.Drawing.Size(481, 288);
			this.gboNotas.TabIndex = 2;
			this.gboNotas.TabStop = false;
			this.gboNotas.Text = "Notas (0 a 10)";
			// 
			// txtNota4
			// 
			this.txtNota4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNota4.Location = new System.Drawing.Point(85, 200);
			this.txtNota4.Name = "txtNota4";
			this.txtNota4.Size = new System.Drawing.Size(384, 30);
			this.txtNota4.TabIndex = 8;
			// 
			// txtNota3
			// 
			this.txtNota3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNota3.Location = new System.Drawing.Point(85, 150);
			this.txtNota3.Name = "txtNota3";
			this.txtNota3.Size = new System.Drawing.Size(384, 30);
			this.txtNota3.TabIndex = 7;
			// 
			// txtNota2
			// 
			this.txtNota2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNota2.Location = new System.Drawing.Point(85, 105);
			this.txtNota2.Name = "txtNota2";
			this.txtNota2.Size = new System.Drawing.Size(384, 30);
			this.txtNota2.TabIndex = 6;
			// 
			// txtNota1
			// 
			this.txtNota1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNota1.Location = new System.Drawing.Point(91, 57);
			this.txtNota1.Name = "txtNota1";
			this.txtNota1.Size = new System.Drawing.Size(384, 30);
			this.txtNota1.TabIndex = 5;
			// 
			// btnCalcular
			// 
			this.btnCalcular.AutoSize = true;
			this.btnCalcular.Location = new System.Drawing.Point(204, 242);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(96, 40);
			this.btnCalcular.TabIndex = 4;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// lblNota4
			// 
			this.lblNota4.AutoSize = true;
			this.lblNota4.Location = new System.Drawing.Point(6, 200);
			this.lblNota4.Name = "lblNota4";
			this.lblNota4.Size = new System.Drawing.Size(73, 30);
			this.lblNota4.TabIndex = 3;
			this.lblNota4.Text = "Nota4:";
			// 
			// lblNota3
			// 
			this.lblNota3.AutoSize = true;
			this.lblNota3.Location = new System.Drawing.Point(6, 148);
			this.lblNota3.Name = "lblNota3";
			this.lblNota3.Size = new System.Drawing.Size(73, 30);
			this.lblNota3.TabIndex = 2;
			this.lblNota3.Text = "Nota3:";
			// 
			// lblNota2
			// 
			this.lblNota2.AutoSize = true;
			this.lblNota2.Location = new System.Drawing.Point(6, 103);
			this.lblNota2.Name = "lblNota2";
			this.lblNota2.Size = new System.Drawing.Size(73, 30);
			this.lblNota2.TabIndex = 1;
			this.lblNota2.Text = "Nota2:";
			// 
			// lblNota1
			// 
			this.lblNota1.AutoSize = true;
			this.lblNota1.Location = new System.Drawing.Point(6, 57);
			this.lblNota1.Name = "lblNota1";
			this.lblNota1.Size = new System.Drawing.Size(79, 30);
			this.lblNota1.TabIndex = 0;
			this.lblNota1.Text = "Nota 1:";
			// 
			// gboAssiduidade
			// 
			this.gboAssiduidade.Controls.Add(this.nudFrequencia);
			this.gboAssiduidade.Controls.Add(this.lblFrequencia);
			this.gboAssiduidade.Location = new System.Drawing.Point(529, 194);
			this.gboAssiduidade.Name = "gboAssiduidade";
			this.gboAssiduidade.Size = new System.Drawing.Size(639, 87);
			this.gboAssiduidade.TabIndex = 3;
			this.gboAssiduidade.TabStop = false;
			this.gboAssiduidade.Text = "Assiduidade";
			// 
			// nudFrequencia
			// 
			this.nudFrequencia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudFrequencia.Location = new System.Drawing.Point(170, 46);
			this.nudFrequencia.Name = "nudFrequencia";
			this.nudFrequencia.Size = new System.Drawing.Size(463, 30);
			this.nudFrequencia.TabIndex = 1;
			// 
			// lblFrequencia
			// 
			this.lblFrequencia.AutoSize = true;
			this.lblFrequencia.Location = new System.Drawing.Point(6, 46);
			this.lblFrequencia.Name = "lblFrequencia";
			this.lblFrequencia.Size = new System.Drawing.Size(158, 30);
			this.lblFrequencia.TabIndex = 0;
			this.lblFrequencia.Text = "Frequência (%):";
			// 
			// gboResultadosDiretos
			// 
			this.gboResultadosDiretos.Controls.Add(this.lblSituacao);
			this.gboResultadosDiretos.Controls.Add(this.lblMedia);
			this.gboResultadosDiretos.Location = new System.Drawing.Point(535, 302);
			this.gboResultadosDiretos.Name = "gboResultadosDiretos";
			this.gboResultadosDiretos.Size = new System.Drawing.Size(633, 161);
			this.gboResultadosDiretos.TabIndex = 4;
			this.gboResultadosDiretos.TabStop = false;
			this.gboResultadosDiretos.Text = "Resultados Diretos";
			// 
			// lblSituacao
			// 
			this.lblSituacao.AutoSize = true;
			this.lblSituacao.Location = new System.Drawing.Point(6, 116);
			this.lblSituacao.Name = "lblSituacao";
			this.lblSituacao.Size = new System.Drawing.Size(96, 30);
			this.lblSituacao.TabIndex = 1;
			this.lblSituacao.Text = "Situação:";
			// 
			// lblMedia
			// 
			this.lblMedia.AutoSize = true;
			this.lblMedia.Location = new System.Drawing.Point(6, 51);
			this.lblMedia.Name = "lblMedia";
			this.lblMedia.Size = new System.Drawing.Size(73, 30);
			this.lblMedia.TabIndex = 0;
			this.lblMedia.Text = "Média:";
			// 
			// gboListagemHistorico
			// 
			this.gboListagemHistorico.Controls.Add(this.btnGerarResumo);
			this.gboListagemHistorico.Controls.Add(this.txtResumoTurma);
			this.gboListagemHistorico.Controls.Add(this.lblResumoTurma);
			this.gboListagemHistorico.Controls.Add(this.lblQuantidade);
			this.gboListagemHistorico.Controls.Add(this.btnRemover);
			this.gboListagemHistorico.Controls.Add(this.btnAdicionar);
			this.gboListagemHistorico.Controls.Add(this.lstResultados);
			this.gboListagemHistorico.Location = new System.Drawing.Point(20, 479);
			this.gboListagemHistorico.Name = "gboListagemHistorico";
			this.gboListagemHistorico.Size = new System.Drawing.Size(1148, 221);
			this.gboListagemHistorico.TabIndex = 5;
			this.gboListagemHistorico.TabStop = false;
			this.gboListagemHistorico.Text = "Listagem e Histórico da Turma";
			// 
			// btnGerarResumo
			// 
			this.btnGerarResumo.AutoSize = true;
			this.btnGerarResumo.Location = new System.Drawing.Point(776, 175);
			this.btnGerarResumo.Name = "btnGerarResumo";
			this.btnGerarResumo.Size = new System.Drawing.Size(155, 40);
			this.btnGerarResumo.TabIndex = 6;
			this.btnGerarResumo.Text = "Gerar Resumo";
			this.btnGerarResumo.UseVisualStyleBackColor = true;
			this.btnGerarResumo.Click += new System.EventHandler(this.BtnGerarResumoClick);
			// 
			// txtResumoTurma
			// 
			this.txtResumoTurma.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResumoTurma.Location = new System.Drawing.Point(763, 113);
			this.txtResumoTurma.Name = "txtResumoTurma";
			this.txtResumoTurma.Size = new System.Drawing.Size(379, 30);
			this.txtResumoTurma.TabIndex = 5;
			// 
			// lblResumoTurma
			// 
			this.lblResumoTurma.AutoSize = true;
			this.lblResumoTurma.Location = new System.Drawing.Point(573, 113);
			this.lblResumoTurma.Name = "lblResumoTurma";
			this.lblResumoTurma.Size = new System.Drawing.Size(184, 30);
			this.lblResumoTurma.TabIndex = 4;
			this.lblResumoTurma.Text = "Resumo da Turma:";
			// 
			// lblQuantidade
			// 
			this.lblQuantidade.AutoSize = true;
			this.lblQuantidade.Location = new System.Drawing.Point(573, 45);
			this.lblQuantidade.Name = "lblQuantidade";
			this.lblQuantidade.Size = new System.Drawing.Size(157, 30);
			this.lblQuantidade.TabIndex = 3;
			this.lblQuantidade.Text = "Total de Alunos:";
			// 
			// btnRemover
			// 
			this.btnRemover.AutoSize = true;
			this.btnRemover.Location = new System.Drawing.Point(354, 181);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(123, 40);
			this.btnRemover.TabIndex = 2;
			this.btnRemover.Text = "- Remover";
			this.btnRemover.UseVisualStyleBackColor = true;
			this.btnRemover.Click += new System.EventHandler(this.BtnRemoverClick);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.AutoSize = true;
			this.btnAdicionar.Location = new System.Drawing.Point(6, 175);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(123, 40);
			this.btnAdicionar.TabIndex = 1;
			this.btnAdicionar.Text = "+ Adicionar";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionarClick);
			// 
			// lstResultados
			// 
			this.lstResultados.FormattingEnabled = true;
			this.lstResultados.ItemHeight = 30;
			this.lstResultados.Location = new System.Drawing.Point(6, 45);
			this.lstResultados.Name = "lstResultados";
			this.lstResultados.Size = new System.Drawing.Size(471, 124);
			this.lstResultados.TabIndex = 0;
			// 
			// btnLimparCampos
			// 
			this.btnLimparCampos.AutoSize = true;
			this.btnLimparCampos.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimparCampos.Location = new System.Drawing.Point(587, 706);
			this.btnLimparCampos.Name = "btnLimparCampos";
			this.btnLimparCampos.Size = new System.Drawing.Size(163, 40);
			this.btnLimparCampos.TabIndex = 7;
			this.btnLimparCampos.Text = "Limpar Campos";
			this.btnLimparCampos.UseVisualStyleBackColor = true;
			this.btnLimparCampos.Click += new System.EventHandler(this.BtnLimparCamposClick);
			// 
			// btnLimparLista
			// 
			this.btnLimparLista.AutoSize = true;
			this.btnLimparLista.Location = new System.Drawing.Point(1014, 699);
			this.btnLimparLista.Name = "btnLimparLista";
			this.btnLimparLista.Size = new System.Drawing.Size(155, 40);
			this.btnLimparLista.TabIndex = 8;
			this.btnLimparLista.Text = "Limpar Lista";
			this.btnLimparLista.UseVisualStyleBackColor = true;
			this.btnLimparLista.Click += new System.EventHandler(this.BtnLimparListaClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1181, 751);
			this.Controls.Add(this.btnLimparCampos);
			this.Controls.Add(this.btnLimparLista);
			this.Controls.Add(this.gboListagemHistorico);
			this.Controls.Add(this.gboResultadosDiretos);
			this.Controls.Add(this.gboAssiduidade);
			this.Controls.Add(this.gboNotas);
			this.Controls.Add(this.gboDadosAluno);
			this.Controls.Add(this.lblLançamentoNotas);
			this.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Atividade03 Boletim Escolar";
			this.gboDadosAluno.ResumeLayout(false);
			this.gboDadosAluno.PerformLayout();
			this.gboNotas.ResumeLayout(false);
			this.gboNotas.PerformLayout();
			this.gboAssiduidade.ResumeLayout(false);
			this.gboAssiduidade.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudFrequencia)).EndInit();
			this.gboResultadosDiretos.ResumeLayout(false);
			this.gboResultadosDiretos.PerformLayout();
			this.gboListagemHistorico.ResumeLayout(false);
			this.gboListagemHistorico.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
