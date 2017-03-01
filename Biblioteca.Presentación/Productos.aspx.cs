using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca.Negocios;
using System.Xml.Serialization;
using System.IO;

namespace Biblioteca.Presentación
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){
                CargarProductos();
                
            }
        }

        
        private void CargarProductos()
        {
            Servicio.TiendaOnlineClient servicio = new Servicio.TiendaOnlineClient();
            XmlSerializer serializador = new XmlSerializer(typeof(List<Producto>));
            StringReader lector = new StringReader(servicio.ListarProductos());
            List<Producto> productosLista = (List<Producto>)serializador.Deserialize(lector);
            lvproductos.DataSource = productosLista;
            lvproductos.DataBind();
            servicio.Close();

        }

        protected void lvproductos_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            CargarProductos();
        }

       
    }
}