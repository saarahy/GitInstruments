using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Instruments
{
    class cUtensilios:Producto
    {
        private string categoria;
        private double peso;
        private string material;

        public string _categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public double _peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public string _material
        {
            get { return material; }
            set { material = value; }
        }
    }
}
