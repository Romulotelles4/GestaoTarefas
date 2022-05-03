using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class CadastroContatos : Form
    {
        private Contato contato;
        public CadastroContatos()
        {
            InitializeComponent();
        }

        public Contato Contato
        {
            get { return contato; }

            set 
            { 
                contato = value; 
                textNome.Text = contato.Nome;
                textEmail.Text = contato.Email;
                textTelefone.Text = contato.Telefone;
                textEmpresa.Text = contato.Empresa;
                textCargo.Text = contato.Cargo;
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            contato.Nome = textNome.Text;
        }

    }
}
