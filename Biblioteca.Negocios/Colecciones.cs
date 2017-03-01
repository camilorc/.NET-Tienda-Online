using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Datos;

namespace Biblioteca.Negocios
{
    public class Colecciones
    {
        private List<Producto> ListarProductos(List<Datos.Producto> productosDatos) 
        {
            List<Producto> salida = new List<Producto>();
            foreach (Datos.Producto producto in productosDatos)
            {
                salida.Add(new Producto() 
                {
                    Id = producto.IdProd,
                    Nombre = producto.NombreProduc,
                    Descripcion = producto.Descripcion,
                    imgUrl = producto.ImgUrl,
                    Precio = producto.Precio,
                    TipoProducto = producto.Tipo,
                    Stock = producto.Stock
                }
                );
            }

            return salida;
        }

        public List<Producto> ListarProductos() 
        {
            return ListarProductos(ModeloBD.InstanciaPastelería.Producto.ToList());
        }

        public List<Producto> ListarProductosFiltro(string tipo)
        {
            return ListarProductos(ModeloBD.InstanciaPastelería.Producto.Where(p=>p.Tipo == tipo).ToList());
        }

        
        public List<Usuario> ListarUsuarios(List<Datos.Usuario> usuariosDatos) 
        {
            List<Usuario> salida = new List<Usuario>();
            foreach (Datos.Usuario usuario in usuariosDatos)
            {
                salida.Add(new Usuario
                {
                    NombreUsuario = usuario.NombreUser,
                    Pass = usuario.Pass,
                    Mail = usuario.Correo,
                    Comuna = usuario.Comuna,
                    Dirección = usuario.Direccion                    
                });
            }
            return salida;
        }

        public List<Usuario> ListarUsuarios() 
        {
            return ListarUsuarios(ModeloBD.InstanciaPastelería.Usuario.ToList());
        }

        public List<Usuario> ListarUsuarios(int idUsuarioP)
        {
            return ListarUsuarios(ModeloBD.InstanciaPastelería.Usuario.Where(p => p.IdUsuario == idUsuarioP).ToList());
        }
    }
}
