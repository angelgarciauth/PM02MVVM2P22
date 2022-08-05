
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM02MVVM2P22
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.PageListAlumnos());
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
