using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebService.Data.Models;

namespace WebService.ASMX
{
    /// <summary>
    /// Descripción breve de LibraryService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]

    public class LibraryService : System.Web.Services.WebService
    {
        LibraryConnection ConnectionDB = new LibraryConnection();

        [WebMethod]
        public List<Libros> GetBooks()
        {
            var List = ConnectionDB.Libros.ToList();
            return List;
        }
    }
}
