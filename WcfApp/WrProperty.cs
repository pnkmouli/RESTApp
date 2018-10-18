using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Domain;

namespace WcfApp
{

    [DataContract]
    public class WrProperty 
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Address1 { get; set; }
        [DataMember]
        public string Address2 { get; set; }
        [DataMember]
        public string Town { get; set; }
        [DataMember]
        public string Postcode { get; set; }
        [DataMember]
        public decimal Price { get; set; }           

    }
}