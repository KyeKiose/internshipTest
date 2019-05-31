using InternshipTest.Person;
using System.Collections.Generic;
namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        string Name;
        List<Student> students;

        public Internship(string name)
        {
            Name = name;
        }

        public Internship(string name, University list)
        {
            Name = name;
            students = new List<Student>();
            for(int i = 0; i < list._Students.Count; i++)
            {
                if(list[i].Knowledge.LevelOfKnowledge >= list.AverageLevel())
                    students.Add(list[i]);
            }
        }
        public string GetStudents()
        {
            string result = "";
            for(int i = 0; i < students.Count; i++)
            {
                result += students[i] + "\n";
            }
            return result;
        }
    }
}
