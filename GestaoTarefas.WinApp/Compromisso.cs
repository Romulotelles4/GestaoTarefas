using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.WinApp
{
    public class Compromisso
    {
        public Compromisso()
        {

        }
        public Compromisso(string a, string l, DateTime d, int hi, int ht) : this()
        {
            Assunto = a;
            Local = l;
            Data = d;
            HoraInicio = hi;
            HoraTermino = ht;
        }

        public string Assunto { get; set;}
        public string Local { get; set;}
        public DateTime Data { get; set;}   
        public int HoraInicio { get; set;}  
        public int HoraTermino { get; set;}

        public override string ToString()
        {
            return $"Assunto: {Assunto}, Local: {Local}, Data: {Data}, Horário de início:`{HoraInicio}, Horário de término: {HoraTermino}."  ;
        }
    }
}

