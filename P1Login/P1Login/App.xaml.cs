﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P1Login
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
           MainPage = new MainPage();
           // MainPage = new Page1();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
