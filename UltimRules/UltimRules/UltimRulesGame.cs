using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimRules
{
    public class Question
    {
        public string Text { get; set; }
        public string Answer { get; set; }
    }

    public class UltimRulesGame
    {
        private Queue<Question> Questions { get; set; }

        public string CurrentQuestion { get; set; }
        public string CurrentAnswer { get; set; }

        public UltimRulesGame()
        {
            Questions = new Queue<Question>();

            Questions.Enqueue(new Question { Text = "Question numero 1", Answer = "reponse 1" });
            Questions.Enqueue(new Question { Text = "Question numero 2", Answer = "reponse 2" });
        }
        
        public void NextQuestion()
        {
            Question question = Questions.Dequeue();
            CurrentQuestion = question.Text;
            CurrentAnswer = question.Answer;
            Questions.Enqueue(question);
        }
    }
}
