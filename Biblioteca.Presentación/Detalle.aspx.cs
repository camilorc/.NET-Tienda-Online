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
    public partial class Detalle : System.Web.UI.Page
    {
        public List<Producto> Carro
        {
            get
            {
                if (Session["carro"] == null)
                {
                    Session["carro"] = new List<Producto>();
                }
                return (List<Producto>)Session["carro"];

            }
            set
            {
                Session["carro"] = value;
            }

        }

        public Producto ProductoVariable
        {
            get
            {
                if (Session["producto"] == null)
                {
                    Session["producto"] = new List<Producto>();
                }
                return ((Producto)Session["producto"]);

            }
            set
            {
                Session["producto"] = value;
            }

        }




        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){
                CargarProducto();
            }
        }

        private void CargarProducto()
        {
            try
            {
                string indice = Request.Params["indice"];
                int idpro = int.Parse(indice);

                Servicio.TiendaOnlineClient servicio = new Servicio.TiendaOnlineClient();
                XmlSerializer serializador = new XmlSerializer(typeof(Producto));
                StringReader lector = new StringReader(servicio.LeerProductos(idpro));
                Producto pro = (Producto)serializador.Deserialize(lector);

                lbl_nombre.Text = pro.Nombre;
                lbl_precio.Text = pro.Precio.ToString();
                lbl_stock.Text = pro.Stock.ToString();
                lbl_descripcion.Text = pro.Descripcion;
                lbl_tipo.Text = pro.TipoProducto;
                Image1.ImageUrl = pro.imgUrl;

                ProductoVariable = pro;


            }
            catch (Exception)
            {
                Response.Redirect("PaginaError.aspx");
                
            }
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            Carro.Add(ProductoVariable);
            
        }
    }
}