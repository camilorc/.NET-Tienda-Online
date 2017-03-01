using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca.Negocios;

namespace TiendaOnline
{
    public partial class CarroDeCompras : System.Web.UI.Page
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
            if(!IsPostBack){
                cargarLista();
                calcularToltal();
            }
        }

        private void calcularToltal()
        {
            if (Carro.Count != 0)
            {
                int total = (from carro in Carro
                                 select carro.Precio
                                 
                                 ).Sum();
                lbl_total.Text = total.ToString();
            
            }else{
                lbl_total.Text = "0";
            }
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(lsb_carro.SelectedIndex != -1){
                Carro.RemoveAt(lsb_carro.SelectedIndex);
                cargarLista();
                calcularToltal();
            }
        }

        private void cargarLista()
        {
            lsb_carro.Items.Clear();

            int i = 0;
            foreach (Producto prod in Carro)
            {
                lsb_carro.Items.Add(
                     new ListItem()
                     {
                         Text = String.Format("Nombre: {0} - Precio:$ {1}", prod.Nombre, prod.Precio.ToString("0,0")),
                         Value = (i++).ToString()

                     }

                );
            }
                
        }

        protected void btn_pagar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PagoOnline.aspx");
        }
    }
}