﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics_AssociationRelationship
{
    class Student
    {
        public string Name { set; get; }
        public string RegNo { set; get; }
        public string Email { set; get; }

        public Student(string name, string regNo, string email)
        {
            Name = name;
            Email = email;
            RegNo = regNo;
        }
    }
}
