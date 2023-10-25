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

namespace P2_TPII_CRUD_COMPLETO
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
            conexao = new SqlConnection(@"Server=NITRO-PC\SQLEXPRESS;
                                        Database=P2_TP2;
                                        trusted_connection=yes");

            try
            {
                conexao.Open();                
                lblConex.ForeColor = Color.Green;
            }
            catch
            {
                MessageBox.Show("Impossível se Conectar!", "ERRO",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);                
                lblConex.ForeColor = Color.Red;
                this.Close();
            }
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes formCli = new Clientes();
            formCli.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
