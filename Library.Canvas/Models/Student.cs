using System;
namespace Library.Canvas.Models
{
	public class Student : Person
	{
        public Dictionary<int, double> Grades { get; set; }

        public StudentClass Classification { get; set; }

        public Student()
        {
            Grades = new Dictionary<int, double>();
        }

        public override string ToString()
        {
            return $"[{Id}] {Name} - {Classification}";
        }
    }

    public enum StudentClass
    {
        Freshman,
        Sophmore,
        Junior,
        Senior
    }

}

