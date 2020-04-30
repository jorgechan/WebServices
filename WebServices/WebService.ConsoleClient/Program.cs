using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebService.Data.Models;

namespace WebService.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Consume ASMX web service
            //LibraryServiceASMX.LibraryServiceSoapClient ClientLibrary = new LibraryServiceASMX.LibraryServiceSoapClient();
            //var ListBooks = ClientLibrary.GetBooks();

            //// Consume WCF web service
            //LibraryServiceWCF.LibraryServiceClient ClientLibrary1 = new LibraryServiceWCF.LibraryServiceClient();
            //var ListBooks1 = ClientLibrary1.GetBooks();

            // Consume REST web service
            HttpClient ClientHttp = new HttpClient();

            // We establish a site where each of the methods will be invoked
            ClientHttp.BaseAddress = new Uri("http://localhost:53424/");

            // We indicate that it is invoked by the get method starting from the indicated site
            var Request = ClientHttp.GetAsync("api/Library").Result;

            // We validate if the request was successful
            if (Request.IsSuccessStatusCode)
            {
                // Map the result obtained from a request
                var ResultString = Request.Content.ReadAsStringAsync().Result;

                // Convert json result to class
                var ListBooks = JsonConvert.DeserializeObject<List<Libros>>(ResultString);

                // Print a book list
                foreach (var iListBooks in ListBooks)
                {
                    Console.WriteLine(iListBooks.Titulo);
                }
            }
        }
    }
}
