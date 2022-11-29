using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string Insert(InsertTenant tenant);
        


        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class InsertTenant
    {
        string name = string.Empty;
        string email = string.Empty;
        string rent = string.Empty;

       

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [DataMember]
        public string Rent
        {
            get { return rent; }
            set { rent = value; }
        }
    }
}
