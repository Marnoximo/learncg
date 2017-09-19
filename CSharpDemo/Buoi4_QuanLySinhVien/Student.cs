using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi4_QuanLySinhVien
{
    
    class Student
    {
        private int id;
        private string name;
        private double gpa;
        private int drl;
        private string rank;

        private void calcRank()
        {
            if (gpa >= 3.6 && drl >= 90)
                rank = "EXCELLENT";
            else if (gpa >= 3.2 && drl >= 80)
                rank = "GOOD";
            else
                rank = "BAD";
        }

        public Student(int id, string name, double gpa, int drl)
        {
            Id = id;
            Name = name;
            Gpa = gpa;
            Drl = drl;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Gpa {
            get => gpa;
            set
            {
                if (value >= 0 && value <= 4.0)
                {
                    gpa = value;
                    calcRank();
                }
                    
            }
        }

        public int Drl {
            get => drl;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    drl = value;
                    calcRank();
                }
            }
        }

        public void Show()
        {
            Console.WriteLine(id.ToString() + " " + name.ToString());
            Console.WriteLine("\t" + gpa.ToString() + "\t" + drl.ToString() + "\t" + rank.ToString());
        }
    }
}
