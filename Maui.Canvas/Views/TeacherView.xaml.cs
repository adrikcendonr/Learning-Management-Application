using Maui.Canvas.ViewModels;

namespace Maui.Canvas.Views;

public partial class TeacherView : ContentPage
{
    public TeacherView()
    {
        InitializeComponent();
        BindingContext = new TeacherViewModel();
    }

    private void CancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }

    private void AddEnrollmentClick(object sender, EventArgs e)
    {
        (BindingContext as TeacherViewModel).AddEnrollmentClick(Shell.Current);
    }

    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        (BindingContext as TeacherViewModel).RefreshView();
    }

    private void RemoveEnrollmentClick(object sender, EventArgs e)
    {
        (BindingContext as TeacherViewModel).RemoveEnrollmentClick();
    }

    private void EditEnrollmentClick(object sender, EventArgs e)
    {
        (BindingContext as TeacherViewModel).AddEnrollmentClick(Shell.Current);
    }

    private void AddCourseClick(object sender, EventArgs e)
    {
        (BindingContext as TeacherViewModel).AddCourseClick(Shell.Current);
    }

    private void EditCourseClick(object sender, EventArgs e)
    {
        (BindingContext as TeacherViewModel).AddCourseClick(Shell.Current);
    }

    private void RemoveCourseClick(object sender, EventArgs e)
    {
        (BindingContext as TeacherViewModel).RemoveCourseClick();
    }

    private void AddAssignmentClick(object sender, EventArgs e)
    {
        (BindingContext as TeacherViewModel).AddCourseClick(Shell.Current);
    }

    private void RemoveAssignmentClick(object sender, EventArgs e)
    {
        (BindingContext as TeacherViewModel).RemoveCourseClick();
    }

    private void Toolbar_EnrollmentsClicked(object sender, EventArgs e)
    {
        (BindingContext as TeacherViewModel).ShowEnrollments();
    }

    private void Toolbar_CoursesClicked(object sender, EventArgs e)
    {
        (BindingContext as TeacherViewModel).ShowCourses();
    }
}