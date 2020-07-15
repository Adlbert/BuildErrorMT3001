using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BuildErrorMT3001.Services;
using BuildErrorMT3001.Views;

namespace BuildErrorMT3001 {
    public partial class App : Application {

        public App() {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart() {
        }

        protected override void OnSleep() {
        }

        protected override void OnResume() {
        }
    }
}
