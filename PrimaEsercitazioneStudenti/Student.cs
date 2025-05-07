using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PrimaEsercitazioneStudenti
{
    internal class Student
    {
        public string Name { get; set; } = string.Empty; // Fix for CS8618    
        public string Surname { get; set; } = string.Empty; // Fix for CS8618    
        public string Gender { get; set; } = string.Empty; // Fix for CS8618    

        private int _yob;
        public int Yob
        {
            get => _yob;
            set
            {
                if (value < 1920)
                {
                    _yob = 1920;
                }
                else
                {
                    _yob = value;
                }
            }
        }
        public int[] Marks { get; set; }

        public Student(string name, string surname, string gender, int yob, int[] marks)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Yob = yob;
            Marks = marks;
        }

        public double CalculateMean()
        {
            int sum = 0;
            foreach (var mark in Marks)
            {
                sum += mark;
            }
            return (double)sum / Marks.Length;
        }

        public int CalculateAge()
        {
            DateTime currentDate = DateTime.Now;
            int currentYear = currentDate.Year;
            return currentYear - Yob;
        }

        public static void ExecuteStudentOperations()
        {
            Console.WriteLine("Esercizio 1: Studente singolo");

            Student[] students = new Student[4];
            students[0] = new Student("Mario", "Rossi", "Maschio", 2000, new int[] { 80, 90, 85 });
            double mean = students[0].CalculateMean();
            Console.WriteLine($"La media dello studente {students[0].Name} {students[0].Surname} è {mean}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Esercizio 2: Array di studenti");

            students[1] = new Student("Luigi", "Verdi", "Maschio", 1998, new int[] { 75, 80, 70 });
            students[2] = new Student("Anna", "Bianchi", "Femmina", 2001, new int[] { 95, 100, 90 });
            students[3] = new Student("Filippo", "Panegirico", "Maschio", 1996, new int[] { 60, 100, 100 });

            foreach (var student in students)
            {
                double studentMean = student.CalculateMean();
                Console.WriteLine($"La media dello studente {student.Name} {student.Surname} è {studentMean}");
            }
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("Esercizio 3: Lista di studenti schedati");
            foreach (var student in students)
            {
                double studentMean = student.CalculateMean();
                int studentAge = student.CalculateAge();
                string concatenatedMarks = string.Join("-", student.Marks);
                Console.WriteLine("----------STUDENT------------");
                Console.WriteLine($"Nome: {student.Name}, Cognome: {student.Surname}, Genere: {student.Gender}, " +
                    $"Anno Di Nascita: {student.Yob}, Età: {studentAge}, Lista Voti: {concatenatedMarks}, Media Voti: {studentMean}");
                
            }
        }


        public static Student[] Students = new Student[]
       {
            new Student("Mario", "Rossi", "Maschio", 2000, new int[] { 80, 90, 85 }),
            new Student("Luigi", "Verdi", "Maschio", 1998, new int[] { 75, 80, 70 }),
            new Student("Anna", "Bianchi", "Femmina", 2001, new int[] { 95, 100, 90 }),
            new Student("Filippo", "Panegirico", "Maschio", 1996, new int[] { 60, 100, 100 })
        };
    }
}
