using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService1
{
    [DataContract]
    public class TimeTable
    {
        [DataMember]
        public string No { get; set; }
        [DataMember]
        public string Grade { get; set; }
        [DataMember]
        public string Class { get; set; }
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public string Teacher { get; set; }
        [DataMember]
        public string Date { get; set; }

        [DataMember]
        public string Time { get; set; }
        [DataMember]
        public string Class_Room_Lab { get; set; }
        [DataMember]
        public string Class_Room_Lab_ID { get; set; }
    }
}