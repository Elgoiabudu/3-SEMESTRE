using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudNovo
{
    public partial class Form1 : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        string SQL;

        public Form1()
        {
            InitializeComponent();
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

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf = txt_CPF.Text;

                string consultaSQL = "SELECT * FROM tb_cadastro WHERE cpf ='" + cpf + "'"; // Substitua isso pela sua consulta SQL.

                using (SqlCommand command = new SqlCommand(consultaSQL, conexao))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("CPF Já Cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
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
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao Gravar o Registro!", "ERRO",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_CPF_Leave(object sender, EventArgs e)
        {
            string cpf = txt_CPF.Text;

            string consultaSQL = "SELECT * FROM tb_cadastro WHERE cpf ='"+cpf+"'"; // Substitua isso pela sua consulta SQL.

            using (SqlCommand command = new SqlCommand(consultaSQL, conexao))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string resultado = reader["nome"].ToString(); // Substitua "Nome" pelo nome da coluna desejada.
                        txt_nome.Text = resultado; // Exibindo o resultado em uma caixa de texto.
                    }
                    else
                    {
                        MessageBox.Show("Nenhum resultado encontrado.");
                    }
                }
            }

        }
    }
}
