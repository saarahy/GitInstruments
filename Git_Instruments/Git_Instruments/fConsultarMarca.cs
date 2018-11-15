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
    public partial class fConsultarMarca : Form
    {
        public fConsultarMarca()
        {
            InitializeComponent();
        }
        List<cInstrumento> LI;
        public List<cInstrumento> _LI
        {
            get { return LI; }
            set { LI = value; }
        }

        private void fConsultarMarca_Load(object sender, EventArgs e)
        {

            var MarcasDistintas = LI.GroupBy(x => x.Marca).Select(y => y.First());

              foreach (var ins in MarcasDistintas)
              {
                  cmbMarcas.Items.Add(ins.Marca);
              }
        }

        private void cmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtListaMarcas.Text = "";
            int codBuscar = cmbMarcas.SelectedIndex;
            string marca = cmbMarcas.Items[codBuscar].ToString();
            foreach (cInstrumento ins in LI)
            {
                if (ins.Marca == marca)
                {
                    txtListaMarcas.Text += "Nombre: " + ins.Nombre 
                        + " Marca:" + ins.Marca + " Precio: " 
                        + ins.precio + "\t\n";
                    /*lvMarcas.Items.Add(ins.Nombre);
                    lvMarcas.Items.Add(ins.Marca);
                    lvMarcas.Items.Add(ins.precio.ToString());*/
                }
            }
        }
        
    }
}
