using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.WinApp
{
    public class RepositorioContato
    {
        List<Contato> contatos;

        public List<Contato> SelecionarTodos()
        {
            return contatos;
        }

        public void Inserir(Contato novoContato)
        {
            contatos.Add(novoContato);
        }
    }
}
