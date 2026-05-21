using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace pryMaquinaExpendedora.Clases
{
    internal class Producto
    {
        private string nombreProducto;
        private float costo;
        private int existencia;

        public string _nombreProducto{
            get { return nombreProducto; }            
        }
        public float _costo {
            get { return costo; }
        }
        public int _existencia {
            get { return existencia; }
        }


        //constructor
        public Producto(string nombreProducto, float costo, int existencia) {
            this.nombreProducto = nombreProducto;
            this.costo = costo;
            this.existencia = existencia;
        }

        public string compra(int cantidad) {
            if (cantidad > existencia)
            {
                return "No hay suficiente stock del producto.";
            }
            else {
                existencia = existencia - cantidad;
                float cobroTotal = costo * cantidad; 
                return $"Compra realizada con exito \n Cobro total: $ {cobroTotal}"; 
            }
        }
        public string mostrarProducto() {
            return $"Producto: {nombreProducto} Precio: $ {costo} Existencia: {existencia}";
        }

    }
}
