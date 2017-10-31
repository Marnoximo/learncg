using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlJoin
{
    public class Db_view
    {
        public string Sname { get; set; }
        public bool Gender { get; set; }
        public string Class { get; set; }

        public Db_view(string sname, bool gender, string @class)
        {
            Sname = sname;
            Gender = gender;
            Class = @class;
        }
    }
}
