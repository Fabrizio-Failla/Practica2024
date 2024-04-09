using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Venta
    {
        public int id { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public List<(Producto, int)> Productos { get; set; }

        public Venta(Cliente cliente, DateTime fecha, List<(Producto, int)> productos)
        {
            Cliente = cliente;
            Fecha = fecha;
            Productos = productos;
        }

        public double CalcularMontoFinal()
        {
            double montoTotal = 0;
            double impuesto = 0.21;
            foreach (var (producto, cantidad) in Productos)
            {
                montoTotal += (producto.PrecioUnitario * impuesto)+producto.PrecioUnitario;
            }
            return montoTotal;
        }
    }

}