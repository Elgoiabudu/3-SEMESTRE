using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrimeiroProjetoC_
{
    public partial class Form1 : Form
    {
        //Declarando as variáveis locais.
        SqlConnection conexao;
        SqlCommand comando;
        string SQL;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexao = new SqlConnection(@"Server=LAB5-13;
                                        Database=cadastroMagno;
                                        trusted_connection=yes");

            try
            {
                conexao.Open();
                MessageBox.Show("Conexão Bem Magna!", "AVISO",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Conexão Não Magna!", "AVISO",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsb_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                SQL = "INSERT INTO tb_cadastro(cpf, nome) values (@CPF, @NOME)";
                comando = new SqlCommand(SQL, conexao);
                comando.Parameters.AddWithValue("@CPF", txt_CPF.Text);
                comando.Parameters.AddWithValue("@NOME", txt_nome.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados Gravados Com Sucesso!", "SUCESSO",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_CPF.Clear();
                txt_nome.Clear();
                txt_CPF.Focus();
            }
            catch
            {
                MessageBox.Show("Erro ao Gravar o Registro!", "ERRO",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsb_apagar_Click(object sender, EventArgs e)
        {

        }

        private void tsb_salvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                SQL = "INSERT INTO tb_cadastro(cpf, nome) values (@CPF, @NOME)";
                comando = new SqlCommand(SQL, conexao);
                comando.Parameters.AddWithValue("@CPF", txt_CPF.Text);
                comando.Parameters.AddWithValue("@NOME", txt_nome.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados Gravados Com Sucesso!", "SUCESSO",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_CPF.Clear();
                txt_nome.Clear();
                txt_CPF.Focus();
            }
            catch
            {
                MessageBox.Show("Erro ao Gravar o Registro!", "ERRO",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}
