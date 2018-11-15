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
    public partial class fConsultaTodos : Form
    {
        public fConsultaTodos()
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
            dtvDatosIns.DataSource = LI;
        }
    }
}
