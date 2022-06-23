using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService1
{

    [DataContract]
    public class Staff
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string First_name { get; set; }
        [DataMember]
        public string Last_name { get; set; }
        [DataMember]
        public string User_name { get; set; }
        [DataMember]
        public string NIC { get; set; }
        [DataMember]
        public string Designation { get; set; }
        [DataMember]
        public string Date_of_birth { get; set; }
        [DataMember]
        public string Age { get; set; }
        [DataMember]
        public string Qualifications { get; set; }
        [DataMember]
        public string Joined_date { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Email { get; set; }
    }
}