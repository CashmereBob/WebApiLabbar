using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using EvalServiceLibrary;

namespace F02L01___ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(EvalService));

            host.AddServiceEndpoint(typeof(IEvalService), new BasicHttpBinding(), "http://localhost:8080/evals/basic");
            host.AddServiceEndpoint(typeof(IEvalService), new WSHttpBinding(), "http://localhost:8080/evals/ws");
            host.AddServiceEndpoint(typeof(IEvalService), new NetTcpBinding(), "net.tcp://localhost:8088/evals");

            try
            {
                host.Open();
                
                EvalService evalService = new EvalService();
                Eval eval = new Eval {
                    Comments = "Kommentar",
                    Submitter = "Submitter",
                    Timesent = DateTime.Now
                };

                evalService.SubmitEval(eval);
                List<Eval> evals = evalService.GetEvals();

                foreach (Eval item in evals)
                {
                    Console.WriteLine($"{item.Submitter} {item.Comments} {item.Timesent}");
                }

                Console.ReadKey();
                host.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
                host.Abort();
            }
        }
    }
}
