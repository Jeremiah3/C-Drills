using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practicing Object oriented programming with Linq.
            //Sorry guys my naming skills is not so creative.

            List<Student> stud = new List<Student>()
        {
            new Student() { Id = 32465, FirstName = "Amy", LastName = "Loudermilk", Grade = 12, GradeAverage = 95 },
            new Student() { Id = 42465, FirstName = "Quentin", LastName = "Williams", Grade = 12, GradeAverage = 100 },
            new Student() { Id = 42365, FirstName = "Jeremiah", LastName = "Walker", Grade = 12, GradeAverage = 100 },
            new Student() { Id = 22465, FirstName = "Jack", LastName = "Stanely", Grade = 10, GradeAverage = 85 }
        };

            //Creating a Query.
            var _students = from _stud in stud
                            where _stud.Grade == 12
                            select _stud;

            //Executing the Query
            foreach (var mates in _students)
            {
                Console.WriteLine("Students: {0} {1} {2} {3}", mates.Id, mates.FirstName, mates.LastName, mates.GradeAverage);
            }

            List<Teacher> teach = new List<Teacher>()
            {
                new Teacher() { iD = 23234, firstName = "Amanda", lastName = "Jackson" },
                new Teacher() { iD = 34213, firstName = "Bob", lastName = "Tabor" },
                new Teacher() { iD = 43234, firstName = "Jada", lastName = "Perl"}
            };

            foreach (var T in teach)
            {
                Console.WriteLine("Teachers: {0} {1} {2}", T.iD, T.firstName, T.lastName);
            }


        }
    }


    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public int GradeAverage { get; set; }
    }
    

    

    class Teacher
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int iD { get; set; }
    }
}
