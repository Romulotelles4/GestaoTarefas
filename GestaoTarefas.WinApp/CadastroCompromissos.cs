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
    public partial class CadastroCompromissos : Form
    {
        private Compromisso compromisso;
        public CadastroCompromissos()
        {
            InitializeComponent();
        }

        public Compromisso Compromisso
        {
            get { return compromisso; }

            set
            {
                compromisso = value;
                textAssunto.Text = compromisso.Assunto;
                textLocal.Text = compromisso.Local;
                //textData.Text = compromisso.Data.;
                textHorarioInicio.Text = compromisso.HoraInicio.ToString();
                textHorariotermino.Text = compromisso.HoraTermino.ToString();   

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            compromisso.Assunto = textAssunto.Text;
            compromisso.Local = textAssunto.Text;
            


        }
    }
}
