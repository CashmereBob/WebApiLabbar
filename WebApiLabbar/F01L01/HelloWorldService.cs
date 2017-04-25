using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldService
{
    public class HelloWorldService : IHelloWorld
    {
        public string SayHello(Name person)
        {
            return $"Hello {person.FName} {person.LName}!";
        }
    }

    [DataContract]
    public class Name 
    {
        [DataMember]
        public string FName { get; set; }
        [DataMember]
        public string LName { get; set; }
    }
    
    [ServiceContract]
    public interface IHelloWorld
    {
        [OperationContract]
        string SayHello(Name person);
    }
}
