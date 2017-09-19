using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi4_QuanLySinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentList list = new StudentList();
            while (true)
            {
                Console.WriteLine("Options:\n" +
                                  "1/ Add\n" +
                                  "2/ Edit\n" +
                                  "3/ Delete\n" +
                                  "4/ Search\n" +
                                  "5/ Show\n" +
                                  "6/ Exit\n" +
                                  "Your choice: ");
                int opt;
                opt = Console.Read();
                
                

            }
        }

        static void Add(ref StudentList list)
        {
            int id,drl;
            string name;
            double gpa;
            Console.WriteLine("Add a new student:\n");
            Console.Write("Id= ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name= ");
            name = Console.ReadLine();
            Console.Write("GPA= ");
            gpa = Convert.ToDouble(Console.ReadLine());
            Console.Write("DRL= ");
            drl = Convert.ToInt16(Console.ReadLine());

            Student sv = new Student(id, name, gpa, drl);
            list.Add(sv);
        }

        static void Edit(ref StudentList list)
        {
            int id, drl;
            string name;
            double gpa;
            Console.WriteLine("Edit an entry:\n");
            Console.Write("Id= ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name= ");
            name = Console.ReadLine();
            Console.Write("GPA= ");
            gpa = Convert.ToDouble(Console.ReadLine());
            Console.Write("DRL= ");
            drl = Convert.ToInt16(Console.ReadLine());

            Student sv = new Student(id, name, gpa, drl);
        }
    }

    class StudentList
    {
        private Student[] list = new Student[100];
        private int cnt = 0;

        public void Add(Student s)
        {
            list[cnt] = s;
            cnt++;
        }
        
        public bool Delete(int id)
        {
            for(int i=0;i<cnt;i++)
            {
                if(list[i].Id==id)
                {
                    for (int j = i; j < cnt - 1; j++)
                        list[j] = list[j + 1];
                    cnt--;
                    return true;
                }
            }
            return false;
        }

        public int Search(string str)
        {
            int num = 0;
            for(int i=0;i<cnt;i++)
            {
                if (list[i].Name.Contains(str))
                {
                    list[i].Show();
                    num++;
                }
            }
            return num;
        }

        public void Show()
        {
            for (int i = 0; i < cnt; i++)
                list[i].Show();
        }

        public void Edit(Student s)
        {
            for(int i=0;i<cnt;i++)
            {
                if(list[i].Id==s.Id)
                {
                    list[i].Name = s.Name;
                    list[i].Gpa = s.Gpa;
                    list[i].Drl = s.Drl;
                }
            }
        }
    }
}
