using System;

namespace InternshipTest.Person
{
    public class Student
    {
        string Name;
        Knowledge knowledge;
        public Student(string name)
        {
            Name = name;
        }

        public void SetKnowledge(Knowledge k)
        {
            knowledge = k;
        }
        public Knowledge Knowledge
        {
            get => knowledge;
        }
        public override string ToString()
        {
            return "Name: " + Name;
        }

    }
}