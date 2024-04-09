using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace Practica2024
{
    public class Program
    {
        static void Main(string[] args)
        {
            TipoDeProducto herramienta = new TipoDeProducto(1, "Herramienta");
            Tamanio grande = new Tamanio(1, "Grande");
            Tamanio mediano = new Tamanio(2, "Mediano");
            Producto producto1 = new Producto(1, "Martillo", herramienta, 2200, grande);
            
            List<(Producto, int)> listaProductos = new List<(Producto, int)>();
            listaProductos.Add((producto1, 1));

            Cliente cliente1 = new Cliente(45342920, "Fabrizio Failla", "fabriziofailla123@gmail.com");
            Venta venta1 = new Venta(cliente1, DateTime.Now, listaProductos);
            double montoTotalConIVA = venta1.CalcularMontoFinal();
            Console.WriteLine(venta1.id);
            Console.WriteLine(venta1.Cliente.Nombre);
            Console.WriteLine(venta1.Fecha);
            Console.WriteLine($"Monto total: {montoTotalConIVA:C}");
        }
   
    }
}
