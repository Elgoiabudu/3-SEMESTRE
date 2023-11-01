using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace CadastroComClasse
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        public Cliente(string nome, string telefone, string email, string endereco)
        {            
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
        }

        public Cliente()
        {

        }
        public string retornaJson()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            Cliente cliente = new Cliente(Nome, Telefone, Email, Endereco);

            dynamic resultato = serializer.Serialize(cliente);

            return resultato.ToString();
        }
    }
}
