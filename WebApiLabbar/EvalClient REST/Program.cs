using EvalServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace EvalClient_REST
{
    class Program
    {
        static void Main(string[] args)
        {
            WebChannelFactory<IEvalService> cf = new WebChannelFactory<IEvalService>(new Uri("http://localhost:8089/evalservice"));

            IEvalService client = cf.CreateChannel();

            


            string input = "";

            while (input != "exit")
            {
                Console.Clear();
                Console.WriteLine("exit: quit app");
                Console.WriteLine("submit: submit eval");
                Console.WriteLine("get: get eval");
                Console.WriteLine("list: list evals");
                Console.WriteLine("remove: remove eval");
                Console.WriteLine();
                Console.Write("> ");
                input = Console.ReadLine();
                

                switch (input.ToLower())
                {
                    case "exit":
                        return;
                    case "submit":
                        SubmitEval(client);
                        break;
                    case "get":
                        GetEval(client);
                        break;
                    case "list":
                        ListEval(client);
                        break;
                    case "remove":
                        RemoveEval(client);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void RemoveEval(IEvalService client)
        {
            Console.WriteLine();
            Console.Write("ID: ");
            var inp = Console.ReadLine();
            client.RemoveEval(inp);
            Console.ReadKey();
        }

        private static void ListEval(IEvalService client)
        {
            Console.WriteLine();
            foreach (var item in client.GetAllEvals())
            {
                Console.WriteLine($"{item.Comments} {item.Submitter} {item.Timesent}");
            }
            Console.ReadKey();
        }

        private static void GetEval(IEvalService client)
        {
            Console.WriteLine();
            Console.Write("ID: ");
            var inp = Console.ReadLine();
            Console.WriteLine(client.GetEval(inp));
            Console.ReadKey();
        }

        private static void SubmitEval(IEvalService client)
        {
            Console.WriteLine();
            Console.Write("Submitter: ");
            var submitter = Console.ReadLine();
            Console.Write("Comments: ");
            var comments = Console.ReadLine();

            var eval = new Eval { Submitter = submitter, Comments = comments, Timesent = DateTime.Now };
            client.SubmitEval(eval);


        }
    }
}
