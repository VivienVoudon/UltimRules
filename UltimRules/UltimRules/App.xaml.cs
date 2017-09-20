using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace UltimRules
{
    public partial class App : Application
    {
        public UltimRulesGame UltimRulesGame { get; internal set; }

        public App()
        {
            UltimRulesGame = new UltimRulesGame();
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
