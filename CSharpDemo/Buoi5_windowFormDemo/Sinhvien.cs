using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Buoi5_windowFormDemo
{
    class Sinhvien
    {
        int id;
        String name;
        String faculty;
        String gender;
        DateTime birthday;
        String pro_lan;

        public Sinhvien(int id, string name, string faculty)
        {
            this.id = id;
            this.name = name;
            this.faculty = faculty;
        }
    }
}
