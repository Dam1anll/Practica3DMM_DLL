﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Practica3DMM_DLL.View;

namespace Practica3DMM_DLL
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaPrincipal();
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
