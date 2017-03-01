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
    public partial class Filtros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){
                CargarDrop();
                CargarProductos();
            }
        }

        private void CargarProductos()
        {
            Servicio.TiendaOnlineClient servicio = new Servicio.TiendaOnlineClient();

            XmlSerializer serializador = new XmlSerializer(typeof(List<Producto>));
            StringReader lector = new StringReader(servicio.ListarProductosFiltro(ddl_filtro.SelectedValue.ToString()));
            lvproductosfiltro.DataSource = (List<Producto>)serializador.Deserialize(lector);
            lvproductosfiltro.DataBind();
            servicio.Close();
        }

        private void CargarDrop()
        {
            ddl_filtro.DataSource = Enum.GetValues(typeof(Tipo));
            ddl_filtro.DataBind();
        }

        protected void ddl_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }
    }
}