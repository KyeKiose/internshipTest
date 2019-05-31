using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        string Name;
        List<Student> students;
        public University(string name)
        {
            Name = name;
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public Student this[int i]
        {
            get => students[i];
            set => students[i] = value;
        }
        public List<Student> _Students
        {
            get => students;
        }
        public int AverageLevel()
        {
            int average = 0;
            for (int i = 0; i < this.students.Count; i++)
            {
                average += students[i].Knowledge.LevelOfKnowledge;
            }
            return average / students.Count;
        }
    }
}
