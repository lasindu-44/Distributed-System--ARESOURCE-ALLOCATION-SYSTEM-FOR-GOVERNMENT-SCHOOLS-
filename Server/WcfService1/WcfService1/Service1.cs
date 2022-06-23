using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.ServiceModel.Activation;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
   
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        int AddComputingTimeTable(TimeTable t);
        [OperationContract]
        int AddManagementTimeTable(TimeTable t);
        [OperationContract]
        int AddEngineeringTimeTable(TimeTable t);
        [OperationContract]
        List<TimeTable> GetComTimeTable();
        [OperationContract]
        List<TimeTable> GetmngTimeTable();
        [OperationContract]
        List<TimeTable> GetengTimeTable();
        [OperationContract]
        int AddStaffTable(Staff s);
        [OperationContract]
        int AddStudentTable(Student st);
        [OperationContract]
        int UpEngineeringTimeTable(TimeTable t);
        [OperationContract]
        int UpcomineeringTimeTable(TimeTable t);
        [OperationContract]
        int UpmngineeringTimeTable(TimeTable t);
        [OperationContract]
        int DelEngineeringTimeTable(TimeTable t);
        [OperationContract]
        int DelcomineeringTimeTable(TimeTable t);
        [OperationContract]
        int DelmngineeringTimeTable(TimeTable t);
        [OperationContract]
        int UpStaffTable(Staff s);
        [OperationContract]
        int UpStudentTable(Student st);
        [OperationContract]
        int Delstaff(Staff s);
        [OperationContract]
        int Delstudent(Student s);
        [OperationContract]
        List<Staff> getstf();
        [OperationContract]
        List<Student> getstu();
        [OperationContract]
        List<newstfshw> getstfIDnEmail();
        [OperationContract]
        List<TimeTable> GetCurrentComTimeTable();
        [OperationContract]
        List<TimeTable> GetCurrentMngTimeTable();
        [OperationContract]
        List<TimeTable> GetCurrentEngTimeTable();
        [OperationContract]
        List<Staff> Userlogine();

        [OperationContract]
        Staff SearchStaff(string id);

        [OperationContract]
        Student SearchStudent(string id);

        [OperationContract]
        Staff WebLogin(string Id);

        [OperationContract]
        Student WebLogin2(string Id);

        [OperationContract]
        TimeTable SearchComputingTable(string no);

        [OperationContract]
        TimeTable SearchManagementTable(string no);

        [OperationContract]
        TimeTable SearchengineeringTable(string no);

    }



    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}

