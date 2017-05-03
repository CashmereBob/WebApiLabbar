using EvalServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace F03L03___EvalServiceCient
{
    class Program
    {
        static void Main(string[] args)
        {
            //ChannelFactory<IEvalService> factory = new ChannelFactory<IEvalService>("BasicHttpBinding_IEvalService");

            //IEvalService channel = factory.CreateChannel();

            var channel = new EvalServiceClient("BasicHttpBinding_IEvalService");

            try
            {
                channel.SubmitEval(new Eval { Comments = "hepp", Submitter = "hopp", Timesent = DateTime.Now });

                foreach (var item in channel.GetEvals())
                {
                    Console.WriteLine(item.Comments + " " + item.Submitter + " " + item.Timesent);
                }
                Console.ReadKey();

                channel.Close();
            }
            catch (TimeoutException ex)
            {

                Console.WriteLine(ex.Message);
            }
            

            //((IClientChannel)channel).Close();
        }
    }
}
