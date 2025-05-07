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
    }
}
