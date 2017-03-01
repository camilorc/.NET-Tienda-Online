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
    public partial class Reportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){
                CargarEstadisticas();
            }
        }

        private void CargarEstadisticas()
        {
            Servicio.TiendaOnlineClient servicio = new Servicio.TiendaOnlineClient();
            XmlSerializer serializador = new XmlSerializer(typeof(string));
            StringReader lector = new StringReader(servicio.CalcularEstadisticas());
            lbl_prom_prod.Text = serializador.Deserialize(lector).ToString();
        }
    }
}