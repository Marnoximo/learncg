using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SqlJoin
{
    public class SV_DAL
    {
        public DataHelper dataHelper { get; set; }

        public SV_DAL(string cntString)
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
                list.Add(new Student(i["id"].ToString(), i["name"].ToString(), i["class"].ToString(), (bool) i["gender"], (DateTime) i["birthday"], i["FacultyId"].ToString()));
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
        
        public List<Db_view> getListDbView()
        {
            string query = "select name, gender, class from sinhvien.dbo.sv2";
            List<Db_view> list = new List<Db_view>();
            foreach (DataRow i in dataHelper.ExecuteDataSet(query).Rows)
            {
                list.Add(new Db_view(i["name"].ToString(), (bool) i["gender"], i["class"].ToString()));
            }
            return list;
        }
    }
}
