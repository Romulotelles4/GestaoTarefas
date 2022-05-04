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
    public partial class ListagemContatos : Form
    {
        private RepositorioContato repositorioContato;
        public ListagemContatos()
        {
            repositorioContato = new RepositorioContato();
            InitializeComponent();
            CarregarContatos();

        }

        public void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodosOsContatos();

            listContatos.Items.Clear();

            foreach (Contato numero in contatos)
            {
                listContatos.Items.Add(numero);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroContatos cadastroContatos = new CadastroContatos();
            cadastroContatos.Contato = new Contato();

            DialogResult resultado = cadastroContatos.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Inserir(cadastroContatos.Contato);
                CarregarContatos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                    "Edição de contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            CadastroContatos tela = new CadastroContatos();

            tela.Contato = contatoSelecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Editar(tela.Contato);
                CarregarContatos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if(contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                    "Edição de contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir este contato?",
                   "Exclusão de contatos", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if(resultado == DialogResult.OK)
            {
                repositorioContato.Excluir(contatoSelecionado);
                CarregarContatos();
            }
        }

        
        
       



    }
}