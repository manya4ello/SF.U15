using System;
using System.Collections.Generic;
using System.Linq;

namespace unit15
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            return (from cl in classes
                    from student in cl.Students
                    select student).ToArray();
            
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}