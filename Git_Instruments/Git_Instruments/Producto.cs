using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Instruments
{
    class Producto
    {
        private double precio;
        private long codigo;
        private string marca;
        private string nombre;
        private string classproducto;

        protected string _classprodcuto
        {
            get { return classproducto; }
            set { classproducto = value; }
        }
        private int numproducto;

        protected int _numproducto
        {
            get { return numproducto; }
            set { numproducto = value; }
        }
        private long codigobarra;

        protected long _codigobarra
        {
            get { return codigobarra; }
            set { codigobarra = value; }
        }

        protected double _precio
        {
            get { return precio; }
            set { precio = value; }
        }
        protected long _codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        protected string _marca
        {
            get { return marca; }
            set { marca = value; }
        }
        protected string _nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
