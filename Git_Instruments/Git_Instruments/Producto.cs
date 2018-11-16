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
        private bool caducidad;
        private int numproducto; //cantidad
        private long codigobarra;

        protected string _classprodcuto
        {
            get { return classproducto; }
            set { classproducto = value; }
        }
        protected int _numproducto
        {
            get { return numproducto; }
            set { numproducto = value; }
        }
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
        protected bool _caducidad
        {
            get { return caducidad; }
            set { caducidad = value; }
        }

        //Metodos de la clase producto que 
        //heredaran las clases hijas
        //Metodo almacenar
        protected void almacenar(string pNombre, string pMarca,
            long pCodigoBarra, double pPrecio, long pCodigo, 
            string pClassProducto, int pNumProducto, bool pCaducidad)
        {
            _nombre = pNombre;
            _marca = pMarca;
            _codigobarra = pCodigoBarra;
            _precio = pPrecio;
            _codigo = pCodigo; //codigo para identificar el producto
            _classprodcuto = pClassProducto; //clase o tipo de producto
            _numproducto = pNumProducto; //Cantidad de producto o numero de productos
            _caducidad = pCaducidad; //si el producto tiene fecha de caducidad
        }
        //Metodo mostrar

    }
}
