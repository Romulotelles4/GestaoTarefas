﻿using System;
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
        public ListagemContatos()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroContatos cadastroContatos = new CadastroContatos();

            cadastroContatos.ShowDialog();
        }
    }
}