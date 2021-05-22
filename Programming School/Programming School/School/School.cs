using System.Collections.Generic;
using Programming_School.Persons;

namespace Programming_School.School

{
    public class School
    {
        private static School instance = null;
        public List<Mentor> Mentors { get; set; }
        public List<Student> Students { get; set; }
        public List<SalaryPerson> SalaryPersons { get; set; }

        private School()
        {
            Mentors = new List<Mentor>();
            Students = new List<Student>();
            SalaryPersons = new List<SalaryPerson>();
        }

        public static School getInstance()
        {
            if (instance == null)
            {
                instance = new School();
            }
            return instance;
        }

        public void HireMentor(Mentor mentor)
        {
            Mentors.Add(mentor);
        }

        public void AcceptStudent(Student student)
        {
            Students.Add(student);
        }

    }
}