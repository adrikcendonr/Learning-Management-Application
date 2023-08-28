using System;
namespace Library.Canvas.Models
{
	public class TeachingAssistant : Person
	{
		public TeachingAssistant()
		{
		}

        public override string ToString()
        {
            return $"[{Id}] {Name}";
        }
    }
}

