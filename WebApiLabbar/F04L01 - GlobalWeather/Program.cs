using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using GlobalWeather.GlobalWeatherServiceReference;

namespace GlobalWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new GlobalWeatherServiceReference.GlobalWeatherSoapClient("GlobalWeatherSoap12");

            Console.WriteLine(client.GetCitiesByCountry("Sweden"));
            Console.WriteLine(client.GetWeather("Visby Flygplats", "Sweden"));

            Console.ReadLine();
        }
    }
}
