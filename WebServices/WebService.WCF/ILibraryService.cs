using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebService.Data.Models;

namespace WebService.WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ILibraryService
    {

        [OperationContract]
        List<Libros> GetBooks();

        // TODO: agregue aquí sus operaciones de servicio
    }
}
