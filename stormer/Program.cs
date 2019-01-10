using System;
using System.Collections.Generic;
using System.Linq;
using StudentStormer;
namespace StudentStormer
{
    class Program
    {

        static void Main(string[] args)
        {
                                 
            int numberOfGroups = 10;
            //build the data
            var students = BuildData(100);

            // radomize order of list

            students.Shuffle();

            //var randStudents = students.OrderBy(a => Guid.NewGuid()).ToList();

            // distribute among the groups

           
            var groups = new List<StormGroup>();

            for(int i = 0; i < numberOfGroups; i++)
            {
                groups.Add(new StormGroup($"Group {i}"));

                var randos = students.Skip(i*numberOfGroups).Take(numberOfGroups).ToList();
                foreach (Student s in randos) {
                   // System.Console.WriteLine($"\t{s.name}");
                    groups[i].students.Enqueue(s);
                }
            }

            foreach (StormGroup g in groups)
            {
                g.printGroupInfo();                
            }

            //randStudents.Take(10);
            System.Console.ReadKey();
        }

        static List<Student> BuildData(int s)
        {
            List<Student> students = new List<Student>();

            for (var i = 0; i < s; i++)
            {
                students.Add(new Student(i, $"student{i}"));
            }

            return students;
        }
        /// <summary>
        ///    Option (attempt to build perfect option):
        ///         1: assign random student 1 to each group
        ///         2: each subsequent asignment check the other students in the group
        ///             2a: if the placed guy is already  par tof the group history,
        ///             kick the new guy back to the heap
        ///             2b: reasign another guy.. re-check... reasign...
        ///             
        ///     Option 2 (randomly assign groups, assign similarity score)
        ///         1: assign students randomly 
        ///         2: somehow calculate a solution score
        ///         3: iterate n times
        ///         4: pick the best score
        ///         
        /// </summary>
        /// <returns></returns>
        /// 
        public List<StormGroup> RegroupStormers()
        {
            var sg = new List<StormGroup>();

            return sg;
        }
        




    }



}