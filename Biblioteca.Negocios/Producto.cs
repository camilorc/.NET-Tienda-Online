using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Datos;

namespace Biblioteca.Negocios
{
    public class Producto
    {
        #region Campos y propiedades
        public int Id { get; set; }
        public int Precio { get; set; }
        public string TipoProducto { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public string Nombre { get; set; }
        public string imgUrl { get; set; }
        #endregion

        #region Constructor e inicializador
        public Producto()
        {
            Inicializador();
        }

        private void Inicializador()
        {
            Id = 0;
            Precio = 0;
            TipoProducto = Tipo.Torta.ToString();
            Descripcion = string.Empty;
            Stock = 0;
            Nombre = string.Empty;
            imgUrl = "/img/NoValue";
            
        }

        private int AsignarID()
        {
            var idmax = (from Datos.Producto prod in ModeloBD.InstanciaPastelería.Producto
                        select prod.IdProd).Count();
            return idmax + 1;
        }

        public Producto(int precio, Tipo tipo, string descripcion, int stock, string nombre, string url, int id)
        {
            Id = id;
            Precio = precio;
            TipoProducto = tipo.ToString();
            Descripcion = descripcion;
            Stock = stock;
            Nombre = nombre;
            imgUrl = url;
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Id: ", Id));
            sb.AppendLine(string.Format("Nombre: ", Nombre));
            sb.AppendLine(string.Format("Precio: ${0}", Precio.ToString("0,0")));
            sb.AppendLine(string.Format("Tipo producto: ", TipoProducto));
            sb.AppendLine(string.Format("Descripcion: ", Descripcion));
            sb.AppendLine(string.Format("Cantidad: ", Stock));
            return sb.ToString();
        }
        #endregion

        #region CRUD

        public bool Create()
        {
            try
            {
                Datos.Producto prod = new Datos.Producto();
                prod.IdProd = this.Id;
                prod.NombreProduc = this.Nombre;
                prod.Descripcion = this.Descripcion;
                prod.Stock = this.Stock;
                prod.Precio = this.Precio;
                prod.ImgUrl = this.imgUrl;
                prod.Tipo = this.TipoProducto;
                ModeloBD.InstanciaPastelería.AddToProducto(prod);
                ModeloBD.InstanciaPastelería.SaveChanges();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                Datos.Producto prod = BuscarProductos();
                this.Id = prod.IdProd;
                this.Nombre = prod.NombreProduc;
                this.Descripcion = prod.Descripcion;
                this.Stock = prod.Stock;
                this.Precio = prod.Precio;
                this.imgUrl = prod.ImgUrl;
                this.TipoProducto = prod.Tipo;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                Datos.Producto prod = BuscarProductos();
                prod.IdProd = this.Id;
                prod.NombreProduc = this.Nombre;
                prod.Descripcion = this.Descripcion;
                prod.Stock = this.Stock;
                prod.Precio = this.Precio;
                prod.ImgUrl = this.imgUrl;
                prod.Tipo = this.TipoProducto;
                ModeloBD.InstanciaPastelería.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                Datos.Producto prod = BuscarProductos();
                ModeloBD.InstanciaPastelería.DeleteObject(prod);
                ModeloBD.InstanciaPastelería.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Datos.Producto BuscarProductos()
        {
            return ModeloBD.InstanciaPastelería.Producto.First(p => p.IdProd == this.Id);
        } 
        #endregion

        

    }
}
