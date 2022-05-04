using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.WinApp
{
    public class RepositorioContato
    {
        private const string arquivoContatos = @"\temp\contatos.";
        List<Contato> contatos;
        private int contador = 0;
        public RepositorioContato()
        {
            contatos = CarregarContatosDoArquivo();

            if (contatos.Count > 0)
                contador = contatos.Max(x => x.Numero);
        }

        public List<Contato> SelecionarTodos()
        {
            return contatos;
        }

        public void Inserir(Contato novoContato)
        {
            novoContato.Numero = ++contador;
            contatos.Add(novoContato);
            GravarContatosEmArquivo();
        }
        public void Editar(Contato contato)
        {
            foreach (var item in contatos)
            {
                if (item.Numero == contato.Numero)
                {
                    item.Nome = contato.Nome;
                    item.Telefone = contato.Telefone;
                    item.Email = contato.Email;
                    item.Empresa = contato.Empresa;
                    item.Cargo = contato.Cargo;
                    break;
                }
            }
            GravarContatosEmArquivo();
        }

        public void Excluir(Contato contato)
        {
            contatos.Remove(contato);
            GravarContatosEmArquivo();
        }
        
        private void Vizualizar(Contato contato)
        {
            
        }

        public List<Contato> SelecionarTodosOsContatos()
        {
            contatos = CarregarContatosDoArquivo();
            return contatos;
        }

        private void GravarContatosEmArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream ms = new MemoryStream();

            serializador.Serialize(ms, contatos);

            byte[] bytesContatos = ms.ToArray();

            File.WriteAllBytes(arquivoContatos, bytesContatos);
        }
        private List<Contato> CarregarContatosDoArquivo()
        {
            if (File.Exists(arquivoContatos) == false)
                return new List<Contato>();

            BinaryFormatter serializador = new BinaryFormatter();
            byte[] bytesTarefas = File.ReadAllBytes(arquivoContatos);

            MemoryStream ms = new MemoryStream(bytesTarefas);

            return (List<Contato>)serializador.Deserialize(ms);
        }
    }
}
