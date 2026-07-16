using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Atividade_05_Cadastro_de_clientes
{
	
	public partial class MainForm : Form
	{
		public MainForm()	
		{
			
			InitializeComponent();
			
			
		}
		
         MySqlConnection conexao = new MySqlConnection(
        "server=localhost;database=ds_cadastro_clientes;uid=root;pwd=;");
		
		void btnSalvar_Click(object sender, EventArgs e)
{
    try
    {
        conexao.Open();

        string sql = @"INSERT INTO clientes
        (nome, cpf, email, telefone, cidade, ativo)
        VALUES
        (@nome,@cpf,@email,@telefone,@cidade,@ativo)";

        MySqlCommand cmd = new MySqlCommand(sql, conexao);

        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
        cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
        cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
        cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
        cmd.Parameters.AddWithValue("@ativo", chkAtivo.Checked);

        cmd.ExecuteNonQuery();

        MessageBox.Show("Cliente cadastrado com sucesso!");
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
    finally
    {
        conexao.Close();
    }
}
		void btnEditar_Click(object sender, EventArgs e)
{
    try
    {
        conexao.Open();

        string sql = @"UPDATE clientes SET
        nome=@nome,
        cpf=@cpf,
        email=@email,
        telefone=@telefone,
        cidade=@cidade,
        ativo=@ativo
        WHERE id=@id";

        MySqlCommand cmd = new MySqlCommand(sql, conexao);

        cmd.Parameters.AddWithValue("@id", txtId.Text);
        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
        cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
        cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
        cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
        cmd.Parameters.AddWithValue("@ativo", chkAtivo.Checked);

        cmd.ExecuteNonQuery();

        MessageBox.Show("Cliente atualizado!");
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
    finally
    {
        conexao.Close();
    }
}
		 void btnExcluir_Click(object sender, EventArgs e)
{
    try
    {
        conexao.Open();

        string sql = "DELETE FROM clientes WHERE id=@id";

        MySqlCommand cmd = new MySqlCommand(sql, conexao);
        cmd.Parameters.AddWithValue("@id", txtId.Text);

        cmd.ExecuteNonQuery();

        MessageBox.Show("Cliente excluído!");
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
    finally
    {
        conexao.Close();
    }
}
		void btnPesquisar_Click(object sender, EventArgs e)
{
    try
    {
        conexao.Open();

        string sql = "SELECT * FROM clientes WHERE nome LIKE @nome";

        MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);
        da.SelectCommand.Parameters.AddWithValue("@nome", "%" + txtPesquisar.Text + "%");

        DataTable dt = new DataTable();

        da.Fill(dt);

        dgvClientes.DataSource = dt;
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
    finally
    {
        conexao.Close();
    }
}
		void btnMostrarTodos_Click(object sender, EventArgs e)
{
    try
    {
        conexao.Open();

        string sql = "SELECT * FROM clientes";

        MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);

        DataTable dt = new DataTable();

        da.Fill(dt);

        dgvClientes.DataSource = dt;
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
    finally
    {
        conexao.Close();
    }
}
		void btnAtivarDesativar_Click(object sender, EventArgs e)
{
    try
    {
        conexao.Open();

        string sql = "UPDATE clientes SET ativo=@ativo WHERE id=@id";

        MySqlCommand cmd = new MySqlCommand(sql, conexao);

        cmd.Parameters.AddWithValue("@id", txtId.Text);
        cmd.Parameters.AddWithValue("@ativo", !chkAtivo.Checked);

        cmd.ExecuteNonQuery();

        chkAtivo.Checked = !chkAtivo.Checked;

        MessageBox.Show("Status alterado!");
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
    finally
    {
        conexao.Close();
    }
}
		void btnNovo_Click(object sender, EventArgs e)
{
	txtId.Clear();
    txtNome.Clear();
    txtCPF.Clear();
    txtEmail.Clear();
    txtTelefone.Clear();
    txtCidade.Clear();

    chkAtivo.Checked = true;

    txtNome.Focus();
}
		void btnCancelar_Click(object sender, EventArgs e)
{
	txtId.Clear();
    txtNome.Clear();
    txtCPF.Clear();
    txtEmail.Clear();
    txtTelefone.Clear();
    txtCidade.Clear();
    txtPesquisar.Clear();

    chkAtivo.Checked = false;
}
    }
}