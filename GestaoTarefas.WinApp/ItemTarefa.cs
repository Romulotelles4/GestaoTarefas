using System;

namespace GestaoTarefas.WinApp
{
   [Serializable]
    public class ItemTarefa
    {
        public string Titulo { get; internal set; }
        
        public bool Concluido { get; private set; }

        public override string ToString()
        {
            return Titulo;
        }

        public void Concluir()
        {
            Concluido = true;
        }

        internal void MarcarPendente()
        {
            Concluido = false;
        }
    }
}
