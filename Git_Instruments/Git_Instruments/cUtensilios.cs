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
        //Metodo para almacenar utensilios
        public void almacenarUtensilios(string pNombre, string pMarca, long pCodigoBarra,
           double pPrecio, long pCodigo, string pClassProducto,
          int pNumProducto, bool pCaducidad,
          string pCategoria, double pPeso, string pMaterial)
        {
            almacenar(pNombre, pMarca, pCodigoBarra, pPrecio, pCodigo, pClassProducto,
                pNumProducto, pCaducidad);
            _categoria = pCategoria;
            _peso = pPeso;
            _material = pMaterial;
        }
    }
}
