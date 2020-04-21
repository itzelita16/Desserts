using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Proyecto_desserts1.Services;
using Proyecto_desserts1.Views;

namespace Proyecto_desserts1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
