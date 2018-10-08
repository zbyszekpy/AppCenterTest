﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppCenterTestApp.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppCenterTestApp
{
  public partial class App : Application
  {

    public App()
    {
      InitializeComponent();


      MainPage = new MainPage();
    }

    protected override void OnStart()
    {
      // Handle when your app starts
    }

    protected override void OnSleep()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume()
    {
      // Handle when your app resumes
    }
  }
}
