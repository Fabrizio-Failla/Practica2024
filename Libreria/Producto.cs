using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripción { get; set; }
        public TipoDeProducto Tipo { get; set; }
        public Tamanio Tamanio { get; set; }
        public enum Stock { Disponible, NoDisponible}
        public double PrecioUnitario { get; set; }
        public Producto(int id, string descripción, TipoDeProducto tipo, double precioUnitario, Tamanio tamanio )
        {
            Id = id;
            Descripción = descripción;
            Tipo = tipo;
            PrecioUnitario = precioUnitario;
            Tamanio = tamanio;
            
         }

        
    }
}
