using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics_AssociationRelationship
{
    class Department
    {
        public string Code { set; get; }
        public string Name { set; get; }

        private List<Student> students = new List<Student>(); 
        public Department(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public string Add(Student aStudent)
        {
            if (HasThisRegNo(aStudent.RegNo))
            {
                return "This student has already exists";
            }
            else
            {
                students.Add(aStudent);
                return "Added";
                
            }
        }

        private bool HasThisRegNo(string regNo)
        {
            foreach (Student aStudent in students)
            {
                if (aStudent.RegNo == regNo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
