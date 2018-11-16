using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Instruments
{
    class cPapeles:Producto
    {
        private string tipo;
        private string color;
        private string tamano;

        public string _tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string _color
        {
            get { return color; }
            set { color = value; }
        }
        public string _tamano
        {
            get { return tamano; }
            set { tamano = value; }
        }
    }
}
