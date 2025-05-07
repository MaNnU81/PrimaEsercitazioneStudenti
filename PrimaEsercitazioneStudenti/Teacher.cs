using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaEsercitazioneStudenti
{
    internal class Teacher
    {
        public required string Name { get; set; }
        public string? Surname { get; set; }
        public string? Subject { get; set; }


        public Student[] Students { get; set; }
        public Teacher(string name, string? surname, string? subject, Student[] students)
        {
            Name = name;
            Surname = surname;
            Subject = subject;
            Students = students;
        }


        public Teacher()
        {
            Students = Array.Empty<Student>();
        }

        // Inizializzazione degli insegnanti
        private static Teacher[] teachers = new Teacher[]
        {
            new Teacher
            {
                Name = "Pico",
                Surname = "De Paperis",
                Subject = "Math",
                Students = new Student[] { Student.Students[0], Student.Students[2] }
            },
            new Teacher
            {
                Name = "Archimede",
                Surname = "Pitagorico",
                Subject = "Chemistry",
                Students = new Student[] { Student.Students[0], Student.Students[1], Student.Students[2] }
            },
            new Teacher
            {
                Name = "Zapotec",
                Subject = "Physics",
                Students = new Student[] { Student.Students[0], Student.Students[2], Student.Students[1] }
            }
        };

        

        public static void DisplayCardTeacher()
        {
            foreach (var teacher in teachers)
            {
                Console.WriteLine("---------------TEACHER--------------------------");
                Console.WriteLine($"Nome: {teacher.Name}, Cognome: {teacher.Surname}, Materia: {teacher.Subject}");
                Console.WriteLine("Lista Studenti:");
                foreach (var student in teacher.Students)
                {
                    Console.WriteLine($"- {student.Name} {student.Surname}");
                }
                
            }
            Console.WriteLine("-----------------END------------------------------");
        }
    }
}