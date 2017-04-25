using HelloWorldConsoleClient.HelloWorldServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HelloWorldClient("BasicHttpBinding_IHelloWorld");

            var name = new Name();

            Console.Write("Firstname: ");
            name.FName = Console.ReadLine();
            Console.Write("Lastname: ");
            name.LName = Console.ReadLine();

            Console.WriteLine(client.SayHello(name));

            Console.WriteLine();

            Console.ReadKey();


        }
    }
}
