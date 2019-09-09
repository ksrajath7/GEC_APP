using System;
using GEC_APP.MainView;
using GEC_APP.Feed;
using GEC_APP.Profile;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GEC_APP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FeedPage();
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
