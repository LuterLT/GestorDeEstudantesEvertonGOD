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
    public partial class FormEstatisticas : Form
    {
        public FormEstatisticas()
        {
            InitializeComponent();
        }

        private void labelMeninos_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalEstudantes_Click(object sender, EventArgs e)
        {

        }

        private void labelMeninas_Click(object sender, EventArgs e)
        {

        }

        Color corPainelTotal;
        Color corPainelMeninos;
        Color corPainelMeninas;

        private void FormEstatisticas_Load(object sender, EventArgs e)
        {
            corPainelTotal = panelTotalEstudantes.BackColor;
            corPainelMeninos = panelMeninos.BackColor;
            corPainelMeninas = panelMeninas.BackColor;
        }

        private void panelTotalEstudantes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMeninos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMeninas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTotalEstudantes_MouseEnter(object sender, EventArgs e)
        {
            //mouse enter
            panelTotalEstudantes.BackColor = Color.DarkBlue;
        }

        private void panelTotalEstudantes_MouseLeave(object sender, EventArgs e)
        {
            //mouse leave
            panelTotalEstudantes.BackColor = corPainelTotal;
        }

        private void panelMeninos_MouseEnter(object sender, EventArgs e)
        {
            //mouse enter
            panelMeninos.BackColor = Color.DarkBlue;
        }

        private void panelMeninos_MouseLeave(object sender, EventArgs e)
        {
            //mouse leave
            panelMeninos.BackColor = corPainelMeninos;
        }

        private void panelMeninas_MouseEnter(object sender, EventArgs e)
        {
            //mouse enter
            panelMeninas.BackColor = Color.DarkBlue;
        }

        private void panelMeninas_MouseLeave(object sender, EventArgs e)
        {
            //mouse leave
            panelMeninas.BackColor = corPainelMeninas;
        }
    }
}
