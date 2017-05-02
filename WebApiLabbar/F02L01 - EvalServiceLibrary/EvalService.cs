using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EvalServiceLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class EvalService : IEvalService
    {
        public List<Eval> Evals { get; set; }

        public EvalService()
        {
            Evals = new List<Eval>();
        }

        public List<Eval> GetEvals()
        {
            return Evals;
        }

        public void SubmitEval(Eval eval)
        {
            Evals.Add(eval);
        }
    }
    [DataContract]
    public class Eval
    {
        [DataMember]
        public string Submitter { get; set; }
        [DataMember]
        public DateTime Timesent { get; set; }
        [DataMember]
        public string Comments { get; set; }
    }
    [ServiceContract]
    public interface IEvalService
    {
        [OperationContract(IsOneWay = true)]
        void SubmitEval(Eval eval);
        [OperationContract]
        List<Eval> GetEvals();
    }
}
