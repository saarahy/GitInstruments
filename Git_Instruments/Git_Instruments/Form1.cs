using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuInstrumento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Creamos la lista  de instrumentos
        public List<cInstrumento> ListaInstrumento = new List<cInstrumento>();
        public void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAgregar nueva = new fAgregar();
            nueva._LI = ListaInstrumento;
            nueva.ShowDialog();
            ListaInstrumento = nueva._LI;
        }

        private void listaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fConsultaTodos nueva = new fConsultaTodos();
            nueva._LI = ListaInstrumento;
            nueva.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fEliminar nueva = new fEliminar();
            nueva._LI = ListaInstrumento;
            nueva.ShowDialog();
            ListaInstrumento = nueva._LI;
        }

        private void instrumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fConsultar nueva = new fConsultar();
            nueva._LI = ListaInstrumento;
            nueva.ShowDialog();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fConsultarMarca nueva = new fConsultarMarca();
            nueva._LI = ListaInstrumento;
            nueva.ShowDialog();
        }
    }
}
