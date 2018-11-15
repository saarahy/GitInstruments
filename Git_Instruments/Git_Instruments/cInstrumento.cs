using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuInstrumento
{
    public class cInstrumento
    {
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private double Precio;
        public double precio
        {
            get { return Precio; }
            set { Precio = value; }
        }
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
