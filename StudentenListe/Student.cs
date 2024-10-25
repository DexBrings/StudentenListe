using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentenListe
{
    internal class Student
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public float GradePointAverage { get; private set; }


        public Student(int id, string name, float gradePointAverage)
        {
            Id = id;
            Name = name;
            GradePointAverage = gradePointAverage;
        }
    }
}
