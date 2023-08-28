using Library.Canvas.Models;
using Library.Canvas.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Maui.Canvas.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string ClassificationString { get; set; }

        public int Id { get; set; }

        public PersonViewModel(int id = 0)
        {
            if (id > 0)
            {
                LoadById(id);
            }
        }

        public void LoadById(int id)
        {
            if (id == 0) { return; }
            var person = StudentService.Current.GetById(id) as Student;
            if (person != null)
            {
                Name = person.Name;
                Id = person.Id;
                ClassificationString = ClassToString(person.Classification);
            }

            NotifyPropertyChanged(nameof(Name));
            NotifyPropertyChanged(nameof(ClassificationString));

        }

        public void AddPerson()
        {

            if (Id <= 0)
            {
                StudentService.Current.Add(new Student { Name = Name, Classification = StringToClass(ClassificationString) });
            }
            else
            {
                var refToUpdate = StudentService.Current.GetById(Id) as Student;
                refToUpdate.Name = Name;
                refToUpdate.Classification = StringToClass(ClassificationString);
            }
            Shell.Current.GoToAsync("//Instructor");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private StudentClass StringToClass(string s)
        {
            StudentClass classification;
            switch (s)
            {
                case "S":
                    classification = StudentClass.Senior;
                    break;
                case "J":
                    classification = StudentClass.Junior;
                    break;
                case "O":
                    classification = StudentClass.Sophmore;
                    break;
                case "F":
                default:
                    classification = StudentClass.Freshman;
                    break;
            }

            return classification;
        }

        private string ClassToString(StudentClass pc)
        {
            var classificationString = string.Empty;
            switch (pc)
            {
                case StudentClass.Senior:
                    classificationString = "S";
                    break;
                case StudentClass.Junior:
                    classificationString = "J";
                    break;
                case StudentClass.Sophmore:
                    classificationString = "O";
                    break;
                case StudentClass.Freshman:
                default:
                    classificationString = "F";
                    break;
            }
            return classificationString;
        }
    }
}