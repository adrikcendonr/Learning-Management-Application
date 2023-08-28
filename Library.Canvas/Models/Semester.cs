using System;
using Library.Canvas.Models;

namespace Library.Canvas.Models
{
    public enum SemesterTerm
    {
        Spring,
        Summer,
        Fall
    }


    public class Semester
    {
        public SemesterTerm Term { get; set; }
        public int Year { get; set; }

        public Semester(SemesterTerm term, int year)
        {
            Term = term;
            Year = year;
        }

        public Semester(Semester s)
        {
            Term = s.Term;
            Year = s.Year;
        }

        public Semester() { }

        private static Semester currentSemester = new Semester(SemesterTerm.Spring, 2023);
        public static Semester CurrentSemester
        {
            get
            {
                return new Semester(currentSemester);
            }
            set
            {
                currentSemester = value;
            }
        }

        public Semester MoreRecentThan(Semester s)
        {
            if (Term > s.Term && Year >= s.Year)
            {
                return this;
            }
            return s;
        }

        public static Semester Increment(Semester s)
        {
            Semester s2 = new Semester(s);
            s2.Term++;
            if (s2.Term > (SemesterTerm)2)
            {
                s2.Term = 0;
                s2.Year++;
            }
            return s2;
        }

        public static Semester Decrement(Semester s)
        {
            Semester s2 = new Semester(s);
            s2.Term--;
            if (s2.Term < 0)
            {
                s2.Term = (SemesterTerm)2;
                s2.Year--;
            }
            return s2;
        }

        public override bool Equals(object obj)
        {
            Semester? s = obj as Semester;

            if (s == null)
                throw new ArgumentNullException("Parameter cannot be null", nameof(obj));

            return Term == s.Term && Year == s.Year;
        }

        public override string ToString()
        {
            return $"{Term} {Year}";
        }
    }
}
