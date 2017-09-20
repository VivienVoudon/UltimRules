using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UltimRules
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionPage : ContentPage
    {
        private QuestionViewModel Question { get; set; }

        private UltimRulesGame Game { get; set; }

        public QuestionPage()
        {
            InitializeComponent();

            Game = ((App)Application.Current).UltimRulesGame;

            BindingContext = new QuestionViewModel(Game);
        }

        void OnAnswer(object sender, EventArgs e)
        {
            lblAnswer.IsVisible = true;
            btNextQuestion.IsVisible = true;
            btRule.IsVisible = true;
        }

        void OnNextQuestion(object sender, EventArgs e)
        {
            Game.NextQuestion();
            BindingContext = new QuestionViewModel(Game);

            lblAnswer.IsVisible = false;
            btNextQuestion.IsVisible = false;
            btRule.IsVisible = false;
        }

        void OnRule(object sender, EventArgs e)
        {
            
        }
    }
}