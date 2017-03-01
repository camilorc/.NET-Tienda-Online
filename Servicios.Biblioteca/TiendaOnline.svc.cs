using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Biblioteca.Negocios;
using System.Xml.Serialization;
using System.IO;

namespace Servicios.Biblioteca
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    public class TiendaOnline : ITiendaOnline
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public bool ValidarUsuario(string username, string password)
        {
            Usuario user = new Usuario();
            return user.ValidarUsuario(username, password);
        }

        public string CalcularEstadisticas()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(string));
            StringWriter escritor = new StringWriter();
            Estadisticas estadisticas = new Estadisticas();
            serializador.Serialize(escritor,estadisticas.CalcularEstadisticas());
            return escritor.ToString();
        }

        public string ListarProductos()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(List<Producto>));
            StringWriter escritor = new StringWriter();
            Colecciones col = new Colecciones();
            serializador.Serialize(escritor, col.ListarProductos());
            return escritor.ToString();
        }

        public string ListarProductosFiltro(string tipo)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(List<Producto>));
            StringWriter escritor = new StringWriter();
            Colecciones col = new Colecciones();
            serializador.Serialize(escritor, col.ListarProductosFiltro(tipo));
            return escritor.ToString();
        }

        public bool CrearProducto(string producto)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(Producto));
            StringReader lector = new StringReader(producto);
            Producto nuevoProd = (Producto)serializador.Deserialize(lector);
            return nuevoProd.Create();
        }

        public bool ActualizarProdcuto(string producto)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(Producto));
            StringReader lector = new StringReader(producto);
            Producto prod = (Producto)serializador.Deserialize(lector);
            return prod.Update();
        }

        public bool EliminarProducto(int idParametro)
        {
            Producto prod = new Producto() { Id = idParametro };
            return prod.Delete();
        }

        public string LeerProductos(int idParametro)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(Producto));
            StringWriter escritor = new StringWriter();
            Producto prod = new Producto() { Id = idParametro };
            prod.Read();
            serializador.Serialize(escritor, prod);
            return escritor.ToString();
        }


    }
}
