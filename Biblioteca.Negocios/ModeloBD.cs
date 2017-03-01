using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Datos;

namespace Biblioteca.Negocios
{
    public class ModeloBD
    {
        private static PasteleriaEntities _instanciaPastelería;

        public static PasteleriaEntities InstanciaPastelería
        {
            get 
            {
                if (_instanciaPastelería == null)
                {
                    _instanciaPastelería = new PasteleriaEntities();
                }
                return _instanciaPastelería; 
            }
        }
        
    }
}
