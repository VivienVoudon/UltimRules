using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UR.Core;
using Xamarin.Forms;

namespace UltimRules
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            UltimRulesGame viewModel = ((App)Application.Current).UltimRulesGame;
            BindingContext = viewModel;
        }

        void OnPlay(object sender, EventArgs e)
        {
            ((App)Application.Current).UltimRulesGame.NextQuestion();
            Navigation.PushAsync(new QuestionPage());
        }
    }
}
