using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb1_ClientOvning.PersonServiceReference;

namespace Labb1_ClientOvning
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new PersonClient("BasicHttpBinding_IPerson");

            Console.WriteLine(client.PrintAdress());
            Console.WriteLine(client.PrintFullName());

            Console.WriteLine();

            client.EditFirstName("Sven");
            client.EditLastName("Karlsson");
            client.EditTel(042160497);
            client.EditAdress("Smack");
            Console.WriteLine(client.PrintAdress());
            Console.WriteLine(client.PrintFullName());



            Console.ReadLine();

        }
    }
}
