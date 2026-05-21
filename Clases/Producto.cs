using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace pryMaquinaExpendedora.Clases
{
    //para este caso el nombre del producto es un string porque se va ingresar texto
    //en el costo es un flotante, porque al ser un precio puede tener decimales
    //y para la existencia es un entero, porque no puede haber una fraccion de un producto
    //Aplicacion de encapsulamiento
    //las variables son privadas porque no se quiere modificar directamente en el programa principal
    //ya que no cualquiera puede modificar el costo o la existencia de un producto
    //solo se aplico la propiedad de get para mostrar las variables pero no modificarlas
    internal class Producto
    {
        //atributos
        private string nombreProducto;
        private float costo;
        private int existencia;

        //propiedades para mostrar el nombre del producto, el costo y la existencia
        public string _nombreProducto
        {
            get { return nombreProducto; }
        }
        public float _costo
        {
            get { return costo; }
        }
        public int _existencia
        {
            get { return existencia; }
        }


        //constructor que recibe el nombre del producto, el costo y la existencia e inicializa las variables
        public Producto(string nombreProducto, float costo, int existencia)
        {
            this.nombreProducto = nombreProducto;
            this.costo = costo;
            this.existencia = existencia;
        }

        //metodo para comprar un producto, recibe la cantidad, returna la compra hecha y actualiza las existencia
        public string compra(int cantidad)
        {
            if (cantidad > existencia)
            {
                return "\n**** No hay suficiente stock del producto ****";
            }
            else
            {
                existencia = existencia - cantidad;
                float cobroTotal = costo * cantidad;
                return $"********* Compra realizada con exito ********* \nCobro total: $ {cobroTotal}";
            }
        }

        //metodo para mostrar el producto, el precio y la existencia
        public string mostrarProducto()
        {
            return $"{nombreProducto} Precio: $ {costo} Existencia: {existencia}";
        }

    }
}
