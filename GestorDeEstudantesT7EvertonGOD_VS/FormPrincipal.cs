using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7EvertonGOD_VS
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void estudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoEstudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInserirEstudante formInserirEstudante = new FormInserirEstudante();
            formInserirEstudante.Show(this);
        }

        private void listaDeEstudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarEstudante formListarEstudante = new FormListarEstudante();
            formListarEstudante.Show(this);  
        }

        private void estatísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstatisticas formEstatisticas = new FormEstatisticas();
            formEstatisticas.Show(this);
        }

        private void editarRemoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAtualizarApagarEstudantes atualizarApagarEstudantes = new FormAtualizarApagarEstudantes();
            atualizarApagarEstudantes.Show(this);
        }

        private void gerenciarEstudantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerenciarEstudantes formGerenciarEstudantes = new FormGerenciarEstudantes();
            formGerenciarEstudantes.Show(this);
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
