using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca.Negocios;

namespace Biblioteca.Presentación
{
    public partial class PagoOnline : System.Web.UI.Page
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




        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                calcularToltal();
                cargarDrop();
            }
        }

        private void cargarDrop()
        {
            ddl_tarjetas.DataSource = Enum.GetValues(typeof(Tarjetas));
            ddl_tarjetas.DataBind();
        }

        private void calcularToltal()
        {
            if (Carro.Count != 0)
            {
                int total = (from carro in Carro
                             select carro.Precio

                                 ).Sum();
                lbl_total.Text = total.ToString();

            }
            else
            {
                lbl_total.Text = "0";
            }
        }

        protected void btn_pagar_Click(object sender, EventArgs e)
        {
            txt_num.Text = "";
            lbl_total.Text = "";
            Carro.Clear();
            lbl_mensaje.Text = "Gracias por su compra!";
        }
    }
}