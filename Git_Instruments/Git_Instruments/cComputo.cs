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
        private string modelo;

        public string _categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
      
        public string _modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        //Metodo para almacenar equipo de computo
        public void almacenarUtensilios(string pNombre, string pMarca, long pCodigoBarra,
           double pPrecio, long pCodigo, string pClassProducto,
          int pNumProducto, bool pCaducidad,
          string pCategoria, string pModelo)
        {
            almacenar(pNombre, pMarca, pCodigoBarra, pPrecio, pCodigo, pClassProducto,
                pNumProducto, pCaducidad);
            _categoria = pCategoria;
            _modelo = pModelo; 
        }

    }
}
