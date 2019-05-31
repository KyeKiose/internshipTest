using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using System.Collections.Generic;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University("CH.U.I.");
            university.AddStudent(new Student("Andrew Kostenko"));
            university.AddStudent(new Student("Julia Veselkina"));
            university.AddStudent(new Student("Maria Perechrest"));
            university.AddStudent(new Student("Ivan Ivanov"));
            for (int i = 0; i < university._Students.Count; i++)
            {
                Console.WriteLine(university[i] + " level of knowledge (0 - 100): ");
                university[i].SetKnowledge(new Knowledge(Convert.ToInt32(Console.ReadLine())));
            }
            Internship internship = new Internship("Interlink", university);
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
            Console.ReadKey();
        }
    }
}
