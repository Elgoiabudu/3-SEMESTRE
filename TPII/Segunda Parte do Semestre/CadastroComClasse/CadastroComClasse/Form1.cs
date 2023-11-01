using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroComClasse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerial_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtNome.Text, txtFone.Text, txtEmail.Text, txtEndereco.Text);
            var retorno = cliente.retornaJson();

            MessageBox.Show(retorno.ToString());
        }
    }
}
