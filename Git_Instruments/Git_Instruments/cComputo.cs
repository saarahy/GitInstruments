using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Instruments
{
    class cComputo:Producto
    {
        private string categoria;

        public string _categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        private string modelo;

        public string _modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }


    }
}
