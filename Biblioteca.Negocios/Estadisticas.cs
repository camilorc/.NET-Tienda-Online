using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Datos;

namespace Biblioteca.Negocios
{
    public class Estadisticas
    {
        public string CalcularEstadisticas() 
        {
            string salida = "";
            double promedioPrecios = ModeloBD.InstanciaPastelería.Producto.Average(p=>p.Precio);
            salida += (string.Format("El promedio de los precios es: {0}", promedioPrecios.ToString()));
            int sumaPrecios = ModeloBD.InstanciaPastelería.Producto.Sum(p => p.Precio);
            salida += (string.Format(" La suma de los precios es: {0}", sumaPrecios));
            string productoMasCaro = ModeloBD.InstanciaPastelería.Producto.Max(p => p.Precio).ToString();
            salida += (string.Format(" El producto más caro cuesta: {0}",productoMasCaro));
            return salida;
        }



    }
}
