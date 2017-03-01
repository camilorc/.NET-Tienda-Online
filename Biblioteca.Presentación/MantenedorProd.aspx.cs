using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using Biblioteca.Negocios;
using System.IO;

namespace Biblioteca.Presentación
{
    public partial class MantenedorProd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlTipoProducto.DataSource = Enum.GetValues(typeof(Tipo));
                ddlTipoProducto.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Servicio.TiendaOnlineClient servicio = new Servicio.TiendaOnlineClient();
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Producto));
                StringWriter escritor = new StringWriter();
                Producto prod = new Producto()
                {
                    Id = int.Parse(txtId.Text),
                    Nombre = txtNombre.Text,
                    Stock = int.Parse(txtStock.Text),
                    TipoProducto = ddlTipoProducto.SelectedItem.ToString(),
                    Descripcion = txtDescripción.Text,
                    Precio = int.Parse(txtPrecio.Text),
                    imgUrl = "/img/"+FileImg.FileName
                    
                    
                };

                serializador.Serialize(escritor, prod);
                

                if (!servicio.CrearProducto(escritor.ToString()))
                {
                    throw new ArgumentException("No se pudo crear");
                }
                lblMensajes.Text = "Creado";
                Limpiar();
            }
            catch (Exception ex)
            {
                lblMensajes.Text = ex.Message;
            }
            servicio.Close();
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtDescripción.Text = "";
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Servicio.TiendaOnlineClient servicio = new Servicio.TiendaOnlineClient();
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Producto));
                StringWriter escritor = new StringWriter();
                Producto prod = new Producto() 
                {
                     Id = int.Parse(txtId.Text),
                     Nombre = txtNombre.Text,
                     Stock = int.Parse(txtStock.Text),
                     TipoProducto = ddlTipoProducto.SelectedItem.ToString(),
                     Descripcion = txtDescripción.Text,
                     Precio = int.Parse(txtPrecio.Text),
                     imgUrl = "/img/"+FileImg.FileName
                };
                serializador.Serialize(escritor,prod);
                if (!servicio.ActualizarProdcuto(escritor.ToString()))
                {
                    throw new ArgumentException("No se pudo actualizar");
                }
                lblMensajes.Text = "Actualizado";
                Limpiar();
            }
            catch (Exception ex)
            {
                lblMensajes.Text = ex.Message;
            }
            servicio.Close();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Servicio.TiendaOnlineClient servicio = new Servicio.TiendaOnlineClient();
            try
            {

                XmlSerializer serializador = new XmlSerializer(typeof(Producto));
                StringReader lector = new StringReader(servicio.LeerProductos(int.Parse(txtId.Text)));
                Producto prod = (Producto)serializador.Deserialize(lector);
                ddlTipoProducto.SelectedIndex = DevolverPosicion(prod.TipoProducto);
                txtDescripción.Text = prod.Descripcion;
                txtPrecio.Text = prod.Precio.ToString();
                txtNombre.Text = prod.Nombre;
                txtStock.Text = prod.Stock.ToString();
                lblMensajes.Text = "Encontrado";
            }
            catch (Exception)
            {
                lblMensajes.Text = "No se encontro";
            }
            servicio.Close();
        }

        private int DevolverPosicion(string TipoProd)
        {
            switch (TipoProd)
            {
                case "Torta":
                    return 0;
                case "Sandwich":
                    return 1;
                case "Cupcakes":
                    return 2;
                case "Otros":
                    return 3;
                default :
                    return 4;                   
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Servicio.TiendaOnlineClient servicio = new Servicio.TiendaOnlineClient();
            try
            {
                if (!servicio.EliminarProducto(int.Parse(txtId.Text)))
                {
                    throw new ArgumentException("No se pudo eliminar");
                }
                lblMensajes.Text = "Eliminado";
                Limpiar();
            }
            catch (Exception ex)
            {
                
                lblMensajes.Text = ex.Message;
            }
        }


    }
}