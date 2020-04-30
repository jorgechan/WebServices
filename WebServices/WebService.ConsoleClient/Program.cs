using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Consume asmx web service
            LibraryServiceASMX.LibraryServiceSoapClient ClientLibrary = new LibraryServiceASMX.LibraryServiceSoapClient();
            var ListBooks = ClientLibrary.GetBooks();

            LibraryServiceWCF.LibraryServiceClient ClientLibrary1 = new LibraryServiceWCF.LibraryServiceClient();
            var ListBooks1 = ClientLibrary1.GetBooks();
        }
    }
}
