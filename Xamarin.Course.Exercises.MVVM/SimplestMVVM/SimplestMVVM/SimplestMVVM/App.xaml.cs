﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimplestMVVM.ViewModels;
using SimplestMVVM.Pages;
using Xamarin.Forms;

namespace SimplestMVVM
{
    public partial class App : Application
    {
        public App()
        {
            
            InitializeComponent(); //giver nogle settings vi gerne vil bruge

            //create ViewModel
            //var viewModel = new SimpleViewModel();
            //MainPage = new SimplePage(viewModel);

            var loginViewModel = new LoginViewModel(); //en instans af vores viewmodel
            MainPage = new LoginPage(loginViewModel);

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
