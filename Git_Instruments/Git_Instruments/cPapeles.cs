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
        //Declaracion del metodo almacenar
        public void almacenarPapel(string pNombre, string pMarca, long pCodigoBarra, 
            double pPrecio, long pCodigo,string  pClassProducto,
           int pNumProducto, bool pCaducidad,
           string pTipo, string pColor, string pTamano)
        {
            almacenar(pNombre, pMarca, pCodigoBarra, pPrecio, pCodigo, pClassProducto,
                pNumProducto, pCaducidad);
            _tipo = pTipo;
            _color = pColor;
            _tamano = pTamano;
        }
    }
}
