using System;
using Library.Canvas.Models;

namespace Maui.Canvas.ViewModels
{
	public class MainViewModel
	{
        public List<Person> Students { get; set; } = new List<Person>();

        public MainViewModel()
		{
		}
	}
}

