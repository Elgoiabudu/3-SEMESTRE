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

namespace P2_TPII_CRUD_COMPLETO
{


    public partial class Clientes : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        string SQL, IDGlobal;

        public void popularDGV(string param)
        {
            try
            {
                if (param == "")
                {
                    SQL = "SELECT cpf as CPF, nome as NOME, celular as CELULAR, telefone as TELEFONE from Clientes";

                    using (SqlDataAdapter da = new SqlDataAdapter(SQL, conexao))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvClientes.DataSource = dt;
                        }
                    }
                }
                else
                {
                    SQL = $"SELECT cpf as CPF, nome as NOME, celular as CELULAR, telefone as TELEFONE from Clientes WHERE nome like '{param}%' ";

                    using (SqlDataAdapter da = new SqlDataAdapter(SQL, conexao))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvClientes.DataSource = dt;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }


        public bool VerificarCampos()
        {
            if (txtCPF.Text == "" ||
                txtNome.Text == "" ||
                txtTelefone.Text == "" ||
                txtCelular.Text == "" ||
                txtEmail.Text == "" ||
                txtCEP.Text == "" ||
                txtLogradouro.Text == "" ||
                txtBairro.Text == "" ||
                txtNumero.Text == "" ||
                txtCidade.Text == "" ||
                txtEstado.Text == "")
            {
                return false;
            }
            return true;
        }

        public Clientes()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            txtID.Clear();
            txtDataCad.Clear();
            txtCPF.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtCEP.Clear();
            txtLogradouro.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            btnSalvar.Text = "SALVAR";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSalvar.Text == "SALVAR")
                {
                    if (!VerificarCampos())
                    {
                        MessageBox.Show("Preencha todos os campos corretamente!", "ERRO",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SQL = "INSERT INTO Clientes " +
                              "(cpf, nome, telefone, celular, email, CEP, logradouro, bairro, numero, cidade, estado) " +
                              "VALUES " +
                              $"('{txtCPF.Text}', " +
                              $"'{txtNome.Text}', " +
                              $"'{txtTelefone.Text}', " +
                              $"'{txtCelular.Text}', " +
                              $"'{txtEmail.Text}', " +
                              $"'{txtCEP.Text}', " +
                              $"'{txtLogradouro.Text}', " +
                              $"'{txtBairro.Text}', " +
                              $"'{txtNumero.Text}', " +
                              $"'{txtCidade.Text}', " +
                              $"'{txtEstado.Text}');";
                        comando = new SqlCommand(SQL, conexao);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Dados Gravados Com Sucesso!", "SUCESSO",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                        txtCPF.Focus();
                        IDGlobal = "";
                        popularDGV("");
                    }
                }
                else
                {
                    if (VerificarCampos())
                    {
                        SQL = "UPDATE Clientes " +
                            "SET " +
                            $"cpf = '{txtCPF.Text}'," +
                            $"NOME = '{txtNome.Text}'," +
                            $"telefone = '{txtTelefone.Text}'," +
                            $"celular = '{txtCelular.Text}'," +
                            $"email = '{txtEmail.Text}'," +
                            $"CEP = '{txtCEP.Text}'," +
                            $"logradouro = '{txtLogradouro.Text}'," +
                            $"bairro = '{txtBairro.Text}'," +
                            $"cidade = '{txtCidade.Text}'," +
                            $"numero = '{txtNumero.Text}'," +
                            $"estado = '{txtEstado.Text}'" +
                            $"WHERE ID = {IDGlobal}";

                        comando = new SqlCommand(SQL, conexao);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Dados Atualizados Com Sucesso!", "SUCESSO",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSalvar.Text = "SALVAR";
                        LimparCampos();
                        IDGlobal = "";
                        popularDGV("");
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os campos corretamente!", "ERRO",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCEP.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(txtCEP.Text.Trim());
                        txtLogradouro.Text = endereco.end;
                        txtBairro.Text = endereco.bairro;
                        txtCidade.Text = endereco.cidade;
                        txtEstado.Text = endereco.uf;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "ERRO NO CEP", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCEP.Clear();
                        txtLogradouro.Clear();
                        txtBairro.Clear();
                        txtCidade.Clear();
                        txtEstado.Clear();
                        txtCEP.Focus();
                    }

                }
            }
            else
            {
                MessageBox.Show("CEP INVÁLIDO.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            IDGlobal = "";

            conexao = new SqlConnection(@"Server=NITRO-PC\SQLEXPRESS;
                                        Database=P2_TP2;
                                        trusted_connection=yes");
            conexao.Open();

            popularDGV("");
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (IDGlobal == "")
            {
                MessageBox.Show("Nenhum Registro Selecionado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Deseja Continuar com a Exclusão?",
                    this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SQL = $"DELETE FROM Clientes WHERE ID = {IDGlobal}";
                    comando = new SqlCommand(SQL, conexao);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Dados Apagados Com Sucesso!", "SUCESSO",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    btnSalvar.Text = "SALVAR";
                    IDGlobal = "";
                    txtCPF.Focus();
                    popularDGV("");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtCPF.Focus();
            IDGlobal = "";
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvClientes.Rows[e.RowIndex].Cells[0].Value;

            SQL = $"SELECT * FROM Clientes WHERE cpf = '{id}'";

            using (SqlCommand cmd = new SqlCommand(SQL, conexao))
            {
                using (SqlDataReader leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        btnSalvar.Text = "ATUALIZAR";
                        IDGlobal = leitor["ID"].ToString();
                        txtCPF.Text = leitor["cpf"].ToString();
                        txtID.Text = leitor["ID"].ToString();
                        txtDataCad.Text = leitor["dataCadastro"].ToString();
                        txtNome.Text = leitor["nome"].ToString();
                        txtTelefone.Text = leitor["telefone"].ToString();
                        txtCelular.Text = leitor["celular"].ToString();
                        txtEmail.Text = leitor["email"].ToString();
                        txtCEP.Text = leitor["CEP"].ToString();
                        txtLogradouro.Text = leitor["logradouro"].ToString();
                        txtBairro.Text = leitor["bairro"].ToString();
                        txtNumero.Text = leitor["numero"].ToString();
                        txtCidade.Text = leitor["cidade"].ToString();
                        txtEstado.Text = leitor["estado"].ToString();
                    }
                }
            }
        }

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {
            popularDGV(txtPesq.Text);
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            try
            {
                SQL = $"SELECT * FROM Clientes WHERE cpf = '{txtCPF.Text}'";

                using (SqlCommand comando = new SqlCommand(SQL, conexao))
                {
                    using (SqlDataReader leitor = comando.ExecuteReader())
                    {
                        if (leitor.Read())
                        {
                            btnSalvar.Text = "ATUALIZAR";
                            IDGlobal = leitor["ID"].ToString();
                            txtID.Text = leitor["ID"].ToString();
                            txtDataCad.Text = leitor["dataCadastro"].ToString();
                            txtNome.Text = leitor["nome"].ToString();
                            txtTelefone.Text = leitor["telefone"].ToString();
                            txtCelular.Text = leitor["celular"].ToString();
                            txtEmail.Text = leitor["email"].ToString();
                            txtCEP.Text = leitor["CEP"].ToString();
                            txtLogradouro.Text = leitor["logradouro"].ToString();
                            txtBairro.Text = leitor["bairro"].ToString();
                            txtNumero.Text = leitor["numero"].ToString();
                            txtCidade.Text = leitor["cidade"].ToString();
                            txtEstado.Text = leitor["estado"].ToString();
                        }
                        else
                        {
                            txtID.Clear();
                            txtDataCad.Clear();
                            txtNome.Clear();
                            txtTelefone.Clear();
                            txtCelular.Clear();
                            txtEmail.Clear();
                            txtCEP.Clear();
                            txtLogradouro.Clear();
                            txtBairro.Clear();
                            txtNumero.Clear();
                            txtCidade.Clear();
                            txtEstado.Clear();
                            btnSalvar.Text = "SALVAR";
                            IDGlobal = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "ERRO NO LEAVE", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
    }
}
