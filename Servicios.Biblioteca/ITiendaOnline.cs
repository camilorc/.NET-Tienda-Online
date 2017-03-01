using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Servicios.Biblioteca
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ITiendaOnline
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: agregue aquí sus operaciones de servicio

        [OperationContract]
        bool ValidarUsuario(string username, string password);

        [OperationContract]
        string CalcularEstadisticas();

        [OperationContract]
        string ListarProductos();

        [OperationContract]
        string ListarProductosFiltro(string tipo);

        [OperationContract]
        bool CrearProducto(string producto);

        [OperationContract]
        bool ActualizarProdcuto(string producto);

        [OperationContract]
        bool EliminarProducto(int idParametro);

        [OperationContract]
        string LeerProductos(int idParametro);

       

    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
