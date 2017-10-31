using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlJoin
{
    public class Student
    {
        public string Id { get; set;}
        public string Name { get; set;}
        public string Class { get; set;}
        public bool Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string FacultyId { get; set; }

        public Student(string id, string name, string @class, bool gender, DateTime birthday, string FID)
        {
            Id = id;
            Name = name;
            Class = @class;
            Gender = gender;
            Birthday = birthday;
            FacultyId = FID;
        }
    }
}
