using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.ServiceModel.Activation;

namespace WcfService1
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Service1()
        {
            ConnectDB();
           
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        SqlConnection con;
        SqlCommand cmd;
        string sql;
        void ConnectDB()
        {
            try
            {
                con = new SqlConnection(@"Data Source=.;Initial Catalog=ip_prj;Integrated Security=True");

                cmd = con.CreateCommand();
            }
            catch (Exception) { throw; }
        }
        public int AddComputingTimeTable(TimeTable t)
        {
            try
            {
                sql = "INSERT INTO grade_six_to_nine_time_table (grade,class,subject,teacher,date,time,class_room_lab,class_room_lab_id) VALUES (@grade,@class,@subject,@teacher,@date,@time,@class_room_lab,@class_room_lab_id)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("grade", t.Grade);
                cmd.Parameters.AddWithValue("class", t.Class);
                cmd.Parameters.AddWithValue("subject", t.Subject);
                cmd.Parameters.AddWithValue("teacher", t.Teacher);
                cmd.Parameters.AddWithValue("date", t.Date);
                cmd.Parameters.AddWithValue("time", t.Time);
                cmd.Parameters.AddWithValue("class_room_lab", t.Class_Room_Lab);
                cmd.Parameters.AddWithValue("class_room_lab_id", t.Class_Room_Lab_ID);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception) {
                throw;
                
            }
            finally
            {
                //test
                con.Close();
            }
        }

        public int AddManagementTimeTable(TimeTable t)
        {
            try
            {
                sql = "INSERT INTO ol_time_table (grade,class,subject,teacher,[date],[time],class_room_lab,class_room_lab_id) VALUES (@grade,@class,@subject,@teacher,@da,@time,@class_room_lab,@class_room_lab_id)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("grade", t.Grade);
                cmd.Parameters.AddWithValue("class", t.Class);
                cmd.Parameters.AddWithValue("subject", t.Subject);
                cmd.Parameters.AddWithValue("teacher", t.Teacher);
                cmd.Parameters.AddWithValue("da", t.Date);
                cmd.Parameters.AddWithValue("time", t.Time);
                cmd.Parameters.AddWithValue("class_room_lab", t.Class_Room_Lab);
                cmd.Parameters.AddWithValue("class_room_lab_id", t.Class_Room_Lab_ID);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally
            {
                //test
                con.Close();
            }
        }

        public int AddEngineeringTimeTable(TimeTable t)
        {
            try
            {
                sql = "INSERT INTO al_time_table (grade,class,subject,teacher,[date],[time],class_room_lab,class_room_lab_id) VALUES (@grade,@class,@subject,@teacher,@da,@time,@class_room_lab,@class_room_lab_id)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("grade", t.Grade);
                cmd.Parameters.AddWithValue("class", t.Class);
                cmd.Parameters.AddWithValue("subject", t.Subject);
                cmd.Parameters.AddWithValue("teacher", t.Teacher);
                cmd.Parameters.AddWithValue("da", t.Date);
                cmd.Parameters.AddWithValue("time", t.Time);
                cmd.Parameters.AddWithValue("class_room_lab", t.Class_Room_Lab);
                cmd.Parameters.AddWithValue("class_room_lab_id", t.Class_Room_Lab_ID);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally
            {
                //test
                con.Close();
            }
        }


        public List<TimeTable> GetComTimeTable()
        {
            List<TimeTable> timetablel = new List<TimeTable>();

            try
            {
                con.Open();
                //String currentDate = DateTime.Today.ToString("yyyy-MM-dd");
                sql = "SELECT no,grade,class,subject,teacher,[date],[time],class_room_lab,class_room_lab_id FROM grade_six_to_nine_time_table";

                cmd.CommandText = sql;
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TimeTable t = new TimeTable()
                    {
                        No = reader[0].ToString(),
                        Grade = reader[1].ToString(),
                        Class = reader[2].ToString(),
                        Subject = reader[3].ToString(),
                        Teacher = reader[4].ToString(),
                        Date = reader[5].ToString(),
                        Time = reader[6].ToString(),
                        Class_Room_Lab = reader[7].ToString(),
                        Class_Room_Lab_ID = reader[8].ToString(),

                    };
                    timetablel.Add(t);
                }
                return timetablel;
            }
            catch (Exception) { throw; }
            con.Close();
        }


        public List<TimeTable> GetmngTimeTable()
        {
            List<TimeTable> timetable2 = new List<TimeTable>();
            try
            {
                con.Open();
                // String currentDate = DateTime.Today.ToString("yyyy-MM-dd");
                sql = "SELECT no,grade,class,subject,teacher,[date],[time],class_room_lab,class_room_lab_id FROM ol_time_table";

                cmd.CommandText = sql;
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TimeTable t = new TimeTable()
                    {
                        No = reader[0].ToString(),
                        Grade = reader[1].ToString(),
                        Class = reader[2].ToString(),
                        Subject = reader[3].ToString(),
                        Teacher = reader[4].ToString(),
                        Date = reader[5].ToString(),
                        Time = reader[6].ToString(),
                        Class_Room_Lab = reader[7].ToString(),
                        Class_Room_Lab_ID = reader[8].ToString(),
                    };
                    timetable2.Add(t);
                }
                return timetable2;
            }
            catch (Exception) { throw; }
            con.Close();
        }

        public List<TimeTable> GetengTimeTable()
        {
            List<TimeTable> timetable3 = new List<TimeTable>();
            try
            {
                con.Open();
                // String currentDate = DateTime.Today.ToString("yyyy-MM-dd");
                sql = "SELECT no,grade,class,subject,teacher,[date],[time],class_room_lab,class_room_lab_id FROM al_time_table";

                cmd.CommandText = sql;
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TimeTable t = new TimeTable()
                    {
                        No = reader[0].ToString(),
                        Grade = reader[1].ToString(),
                        Class = reader[2].ToString(),
                        Subject = reader[3].ToString(),
                        Teacher = reader[4].ToString(),
                        Date = reader[5].ToString(),
                        Time = reader[6].ToString(),
                        Class_Room_Lab = reader[7].ToString(),
                        Class_Room_Lab_ID = reader[8].ToString(),
                    };
                    timetable3.Add(t);
                }
                return timetable3;
            }
            catch (Exception) { throw; }
            con.Close();
        }


        public int AddStaffTable(Staff s)
        {
            
            try
            {
                sql = "INSERT INTO teacher (id,first_name,last_name,user_name,nic,designation,[date_of_birth],age,qualifications,[joined_date],phone,email) VALUES (@id,@fname,@lname,@uname,@nic,@dsg,@dob,@age,@qlf,@jdate,@phone,@email)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("id", s.Id);
                cmd.Parameters.AddWithValue("fname", s.First_name);
                cmd.Parameters.AddWithValue("lname", s.Last_name);
                cmd.Parameters.AddWithValue("uname", s.User_name);
                cmd.Parameters.AddWithValue("nic", s.NIC);
                cmd.Parameters.AddWithValue("dsg", s.Designation);
                cmd.Parameters.AddWithValue("dob", s.Date_of_birth);
                cmd.Parameters.AddWithValue("age", s.Age);
                cmd.Parameters.AddWithValue("qlf", s.Qualifications);
                cmd.Parameters.AddWithValue("jdate", s.Joined_date);
                cmd.Parameters.AddWithValue("phone", s.Phone);
                cmd.Parameters.AddWithValue("email", s.Email);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally
            {
                //test
                con.Close();
            }
        }

        public int AddStudentTable(Student st)
        {
            try
            {
                sql = "INSERT INTO student (id,first_name,last_name,user_name,admission_no,section,grade,class,email,phone) VALUES (@id,@fname,@lname,@uname,@admission_no,@section,@grade,@class,@email,@phone)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("id", st.Id);
                cmd.Parameters.AddWithValue("fname", st.First_name);
                cmd.Parameters.AddWithValue("lname", st.Last_name);
                cmd.Parameters.AddWithValue("uname", st.User_name);
                cmd.Parameters.AddWithValue("admission_no", st.Admission_no);
                cmd.Parameters.AddWithValue("section", st.Section);
                cmd.Parameters.AddWithValue("grade", st.Grade);
                cmd.Parameters.AddWithValue("class", st.Class);
                cmd.Parameters.AddWithValue("email", st.Email);
                cmd.Parameters.AddWithValue("phone", st.Phone);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception) {

                              
                throw;

            }
            finally
            {
                //test
                con.Close();
            }
        }


        public int UpEngineeringTimeTable(TimeTable t)
        {
            try
            {
                sql = "UPDATE al_time_table SET grade=@grade,class=@class,subject=@subject,teacher=@teacher,[date]=@da,[time]=@time,class_room_lab=@class_room_lab,class_room_lab_id=@class_room_lab_id  WHERE no=@no";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("no", t.No);
                cmd.Parameters.AddWithValue("grade", t.Grade);
                cmd.Parameters.AddWithValue("class", t.Class);
                cmd.Parameters.AddWithValue("subject", t.Subject);
                cmd.Parameters.AddWithValue("teacher", t.Teacher);
                cmd.Parameters.AddWithValue("da", t.Date);
                cmd.Parameters.AddWithValue("time", t.Time);
                cmd.Parameters.AddWithValue("class_room_lab", t.Class_Room_Lab);
                cmd.Parameters.AddWithValue("class_room_lab_id", t.Class_Room_Lab_ID);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally
            {
                //test
                con.Close();
            }
        }

        public int UpcomineeringTimeTable(TimeTable t)
        {
            try
            {
                sql = "UPDATE grade_six_to_nine_time_table SET grade=@grade,class=@class,subject=@subject,teacher=@teacher,[date]=@da,[time]=@time,class_room_lab=@class_room_lab,class_room_lab_id=@class_room_lab_id  WHERE no=@no";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("no", t.No);
                cmd.Parameters.AddWithValue("grade", t.Grade);
                cmd.Parameters.AddWithValue("class", t.Class);
                cmd.Parameters.AddWithValue("subject", t.Subject);
                cmd.Parameters.AddWithValue("teacher", t.Teacher);
                cmd.Parameters.AddWithValue("da", t.Date);
                cmd.Parameters.AddWithValue("time", t.Time);
                cmd.Parameters.AddWithValue("class_room_lab", t.Class_Room_Lab);
                cmd.Parameters.AddWithValue("class_room_lab_id", t.Class_Room_Lab_ID);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw; }
            finally
            {
                //test
                con.Close();
            }
        }

        public int UpmngineeringTimeTable(TimeTable t)
        {
            try
            {
                sql = "UPDATE ol_time_table SET grade=@grade,class=@class,subject=@subject,teacher=@teacher,[date]=@da,[time]=@time,class_room_lab=@class_room_lab,class_room_lab_id=@class_room_lab_id  WHERE no=@no";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("no", t.No);
                cmd.Parameters.AddWithValue("grade", t.Grade);
                cmd.Parameters.AddWithValue("class", t.Class);
                cmd.Parameters.AddWithValue("subject", t.Subject);
                cmd.Parameters.AddWithValue("teacher", t.Teacher);
                cmd.Parameters.AddWithValue("da", t.Date);
                cmd.Parameters.AddWithValue("time", t.Time);
                cmd.Parameters.AddWithValue("class_room_lab", t.Class_Room_Lab);
                cmd.Parameters.AddWithValue("class_room_lab_id", t.Class_Room_Lab_ID);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally
            {
                //test
                con.Close();
            }
        }

        public int DelEngineeringTimeTable(TimeTable t)
        {
            try
            {
                sql = "DELETE from al_time_table WHERE no=@no";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("no", t.No);

                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally
            {
                //test
                con.Close();
            }
        }

        public int DelcomineeringTimeTable(TimeTable t)
        {
            try
            {
                sql = "DELETE from grade_six_to_nine_time_table WHERE no=@no";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("no", t.No);

                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally
            {
                //test
                con.Close();
            }
        }

        public int DelmngineeringTimeTable(TimeTable t)
        {
            try
            {
                sql = "DELETE from ol_time_table WHERE no=@no";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("no", t.No);

                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally
            {
                //test
                con.Close();
            }
        }

        public int UpStaffTable(Staff s)
        {
            try
            {
                sql = "Update teacher SET first_name=@fname,last_name=@lname,user_name=@uname,nic=@nic,designation=@dsg,[date_of_birth]=@dob,age=@age,qualifications=@qlf,[joined_date]=@jdate,phone=@phone,email=@email WHERE id=@id ";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("id", s.Id);
                cmd.Parameters.AddWithValue("fname", s.First_name);
                cmd.Parameters.AddWithValue("lname", s.Last_name);
                cmd.Parameters.AddWithValue("uname", s.User_name);
                cmd.Parameters.AddWithValue("nic", s.NIC);
                cmd.Parameters.AddWithValue("dsg", s.Designation);
                cmd.Parameters.AddWithValue("dob", s.Date_of_birth);
                cmd.Parameters.AddWithValue("age", s.Age);
                cmd.Parameters.AddWithValue("qlf", s.Qualifications);
                cmd.Parameters.AddWithValue("jdate", s.Joined_date);
                cmd.Parameters.AddWithValue("phone", s.Phone);
                cmd.Parameters.AddWithValue("email", s.Email);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally
            {
                //test
                con.Close();
            }
        }

        public int UpStudentTable(Student st)
        {
            try
            {
                sql = "Update student set first_name=@fname,last_name=@lname,user_name=@uname,admission_no=@admission_no,section=@section,grade=@grade,class=@class,email=@email,phone=@phone where id=@id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("id", st.Id);
                cmd.Parameters.AddWithValue("fname", st.First_name);
                cmd.Parameters.AddWithValue("lname", st.Last_name);
                cmd.Parameters.AddWithValue("uname", st.User_name);
                cmd.Parameters.AddWithValue("admission_no", st.Admission_no);
                cmd.Parameters.AddWithValue("section", st.Section);
                cmd.Parameters.AddWithValue("grade", st.Grade);
                cmd.Parameters.AddWithValue("class", st.Class);
                cmd.Parameters.AddWithValue("email", st.Email);
                cmd.Parameters.AddWithValue("phone", st.Phone);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally
            {
                //test
                con.Close();
            }
        }

        public int Delstaff(Staff s)
        {
            try
            {
                sql = "DELETE from teacher WHERE id=@id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("id", s.Id);

                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally
            {
                //test
                con.Close();
            }
        }

        public int Delstudent(Student s)
        {
            try
            {
                sql = "DELETE from student WHERE id=@id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("id", s.Id);

                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally
            {
                //test
                con.Close();
            }
        }

        public List<Staff> getstf()
        {
            List<Staff> stf = new List<Staff>();

            try
            {
                con.Open();

                sql = "SELECT id,first_name,last_name,user_name,nic,designation,[date_of_birth],age,qualifications,[joined_date],phone,email FROM teacher";

                cmd.CommandText = sql;
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Staff st = new Staff()
                    {
                        Id = reader[0].ToString(),
                        First_name = reader[1].ToString(),
                        Last_name = reader[2].ToString(),
                        User_name = reader[3].ToString(),
                        NIC = reader[4].ToString(),
                        Designation = reader[5].ToString(),
                        Date_of_birth = reader[6].ToString(),
                        Age = reader[8].ToString(),
                        Qualifications = reader[9].ToString(),
                        Joined_date = reader[10].ToString(),
                        Phone = reader[10].ToString(),
                        Email = reader[11].ToString(),

                    };
                    stf.Add(st);
                }
                return stf;
            }
            catch (Exception) { throw; }
            con.Close();
        }

        public List<Student> getstu()
        {
            List<Student> stu = new List<Student>();

            try
            {
                con.Open();

                sql = "SELECT id,first_name,last_name,user_name,admission_no,section,grade,class,email,phone FROM student";

                cmd.CommandText = sql;
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Student st = new Student()
                    {
                        Id = reader[0].ToString(),
                        First_name = reader[1].ToString(),
                        Last_name = reader[2].ToString(),
                        User_name = reader[3].ToString(),
                        Admission_no = reader[4].ToString(),
                        Section = reader[5].ToString(),
                        Grade = reader[6].ToString(),
                        Class = reader[7].ToString(),
                        Email = reader[8].ToString(),
                        Phone = reader[9].ToString(),


                    };
                    stu.Add(st);
                }
                return stu;
            }
            catch (Exception) { throw; }
            con.Close();
        }


        public List<newstfshw> getstfIDnEmail()
        {
            List<newstfshw> ss = new List<newstfshw>();

            try
            {
                con.Open();

                sql = "SELECT id,email FROM teacher";

                cmd.CommandText = sql;
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    newstfshw st = new newstfshw()
                    {
                        Id = reader[0].ToString(),
                        Email = reader[1].ToString(),



                    };
                    ss.Add(st);
                }
                return ss;
            }
            catch (Exception) { throw; }
            con.Close();
        }

        public List<TimeTable> GetCurrentComTimeTable()
        {
            List<TimeTable> timetable3 = new List<TimeTable>();
            try
            {
                con.Open();
                String currentDate = DateTime.Today.ToString("yyyy-MM-dd");
                sql = "SELECT no,grade,class,subject,teacher,[date],[time],class_room_lab,class_room_lab_id FROM grade_six_to_nine_time_table where [date]=@currentDate";
                cmd.Parameters.AddWithValue("currentDate", currentDate);
                cmd.CommandText = sql;
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TimeTable t = new TimeTable()
                    {
                        No = reader[0].ToString(),
                        Grade = reader[1].ToString(),
                        Class = reader[2].ToString(),
                        Subject = reader[3].ToString(),
                        Teacher = reader[4].ToString(),
                        Date = reader[5].ToString(),
                        Time = reader[6].ToString(),
                        Class_Room_Lab = reader[7].ToString(),
                        Class_Room_Lab_ID = reader[8].ToString(),
                    };
                    timetable3.Add(t);
                }
                return timetable3;
            }
            catch (Exception) { throw; }
            con.Close();
        }

        public List<TimeTable> GetCurrentMngTimeTable()
        {
            List<TimeTable> timetable3 = new List<TimeTable>();
            try
            {
                con.Open();
                String currentDate = DateTime.Today.ToString("yyyy-MM-dd");
                sql = "SELECT no,grade,class,subject,teacher,[date],[time],class_room_lab,class_room_lab_id FROM ol_time_table where [date]=@currentDate";
                cmd.Parameters.AddWithValue("currentDate", currentDate);
                cmd.CommandText = sql;
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TimeTable t = new TimeTable()
                    {
                        No = reader[0].ToString(),
                        Grade = reader[1].ToString(),
                        Class = reader[2].ToString(),
                        Subject = reader[3].ToString(),
                        Teacher = reader[4].ToString(),
                        Date = reader[5].ToString(),
                        Time = reader[6].ToString(),
                        Class_Room_Lab = reader[7].ToString(),
                        Class_Room_Lab_ID = reader[8].ToString(),
                    };
                    timetable3.Add(t);
                }
                return timetable3;
            }
            catch (Exception) { throw; }
            con.Close();
        }


        public List<TimeTable> GetCurrentEngTimeTable()
        {
            List<TimeTable> timetable3 = new List<TimeTable>();
            try
            {
                con.Open();
                String currentDate = DateTime.Today.ToString("yyyy-MM-dd");
                sql = "SELECT no,grade,class,subject,teacher,[date],[time],class_room_lab,class_room_lab_id FROM al_time_table where [date]=@currentDate";
                cmd.Parameters.AddWithValue("currentDate", currentDate);
                cmd.CommandText = sql;
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TimeTable t = new TimeTable()
                    {
                        No = reader[0].ToString(),
                        Grade = reader[1].ToString(),
                        Class = reader[2].ToString(),
                        Subject = reader[3].ToString(),
                        Teacher = reader[4].ToString(),
                        Date = reader[5].ToString(),
                        Time = reader[6].ToString(),
                        Class_Room_Lab = reader[7].ToString(),
                        Class_Room_Lab_ID = reader[8].ToString(),
                    };
                    timetable3.Add(t);
                }
                return timetable3;
            }
            catch (Exception) { throw; }
            con.Close();
        }


        public List<Staff> Userlogine()
        {
            List<Staff> log = new List<Staff>();
            try
            {
                con.Open();

                sql = "SELECT id,user_name from teacher";
                cmd.CommandText = sql;
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Staff t = new Staff()
                    {
                        User_name = reader[0].ToString(),
                        Id = reader[1].ToString(),
                    };
                    log.Add(t);
                }
                return log;
            }
            catch (Exception) { throw; }
            con.Close();
        }

        public Staff SearchStaff(string id)
        {
            string sql = "SELECT * FROM teacher WHERE id=@id";
            try
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("id", id);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    Staff s = new Staff();
                    while (reader.Read())
                    {

                        s.Id = reader[0].ToString();
                        s.First_name = reader[1].ToString();
                        s.Last_name = reader[2].ToString();
                        s.User_name = reader[3].ToString();
                        s.NIC = reader[4].ToString();
                        s.Designation = reader[5].ToString();
                        s.Date_of_birth = reader[6].ToString();
                        s.Age = reader[7].ToString();
                        s.Qualifications = reader[8].ToString();
                      ;
                        s.Joined_date = reader[9].ToString();
                        s.Phone = reader[10].ToString();
                        s.Email = reader[11].ToString();


                    }

                    return s;
                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public Student SearchStudent(string id)
        {

            string sql = "SELECT * FROM student WHERE id=@id";
            try
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("id", id);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    Student s = new Student();
                    while (reader.Read())
                    {

                        s.Id = reader[0].ToString();
                        s.First_name = reader[1].ToString();
                        s.Last_name = reader[2].ToString();
                        s.User_name = reader[3].ToString();
                        s.Admission_no = reader[4].ToString();
                        s.Section = reader[5].ToString();
                        s.Grade = reader[6].ToString();
                        s.Class = reader[7].ToString();
                        s.Email = reader[8].ToString();
                        s.Phone = reader[9].ToString();



                    }

                    return s;
                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public Staff WebLogin(string Id)
        {
            string sql = "SELECT id FROM teacher WHERE id=@id";
            try
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("id", Id);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    Staff s = new Staff();
                    while (reader.Read())
                    {

                        s.Id = reader["id"].ToString();
                        // u.password = reader["password"].ToString();

                    }

                    return s;
                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }

        }

        public Student WebLogin2(string Id)
        {
            string sql = "SELECT * FROM student WHERE admission_no=@admission_no";
            try
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("admission_no", Id);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    Student s = new Student();
                    while (reader.Read())
                    {

                        s.Id = reader["admission_no"].ToString();
                        s.User_name = reader["section"].ToString();

                    }

                    return s;
                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public TimeTable SearchengineeringTable(string no)
        {

            string sql = "SELECT * FROM al_time_table WHERE no=@no";
            try
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("no", no);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    TimeTable t = new TimeTable();
                    while (reader.Read())
                    {

                        t.No = reader[0].ToString();
                        t.Grade = reader[1].ToString();
                        t.Class = reader[2].ToString();
                        t.Subject = reader[3].ToString();
                        t.Teacher = reader[4].ToString();
                        t.Date = reader[5].ToString();
                        t.Time = reader[6].ToString();
                        t.Class_Room_Lab = reader[7].ToString();
                        t.Class_Room_Lab_ID = reader[8].ToString();




                    }

                    return t;
                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public TimeTable SearchComputingTable(string no)
        {

            string sql = "SELECT * FROM grade_six_to_nine_time_table WHERE no=@no";
            try
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("no", no);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    TimeTable t = new TimeTable();
                    while (reader.Read())
                    {

                        t.No = reader[0].ToString();
                        t.Grade = reader[1].ToString();
                        t.Class = reader[2].ToString();
                        t.Subject = reader[3].ToString();
                        t.Teacher = reader[4].ToString();
                        t.Date = reader[5].ToString();
                        t.Time = reader[6].ToString();
                        t.Class_Room_Lab = reader[7].ToString();
                        t.Class_Room_Lab_ID = reader[8].ToString();




                    }

                    return t;
                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public TimeTable SearchManagementTable(string no)
        {

            string sql = "SELECT * FROM ol_time_table WHERE no=@no";
            try
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("no", no);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    TimeTable t = new TimeTable();
                    while (reader.Read())
                    {

                        t.No = reader[0].ToString();
                        t.Grade = reader[1].ToString();
                        t.Class = reader[2].ToString();
                        t.Subject = reader[3].ToString();
                        t.Teacher = reader[4].ToString();
                        t.Date = reader[5].ToString();
                        t.Time = reader[6].ToString();
                        t.Class_Room_Lab = reader[7].ToString();
                        t.Class_Room_Lab_ID = reader[8].ToString();




                    }

                    return t;
                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

    }
}
