using System;
using System.Linq;
using System.Collections.Generic;

namespace StudentStormer
{
    public class Student
    {
        public string name;
        public int id;
        public IEnumerable<int> groupHistory;
        public Student(int i, string n)
        {
            id = i;
            name = n;
        }


    }
}