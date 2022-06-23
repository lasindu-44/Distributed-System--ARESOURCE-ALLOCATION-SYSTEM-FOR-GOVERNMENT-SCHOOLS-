using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService1
{
    [DataContract]
    public class Student
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
        public string Admission_no { get; set; }
        [DataMember]
        public string Section { get; set; }
        [DataMember]
        public string Grade { get; set; }
        [DataMember]
        public string Class  { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Phone { get; set; }

    }
}