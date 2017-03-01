using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Datos;

namespace Biblioteca.Negocios
{
    public class Usuario
    {
        #region Campos y propiedades
        public int IdUsuario { get; private set; }
        private string _nombreUsuario;
        public string Pass { get; set; }
        public string Comuna { get; set; }
        public string Mail { get; set; }
        public string Dirección { get; set; }

        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set
            {
                if (value.Trim().Length > 20)
                {
                    throw new ArgumentException("El nombre no puede exceder los 20 caracteres.");
                }
                _nombreUsuario = value;
            }
        }
        #endregion

        #region Constructores e inicializador
        public Usuario()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            _nombreUsuario = string.Empty;
            Pass = string.Empty;
            Comuna = LugarComuna.Santiago.ToString();
            Mail = string.Empty;
            Dirección = string.Empty;
        }

        private int MaxId()
        {
            int idmax = ModeloBD.InstanciaPastelería.Usuario.Max(p =>p.IdUsuario);
            return idmax; 
        }


        public Usuario(string nombre, string pass, string comuna, string mail, string direccion)
        {
            _nombreUsuario = nombre;
            Pass = pass;
            Comuna = comuna;
            Mail = mail;
            Dirección = direccion;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Id: {0}", IdUsuario));
            sb.AppendLine(string.Format("Nombre: {0}", NombreUsuario));
            sb.AppendLine(string.Format("Comuna: {0}", Comuna));
            sb.AppendLine(string.Format("Dirección: {0}", Dirección));
            sb.AppendLine(string.Format("Mail: {0}", Mail));
            return sb.ToString();
        }
        #endregion

        #region Metodos

        public bool ValidarUsuario(string username, string password)
        {
            try
            {
                var usuario = ModeloBD.InstanciaPastelería.Usuario.First(
                     u => u.NombreUser == username && u.Pass == password);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
        
    }
}
