using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentStormer
{
    class StormGroup
    {

        public Queue<Student> students = new Queue<Student>();
        public string name;
        public int score = 0; 

        public StormGroup(string n)
        {
            name = n;
        }

        public void AddStudents(List<Student> slist)
        {
            foreach (Student s in slist)
            {
                students.Enqueue(s);
            }

        }

        public void AddStudentHistory()
        {
            List<int> hist = new List<int>();
            foreach (Student s in students)
            {
                hist.Add(s.id);
            }

            foreach (Student s in students)
            {
                s.groupHistory = s.groupHistory.Union(hist);
            }

        }

        public int ScoreGroup()
        {

            // take a union all student historys
            // cycle through students
            List<int> groupHistory = new List<int>();


            foreach (Student s in students)
            {
                var tmp = groupHistory.Union(s.groupHistory);
                // groupHistory = s.groupHistory.Union(groupHistory);
                //var listB = new List<int> { 3, 4, 5 };
                //var listA = new List<int> { 1, 2, 3, 4, 5 };
                //var listFinal = listA.Union(listB);
            }

            return 1;
        }

        public void printGroupInfo()
        {
            Console.WriteLine($"{name}: {score}");
            foreach(Student s in students)
            {
                Console.WriteLine($"\t{s.name}: {s.id}");
            }

        }
    }
}
