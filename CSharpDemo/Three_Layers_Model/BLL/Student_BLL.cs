using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Three_Layers_Model
{
    public class Student_BLL
    {
        public Student_DAL dal;
        public Student_BLL(string cntString)
        {
            dal = new Student_DAL(cntString);
        }

        public List<Student> ListSV()
        {
            return dal.getListSV();
        }

        public void AddStudent(Student student)
        {

        }

        public void SearchStudent(Student student)
        {

        }
    }
}
