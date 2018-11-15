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
    public partial class fAgregar : Form
    {
        
        public fAgregar()
        {
            InitializeComponent();
        }
        List<cInstrumento> LI;
        public List<cInstrumento> _LI
        {
            get { return LI; }
            set { LI = value; }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cInstrumento nuevo = new cInstrumento();
            //codigo
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            //nombre
            nuevo.Nombre = txtNombre.Text.ToUpper();
            //marca
            nuevo.Marca = txtMarca.Text.ToUpper();
            //precio
            nuevo.precio = Convert.ToDouble(txtPrecio.Text);
            LI.Add(nuevo);
            MessageBox.Show("Elemento agregado correctamente");
            txtPrecio.Text = "";
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtCodigo.Text = "";
        }
    }
}
