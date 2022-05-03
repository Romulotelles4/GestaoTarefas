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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }


        private void btnContatos_Click(object sender, EventArgs e)
        {
            ListagemContatos novaListagemContatos = new ListagemContatos();

            novaListagemContatos.ShowDialog();
        }

        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            ListagemCompromissos novaListagemCompromissos = new ListagemCompromissos();

            novaListagemCompromissos.ShowDialog();
        }

        private void btnTarefa_Click_1(object sender, EventArgs e)
        {
            ListagemTarefas novaListagemTarefas = new ListagemTarefas();

            novaListagemTarefas.ShowDialog();
        }
    }
}
