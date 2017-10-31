using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Three_Layers_Model
{
    public class Student_DAL
    {
        public DataHelper dataHelper { get; set; }

        public Student_DAL(string cntString)
        {
            this.dataHelper = new DataHelper(cntString);
        }

        public List<Student> getListSV()
        {
            string query = "select * from sinhvien.dbo.sv2";
            List<Student> list = new List<Student>();
            //DataTable dt = dataHelper.ExecuteDataSet(query);
            foreach (DataRow i in dataHelper.ExecuteDataSet(query).Rows)
            {
                list.Add(new Student(i["id"].ToString(), i["name"].ToString(), i["class"].ToString(), (bool)i["gender"], (DateTime)i["birthday"], i["FacultyId"].ToString()));
            }
            return list;
        }

        public List<Faculty> getListFaculty()
        {
            string query = "select * from sinhvien.dbo.faculty";
            List<Faculty> list = new List<Faculty>();
            foreach (DataRow i in dataHelper.ExecuteDataSet(query).Rows)
            {
                list.Add(new Faculty(i["facultyid"].ToString(), i["facultyname"].ToString()));
            }
            return list;
        }

        public Student GetStudent(string id)
        {
            string query = "select * from sinhvien.dbo.sv2 where ID = '" + id + "'";
            Student student = new Student();
            foreach (DataRow i in dataHelper.ExecuteDataSet(query).Rows)
            {
                student.Id = i["id"].ToString();
                student.Name = i["name"].ToString();
                student.Class = i["class"].ToString();
                student.FacultyId = i["facultyid"].ToString();
                student.Birthday = (DateTime) i["birthday"];
                student.Gender = (bool) i["gender"];
            }
            return student;
        }

        public void AddStudent(Student student)
        {
            string query = "INSERT INTO sinhvien.dbo.SV2 VALUES ('" + student.Id + "', '"
                                                                              + student.Name + "', '"
                                                                              + student.Class + "', '"
                                                                              + student.Birthday.ToShortDateString() + "', "
                                                                              + student.Gender + ", '"
                                                                              + student.FacultyId + "')";
            dataHelper.ExecuteNonQuery(query);
        }

        public void DeleteStudent(string id)
        {
            string query = "delete * from sinhvien.dbo.sv2 where id = '" + id + "'";
            dataHelper.ExecuteNonQuery(query);
        }

        public void UpdateStudent(Student student)
        {
            string query = "UPDATE sinhvien.dbo.SV2 SET Name= '" + student.Name
                                            + "', Class= '" + student.Class
                                            + "', Birthday= '" + student.Birthday.ToShortDateString()
                                            + "', Gender= " + student.Gender
                                            + ", FacultyId = '" + student.FacultyId
                                            + "' WHERE ID= '" + student.Id + "'";
            dataHelper.ExecuteNonQuery(query);
        }

        public List<Student> Search(string id)
        {
            string query = "select * from sinhvien.dbo.sv2 where id = '" + id +"'";
            List<Student> list = new List<Student>();
            //DataTable dt = dataHelper.ExecuteDataSet(query);
            foreach (DataRow i in dataHelper.ExecuteDataSet(query).Rows)
            {
                list.Add(new Student(i["id"].ToString(), i["name"].ToString(), i["class"].ToString(), (bool)i["gender"], (DateTime)i["birthday"], i["FacultyId"].ToString()));
            }
            return list;
        }

        /*
        public List<Db_view> getListDbView()
        {
            string query = "select name, gender, class from sinhvien.dbo.sv2";
            List<Db_view> list = new List<Db_view>();
            foreach (DataRow i in dataHelper.ExecuteDataSet(query).Rows)
            {
                list.Add(new Db_view(i["name"].ToString(), (bool)i["gender"], i["class"].ToString()));
            }
            return list;
        }
        */
    }
}
