using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca.Negocios;
using System.Web.Security;

namespace Biblioteca.Presentación
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            Servicio.TiendaOnlineClient servicio = new Servicio.TiendaOnlineClient();
            if (servicio.ValidarUsuario(Login1.UserName, Login1.Password))
            {
                servicio.Close();
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName,Login1.RememberMeSet);
            }
            servicio.Close();
        }
    }
}