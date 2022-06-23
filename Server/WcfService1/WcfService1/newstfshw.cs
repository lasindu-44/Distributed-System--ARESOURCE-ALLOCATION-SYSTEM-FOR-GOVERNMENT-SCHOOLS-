using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService1
{
    [DataContract]
    public class newstfshw
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}