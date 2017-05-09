using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace EvalServiceLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class EvalService : IEvalService
    {
        public List<Eval> Evals { get; set; }
        public int evalCount = 0;
        public EvalService()
        {
            Evals = new List<Eval>();
        }

        public void SubmitEval(Eval eval)
        {
            ++evalCount;
            eval.Id = evalCount.ToString();
            Evals.Add(eval);
        }

        public Eval GetEval(string Id)
        {
            return Evals.FirstOrDefault(x => x.Id == Id);
        }

        public List<Eval> GetAllEvals()
        {
            return GetEvaqlsBySubmitter(null);
        }

        public List<Eval> GetEvaqlsBySubmitter(string submitter)
        {
            if(submitter == null)
            {
                return Evals;
            } else
            {
                return Evals.Where(x => x.Submitter == submitter).ToList();
            }
        }

        public void RemoveEval(string id)
        {
            Eval eval = Evals.FirstOrDefault(x => x.Id == id);

            if (eval != null)
            {
                Evals.Remove(eval);
            }
        }
    }
    [DataContract(Namespace = "http://localhost:8089/evals")]
    public class Eval
    {
        [DataMember]
        public string Id { get; set; }
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
        [WebInvoke(Method = "POST", UriTemplate = "evals")]
        void SubmitEval(Eval eval);

        [OperationContract]
        [WebGet(UriTemplate = "eval/{Id}")]
        Eval GetEval(string Id);

        [OperationContract]
        [WebGet(UriTemplate = "evals")]
        List<Eval> GetAllEvals();

        [OperationContract]
        [WebGet(UriTemplate = "evals/{submitter}")]
        List<Eval> GetEvaqlsBySubmitter(string submitter);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "eval/{id}")]
        void RemoveEval(string id);
    }
}
