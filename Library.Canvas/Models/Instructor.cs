using System;
namespace Library.Canvas.Models
{
	public class Instructor : Person
	{
		public Instructor()
		{
		}

        public override string ToString()
        {
            return $"[{Id}] {Name}";
        }
    }
}

