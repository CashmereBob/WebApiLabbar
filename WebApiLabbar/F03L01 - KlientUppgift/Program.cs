using F03L01___KlientUppgift.addSoapServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F03L01___KlientUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new addSoapClient();

            double time;

            var sum = client.add(2, 3, out time);

            Console.WriteLine($"Summa: {sum}, Tid: {time}");

            Console.ReadKey();
        }
    }
}
