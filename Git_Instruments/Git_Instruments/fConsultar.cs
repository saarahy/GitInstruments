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
    public partial class fConsultar : Form
    {
        public fConsultar()
        {
            InitializeComponent();
        }
        List<cInstrumento> LI;
        public List<cInstrumento> _LI
        {
            get { return LI; }
            set { LI = value; }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codBuscar = Convert.ToInt32(txtCodigo.Text);
            foreach (cInstrumento ins in LI)
            {
                if (ins.Codigo == codBuscar)
                {
                    txtNombre.Text = ins.Nombre;
                    txtMarca.Text = ins.Marca;
                    txtPrecio.Text = ins.precio.ToString();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
