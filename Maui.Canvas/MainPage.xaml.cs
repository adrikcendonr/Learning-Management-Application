﻿using Maui.Canvas.ViewModels;

namespace Maui.Canvas;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }

    private void StudentClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Student");
    }

    private void InstructorClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Instructor");
    }
}


