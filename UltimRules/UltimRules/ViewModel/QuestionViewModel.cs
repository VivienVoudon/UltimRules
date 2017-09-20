using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UR.Core;

namespace UltimRules.ViewModel
{
    public class QuestionViewModel : INotifyPropertyChanged
    {
        public string question { get; set; }
        public string Question
        {
            set
            {
                if (question != value)
                {
                    question = value;

                    // Fire the event.
                    PropertyChangedEventHandler handler = PropertyChanged;

                    if (handler != null)
                    {
                        handler(this, new PropertyChangedEventArgs("Question"));
                    }
                }
            }

            get
            {
                return question;
            }
        }

        public string answer { get; set; }
        public string Answer
        {
            set
            {
                if (answer != value)
                {
                    answer = value;

                    // Fire the event.
                    PropertyChangedEventHandler handler = PropertyChanged;

                    if (handler != null)
                    {
                        handler(this, new PropertyChangedEventArgs("Answer"));
                    }
                }
            }

            get
            {
                return answer;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public QuestionViewModel()
        {
            Question = "je suis une question ?";
        }

        public QuestionViewModel(UltimRulesGame game)
        {
            Question = game.CurrentQuestion;
            Answer = game.CurrentAnswer;
        }
    }
}
