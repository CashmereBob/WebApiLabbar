using EvalServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace EvalConsoleHost_REST
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebServiceHost(typeof(EvalService));

            try
            {
                host.Open();
                Console.ReadLine();
                host.Close();
            }
            catch (Exception)
            {
                host.Abort();
                throw;
            }
        }
    }
}
