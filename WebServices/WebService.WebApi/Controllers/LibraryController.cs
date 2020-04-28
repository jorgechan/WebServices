using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebService.Data.Models;

namespace WebService.WebApi.Controllers
{
    public class LibraryController : ApiController
    {
        LibraryConnection ConnectionDB = new LibraryConnection();

        /// <summary>
        /// Allows to consult the information of all books
        /// </summary>
        /// <returns></returns>    
        [HttpGet]
        public IEnumerable<Libros> Get()
        {
            var List = ConnectionDB.Libros.ToList();
            return List;
        }

        /// <summary>
        /// Allows to consult the information of a book
        /// </summary>
        /// <returns></returns>    
        [HttpGet]
        public Libros Get(int Id)
        {
            var Libros = ConnectionDB.Libros.FirstOrDefault(x => x.IdLibro == Id);
            return Libros;
        }
    }
}
