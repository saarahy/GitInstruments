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
    public partial class fEliminar : Form
    {
        public fEliminar()
        {
            InitializeComponent();
            
        }

        List<cInstrumento> LI;
        public List<cInstrumento> _LI
        {
            get { return LI; }
            set { LI = value; }
        }

        int cod_;
        bool find = false;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cod_ = Convert.ToInt32(txtCodigo.Text);
            
            foreach (cInstrumento ins in LI)
            {
                if (ins.Codigo == cod_)
                {
                    txtNombre.Text = ins.Nombre;
                    txtMarca.Text = ins.Marca;
                    txtPrecio.Text = ins.precio.ToString();
                    find = true;
                }
            }
            if (find)
                btnEliminar.Visible = true;
            else
            {
                MessageBox.Show("Elemento no encontrado",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LI.RemoveAll(ins => ins.Codigo == cod_);
            MessageBox.Show("elemento eliminado exitosamente");
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtPrecio.Text = "";

        }

        private void fEliminar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            fConsultaTodos nueva = new fConsultaTodos();
            nueva._LI = LI;
            nueva.ShowDialog();
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if (txtCodigo.Text != String.Empty)
            {
                btnConsulta.PerformClick();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                //aqui codigo
                //btnConsulta.PerformClick();
                btnBuscar.PerformClick();
            }
        }
    }
}
