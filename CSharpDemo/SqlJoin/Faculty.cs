using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlJoin
{
    public class Faculty
    {
        public string FacultyId { get; set; }
        public string FacultyName { get; set; }

        public Faculty(string facultyId, string facultyName)
        {
            FacultyId = facultyId;
            FacultyName = facultyName;
        }
    }
}
