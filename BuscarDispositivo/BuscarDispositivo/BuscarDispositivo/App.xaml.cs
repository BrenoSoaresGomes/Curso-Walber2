﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuscarDispositivo.Views;
using Xamarin.Forms;

namespace BuscarDispositivo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TelaListaPessoa();
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
