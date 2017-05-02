using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_ServerOvning
{
    class PersonService : IPerson
    {
        private static Person person = new Person {
            FirstName = "Jonny",
            LastName = "Svensson",
            Adress = "Brohultsbägen 222, 254 56 Helsingborg",
            Tel = 0767878060
        };
        public bool EditAdress(string adress)
        {
            person.Adress = adress;
            return true;
        }

        public bool EditFirstName(string name)
        {
            person.FirstName = name;
            return true;
        }

        public bool EditLastName(string name)
        {
            person.LastName = name;
            return true;
        }

        public void EditTel(int tel)
        {
            person.Tel = tel;
        }

        public string PrintAdress()
        {
            return $"Tel: {person.Tel} Adress: {person.Adress}";
        }

        public string PrintFullName()
        {
            return $"Fullname: {person.FirstName} {person.LastName}";
        }
    }

    [DataContract]
    public class Person
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Adress { get; set; }
        [DataMember]
        public int Tel { get; set; }
    }
    [ServiceContract]
    public interface IPerson
    {
        [OperationContract]
        bool EditFirstName(string name);
        [OperationContract]
        bool EditLastName(string name);
        [OperationContract]
        bool EditAdress(string adress);
        [OperationContract(IsOneWay = true)]
        void EditTel(int tel);
        [OperationContract]
        string PrintFullName();
        [OperationContract]
        string PrintAdress();
    }
}
