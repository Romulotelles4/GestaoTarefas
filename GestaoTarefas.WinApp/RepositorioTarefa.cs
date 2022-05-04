﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace GestaoTarefas.WinApp
{
    public class RepositorioTarefa
    {
        private const string arquivoTarefas = @"\temp\tarefas.";
        List<Tarefa> tarefas;
        private int contador=0;
        public RepositorioTarefa()
        {
            tarefas = CarregarTarefasDoArquivo();

            if(tarefas.Count > 0)
            contador = tarefas.Max(x => x.Numero);
        }

        public List<Tarefa> SelecionarTodos()
        {

            return tarefas;
        }

        

        public void Inserir(Tarefa novaTarefa)
        {
            novaTarefa.Numero = ++contador;
            tarefas.Add(novaTarefa);

            GravarTarefasEmArquivo();

        }

       
        public void Editar(Tarefa tarefa)
        {
            
            foreach (var item in tarefas)
            {
                if (item.Numero == tarefa.Numero)
                {
                    item.Titulo = tarefa.Titulo;
                    break;
                }
            }
            GravarTarefasEmArquivo();
        }

        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
            GravarTarefasEmArquivo();
        }

        public void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
            foreach (var item in itens)
            {
                tarefaSelecionada.AdicionarItem(item);
            }
            GravarTarefasEmArquivo();
        }

        public void AtualizarItens(Tarefa tarefaSelecionada, 
            List<ItemTarefa> itensConcluidos, List<ItemTarefa> itensPendentes)
        {
            foreach (var item in itensConcluidos)
            {
                tarefaSelecionada.ConcluirItem(item);
            }

            foreach (var item in itensPendentes)
            {
                tarefaSelecionada.MarcarPendente(item);
            }
            GravarTarefasEmArquivo();
        }
        private void GravarTarefasEmArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream ms = new MemoryStream();

            serializador.Serialize(ms, tarefas);

            byte[] bytesTarefas = ms.ToArray();

            File.WriteAllBytes(arquivoTarefas, bytesTarefas);
        }
        private List<Tarefa> CarregarTarefasDoArquivo()
        {
            if(File.Exists(arquivoTarefas) == false)
                return new List<Tarefa>();

            BinaryFormatter serializador = new BinaryFormatter();
            byte[] bytesTarefas = File.ReadAllBytes(arquivoTarefas);

            MemoryStream ms = new MemoryStream(bytesTarefas);

            return (List<Tarefa>)serializador.Deserialize(ms);
        }

    }
}
